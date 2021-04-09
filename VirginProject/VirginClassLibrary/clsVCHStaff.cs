using System.Collections.Generic;
using VirginClassLibrary;
using System;
using System.Linq;
using System.Text;

namespace VirginClassLibrary
{
    public class clsVCHStaff
    {
        //private staff ID property
        private int mStaffID;
        //private staff first name property 
        private string mStaffFirstName;
        //private staff last name property 
        private string mStaffLastName;
        //private staff address property 
        private string mStaffAddress;
        //private staff postcode property 
        private string mStaffPostCode;
        //private staff username property
        private string mStaffUsername;
        //private staff email property
        private string mStaffEmail;
        //private staff password property
        private string mStaffPassword;
        //private staff phone number property
        private string mStaffPhoneNumber;

        //StaffID property
        public int StaffID
        {
            get
            {
                //return the private data
                return mStaffID;
            }
            set
            {
                //set the private data
                mStaffID = value;
            }
        }

        //Staff First Name property
        public string StaffFirstName
        {
            get
            {
                //return the private data
                return mStaffFirstName;
            }
            set
            {
                //set the private data
                mStaffFirstName = value;
            }
        }

        //Staff Last Name property
        public string StaffLastName
        {
            get
            {
                //return the private data
                return mStaffLastName;
            }
            set
            {
                //set the private data
                mStaffLastName = value;
            }
        }

        //Staff Address property
        public string StaffAddress
        {
            get
            {
                //return the private data
                return mStaffAddress;
            }
            set
            {
                //set the private data
                mStaffAddress = value;
            }
        }

        //Staff Postcode property
        public string StaffPostCode
        {
            get
            {
                //return the private data
                return mStaffPostCode;
            }
            set
            {
                //set the private data
                mStaffPostCode = value;
            }
        }

        //Staff Username property
        public string StaffUsername
        {
            get
            {
                //return the private data
                return mStaffUsername;
            }
            set
            {
                //set the private data
                mStaffUsername = value;
            }
        }

        //Staff Email property
        public string StaffEmail
        {
            get
            {
                //return the private data
                return mStaffEmail;
            }
            set
            {
                //set the private data
                mStaffEmail = value;
            }
        }

        //Staff Password property
        public string StaffPassword
        {
            get
            {
                //return the private data
                return mStaffPassword;
            }
            set
            {
                //set the private data
                mStaffPassword = value;
            }
        }

        //Staff Phone Number property
        public string StaffPhoneNumber
        {
            get
            {
                //return the private data
                return mStaffPhoneNumber;
            }
            set
            {
                //set the private data
                mStaffPhoneNumber = value;
            }
        }

        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for StaffID to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHStaff_FilterByStaffID");
            //if one record is found (there should only be 1 or 0 records found)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffPostCode = Convert.ToString(DB.DataTable.Rows[0]["StaffPostCode"]);
                mStaffUsername = Convert.ToString(DB.DataTable.Rows[0]["StaffUsername"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                mStaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffPhoneNumber"]);
                //return that the method worked
                return true;
            }
            //if no record is found
            else
            {
                //return false - showing an error
                return false;
            }
        }

        //Valid Method
        public string Valid(string StaffFirstName, string StaffLastName, string StaffAddress, string StaffPostCode, string StaffUsername, string StaffEmail, string StaffPassword, string StaffPhoneNumber)
        {
            //string variable to store the error message
            string Error = "";
            //if the staffs first name length is blank
            if (StaffFirstName.Length == 0)
            {
                //return the following error message
                return "Staff first names may not be blank. Please enter a First Name.";
            }
            //if the staff first name length is more than 30 characters
            if (StaffFirstName.Length > 30)
            {
                //return the following error message
                return "The first name entered is not acceptable. Please try again with a shorter first name.";
            }
            //if the staff first name length is less than 2 characters
            if (StaffFirstName.Length < 2)
            {
                //return the following error message
                return "The first name entered is not acceptable. Please try again with a longer first name.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the staff last name length is blank
            if (StaffLastName.Length == 0)
            {
                //return the following error message
                return "Staff last names may not be blank. Please enter a Last Name.";
            }
            //if the staff last name length is more than 30 characters
            if (StaffLastName.Length > 30)
            {
                //return the following error message
                return "The last name entered is not acceptable. Please try again with a shorter last name.";
            }
            //if the staff last name length is less than 2 characters
            if (StaffLastName.Length < 2)
            {
                //return the following error message
                return "The last name entered is not acceptable. Please try again with a longer last name.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the staff address length is blank
            if (StaffAddress.Length == 0)
            {
                //return the following error message
                return "The address may not be blank. Please enter an address.";
            }
            //if the staff address length is more than 50 characters
            if (StaffAddress.Length > 50)
            {
                //return the following error message
                return "The address entered holds too many characters. Please enter a shorter address and do not include a postcode.";
            }
            //if the staff address length is less than 3 characters 
            if (StaffAddress.Length < 3)
            {
                //return the following error message
                return "The address entered is too short. Please enter a longer address and do not include a postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffPostCode length is blank
            if (StaffPostCode.Length == 0)
            {
                //return the following error message
                return "The postcode may not be blank. Please enter a postcode.";
            }
            //if the StaffPostCode length is more than 10 characters
            if (StaffPostCode.Length > 10)
            {
                //return the following error message
                return "The postcode entered holds too many characters. Please enter a shorter postcode.";
            }
            //if the StaffPostCode length is less than 5 characters 
            if (StaffPostCode.Length < 5)
            {
                //return the following error message
                return "The postcode entered is too short. Please enter a longer postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the username length is blank
            if (StaffUsername.Length == 0)
            {
                //return the following error message
                return "The Username may not be blank. Please enter a Username.";
            }
            //if the username length is more than 30 characters
            if (StaffUsername.Length > 30)
            {
                //return the following error message
                return "Usernames may not exceed 30 characters, please enter a shorter username.";
            }
            //if the username length is less than 2 characters
            if (StaffUsername.Length < 2)
            {
                //return the following error message
                return "Usernames require at least 2 characters, please enter a longer username.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffEmail length is blank
            if (StaffEmail.Length == 0)
            {
                //return the following error message
                return "The Email address may not be blank. Please enter an Email address.";
            }
            //if the StaffEmail length is more than 50 characters
            if (StaffEmail.Length > 50)
            {
                //return the following error message
                return "Email addresses cannot exceed 50 characters, please enter a shorter email address.";
            }
            //if the StaffEmail length is less than 7 characters 
            if (StaffEmail.Length < 7)
            {
                //return the following error message
                return "Email addresses require at least 7 characters, please enter a longer email address.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffPassword length is blank
            if (StaffPassword.Length == 0)
            {
                //return the following error message
                return "The Password may not be blank. Please enter a Password.";
            }
            //if the StaffPassword length is more than 20 characters
            if (StaffPassword.Length > 20)
            {
                //return the following error message
                return "Passwords may not exceed 20 characters, please enter a shorter password.";
            }
            //if the StaffPassword length is less than 6 characters 
            if (StaffPassword.Length < 6)
            {
                //return the following error message
                return "Passwords require at least 6 characters, please enter a longer password.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffPhoneNumber length is blank
            if (StaffPhoneNumber.Length == 0)
            {
                //return the following error message
                return "The Phone number may not be blank. Please enter a Phone number.";
            }
            //if the StaffPhoneNumber length is more than 11 characters
            if (StaffPhoneNumber.Length > 11)
            {
                //return the following error message
                return "Phone numbers may not exceed 11 numbers, please enter a shorter number.";
            }
            //if the StaffPhoneNumber length is less than 11 characters 
            if (StaffPhoneNumber.Length < 11)
            {
                //return the following error message
                return "Phone numbers require at 11 numbers, please enter a longer number.";
            }

            return Error;
        }
        
    }
}