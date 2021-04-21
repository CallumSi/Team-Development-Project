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
    public class clsForumAdminSecurity
    {
        public string AdminSignUp(string AdminUserName, string AdminPassword, string PasswordConfirm, string Secret)
        {
            //var to store any errors
            string ErrorMsg = "";
            //if the two password match
            if (AdminPassword == PasswordConfirm)
            {

                if (CheckPassword(AdminPassword) == "")
                {
                    //get the hash of the plain text password
                    string HashPassword = GetHashString(AdminPassword + AdminUserName);
                    //add the record to the database
                    clsDataConnection DB = new clsDataConnection();
                    //set the parameter for the stored procesdure
                    DB.AddParameter("@AdminUserName", AdminUserName);
                    DB.AddParameter("@AdminPassword", HashPassword);
                    DB.AddParameter("@SecretMessage", Secret);
                    //execute the query returning the primary key value
                    DB.Execute("sproc_tblForumAdminSecurity_Insert");
                }
                else
                {
                    ErrorMsg = CheckPassword(AdminPassword);
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
        private Boolean ContainsNumber(string AdminPassword)
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
                if (AdminPassword.Contains(AChar) == true)
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
        private string CheckPassword(string AdminPassword)
        //used to check that the password meets requirments
        {
            string Err = "";
            //if the password is less then 7 characters
            if (AdminPassword.Length < 7 | AdminPassword.Length > 14)
            {
                Err = "Your password must be at least 7 characters ";
            }
            //if the password doesn't contain a number
            if (ContainsNumber(AdminPassword) == false)
            {
                Err = Err + "your password must contain a number ";
            }
            //return any errors
            return Err;
        }
        public Boolean Login(string AdminUserName, string AdminPassword)
        {

            //convert the plain text password to a hash code
            AdminPassword = GetHashString(AdminPassword + AdminUserName);
            //find the record matching the user email to a has code
            clsDataConnection AdminAccount = new clsDataConnection();
            //add the parameters
            AdminAccount.AddParameter("@AdminUserName", AdminUserName);
            AdminAccount.AddParameter("@AdminPassword", AdminPassword);
            //execute the query
            AdminAccount.Execute("sproc_tblForumAdminSecurity_Login");
            if (AdminAccount.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
        public string ChangePassword(string AdminUserName, string Password1, string Password2, string Secret)
        {
            //used to change a users password
            //var to store any errors
            string Message = "";
            //if the secret password ok 


            clsDataConnection AdminAccount = new clsDataConnection();
            AdminAccount.AddParameter("@AdminUserName", AdminUserName);
            AdminAccount.AddParameter("@SecretMessage", Secret);
            AdminAccount.Execute("sproc_tblForumAdminSecurity_CheckSecret");
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
                        string HashPassword = GetHashString(Password1 + AdminUserName);
                        //updat the password
                        clsDataConnection DB = new clsDataConnection();
                        DB.AddParameter("@AdminUserName", AdminUserName);
                        DB.AddParameter("@AdminPassword", HashPassword);
                        DB.Execute("sproc_tblForumAdminSecurity_UpdatePassword");
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

        public Boolean Pin(string Pin)
        {
            clsDataConnection AdminAccount = new clsDataConnection();
            AdminAccount.AddParameter("@Pin", Pin);
            AdminAccount.Execute("sproc_tblVirginAdmin_CheckPin");
            if (AdminAccount.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

