using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using VirginClassLibrary;

/// <summary>
///
/// This class handles the signup, login , check password and change password
/// credit it to Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
/// </summary>

namespace VirginClassLibrary
{
    public class clsVMAdminSecurity
    {
        public string AdminSignUp(string VMAdminUserName, string VMAdminPassword, string VMPasswordConfirm, string Secret)
        {
            //var to store any errors
            string ErrorMsg = "";
            //if the two password match
            if (VMAdminPassword == VMPasswordConfirm)
            {

                if (CheckPassword(VMAdminPassword) == "")
                {
                    //get the hash of the plain text password
                    string HashPassword = GetHashString(VMAdminPassword + VMAdminUserName);
                    //add the record to the database
                    clsDataConnection DB = new clsDataConnection();
                    //set the parameter for the stored procesdure
                    DB.AddParameter("@VMAdminUserName", VMAdminUserName);
                    DB.AddParameter("@VMAdminPassword", HashPassword);
                    DB.AddParameter("@SecretMessage", Secret);
                    //execute the query returning the primary key value
                    DB.Execute("sproc_tblVMAdminSecurity_Insert");
                }
                else
                {
                    ErrorMsg = CheckPassword(VMAdminPassword);
                }


            }

            else
            {
                //generate an error message
                ErrorMsg = "The Password do not match.";
            }
            return ErrorMsg;
        }

        private string GetHashString(string SomeText)
        {
            if (SomeText != "")//if there is text to process
            {
                //create an instance of the has generator
                SHA256Managed HashGenerator = new SHA256Managed();
                //var to store the final hash
                string HashString;
                //array to store the byte of he original text
                byte[] TextBytes;
                //array to store the byte of the original text
                byte[] HashBytes;
                //convert the text in the sting to an array of bytes
                TextBytes = System.Text.Encoding.UTF8.GetBytes(SomeText);
                //generate the has based on the array of bytes
                HashBytes = HashGenerator.ComputeHash(TextBytes);
                //generate the has string replacing blank characters with-
                HashString = BitConverter.ToString(HashBytes).Replace("-", "");
                return HashString;

            }
            else
            {
                //return a blank string
                return "";
            }
        }

        private Boolean ContainsNumber(string VMAdminPassword)
        {
            //checks to see if a password contains a number
            //var to indicate found
            Boolean Found = false;
            //counter for loop
            int Counter = 0;
            //used to store a single character
            char AChar;
            //while found is false and char less than 9
            while (Found == false & Counter < 9)
            {
                //set temp to the value of Counter plus 48 to point at the numeric ascii codes
                int Temp = Counter + 48;
                //get the char value of the ascii code
                AChar = (char)Temp;
                //if the code is in the password
                if (VMAdminPassword.Contains(AChar) == true)
                {
                    //set found = true
                    Found = true;
                }
                else
                {
                    //otherwise keep looking
                    Counter += 1;
                }
            }
            //return the state of found
            return Found;
        }

        public Boolean Login(string VMAdminUserName, string VMAdminPassword)
        {

            //convert the plain text password to a hash code
            VMAdminUserName = GetHashString(VMAdminPassword + VMAdminUserName);
            //find the record matching the user email to a has code
            clsDataConnection AdminAccount = new clsDataConnection();
            //add the parameters
            AdminAccount.AddParameter("@VMAdminUserName", VMAdminUserName);
            AdminAccount.AddParameter("@VMAdminPassword", VMAdminUserName);
            //execute the query
            AdminAccount.Execute("sproc_tblVMAdminSecurity_Login");
            if (AdminAccount.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ChangePassword(string VMAdminUserName, string Password1, string Password2, string Secret)
        {
            //used to change a users password
            //var to store any errors
            string Message = "";
            //if the secret password ok 


            clsDataConnection AdminAccount = new clsDataConnection();
            AdminAccount.AddParameter("@VMAdminUserName", VMAdminUserName);
            AdminAccount.AddParameter("@SecretMessage", Secret);
            AdminAccount.Execute("sproc_tblVMAdminSecurity_CheckSecret");
            if (AdminAccount.Count >= 1)
            {
                //if the two passwords match
                if (Password1 == Password2)
                {
                    //check pasword complexity
                    Message = CheckPassword(Password1);
                    if (Message == "")
                    {
                        //get the hash of the plain text password
                        string HashPassword = GetHashString(Password1 + VMAdminUserName);
                        //updat the password
                        clsDataConnection DB = new clsDataConnection();
                        DB.AddParameter("@VMAdminUserName", VMAdminUserName);
                        DB.AddParameter("@VMAdminPassword", HashPassword);
                        DB.Execute("sproc_tblVMAdminSecurity_UpdatePassword");
                        Message = "The password has been changed.";
                    }
                }
                //if the passwords do not match
                else
                {
                    //generate an error message
                    Message = "The passwords do not match.";
                }

            }

            else
            {
                Message = "Username or secret not correct";
            }

            //return the error message (if there is one)
            return Message;

        }

        private string CheckPassword(string VMAdminPassword)
        //used to check that the password meets requirments
        {
            string Err = "";
            //if the password is less then 7 characters
            if (VMAdminPassword.Length < 7 | VMAdminPassword.Length > 14)
            {
                Err = "Your password must be at least 7 characters ";
            }
            //if the password doesn't contain a number
            if (ContainsNumber(VMAdminPassword) == false)
            {
                Err = Err + "your password must contain a number ";
            }
            //return any errors
            return Err;
        }
    }
}
