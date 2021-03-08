using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsForumUser
    {
        //pribate memeber for the User id proptery
        private Int32 mUserID;
        //pribate memeber for the User first name
        private string mUserFirstName;
        //pribate memeber for the User last nane
        private string mUserLastName;
        //pribate memeber for the User phone number
        private string mUserPhoneNumber;
        //pribate memeber for the User email
        private string mUserEmail;
        //pribate memeber for the User password
        private string mUserPassword;
        //pribate memeber for the User username
        private string mUserusername;
        //public property for user ID
        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the value of the private data member
                mUserID = value;
            }
        }
        //public property for user first name
        public string UserFirstName
        {
            get
            {
                //return the private data
                return mUserFirstName;
            }
            set
            {
                //set the value of the private data member
                mUserFirstName = value;
            }
        }
        //public property for user last name
        public string UserLastName
        {
            get
            {
                //return the private data
                return mUserLastName;
            }
            set
            {
                //set the value of the private data member
                mUserLastName = value;
            }
        }
        //public property for user phone number
        public string UserPhoneNumber
        {
            get
            {
                //return the private data
                return mUserPhoneNumber;
            }
            set
            {
                //set the value of the private data member
                mUserPhoneNumber = value;
            }
        }
        //public property for user email address
        public string UserEmail
        {
            get
            {
                //return the private data
                return mUserEmail;
            }
            set
            {
                //set the value of the private data member
                mUserEmail = value;
            }
        }
        //public property for user password
        public string UserPassword
        {
            get
            {
                //return the private data
                return mUserPassword;
            }
            set
            {
                //set the value of the private data member
                mUserPassword = value;
            }
        }
        //public property for User username
        public string Userusername
        {
            get
            {
                //return the private data
                return mUserusername;
            }
            set
            {
                //set the value of the private data member
                mUserusername = value;
            }
        }


        public clsForumUser()
        {

        }

        public bool Find(int UserID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@UserId", UserID);
            //execute the stored procedure
            DB.Execute("sproc_tblForumUser_FilterByUserID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserFirstName = Convert.ToString(DB.DataTable.Rows[0]["UserFirstName"]);
                mUserLastName = Convert.ToString(DB.DataTable.Rows[0]["UserLastName"]);
                mUserPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["UserPhoneNumber"]);
                mUserEmail = Convert.ToString(DB.DataTable.Rows[0]["UserEmailAddress"]);
                mUserPassword = Convert.ToString(DB.DataTable.Rows[0]["UserPassword"]);
                mUserusername = Convert.ToString(DB.DataTable.Rows[0]["Userusername"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false inidating a problem
                return false;
            }


        }


        public string Valid(string UserFirstName, string UserLastName, string UserEmail, string UserPassword, string UserPhoneNumber, string Userusername)
        {
            //create a string variable to store the error
            String Error = "";

            //if the FirstName is blank
            if (UserFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The FirstName may not be blank : ";
            }
            //if the FirstName is less than 1 and more than 15
            if (UserFirstName.Length < 1 | UserFirstName.Length > 15)
            {
                //record the error
                Error = Error + "The FirstName can have 1 letter also it must be less than 15 letters : ";
            }

            //if the Last name is blank
            if (UserLastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name may not be blank : ";
            }
            //if the last name is less than 2 and more than 15
            if (UserLastName.Length < 2 | UserLastName.Length > 15)
            {
                //record the error
                Error = Error + "The Last name can be 2 letter also it must be less than 15 letters : ";
            }

            //if the Phone number is blank
            if (UserPhoneNumber.Length == 0)
            {
                //record the error
                Error = Error + "The phone number may not be blank : ";
            }
            //if the Phone number is more than 11
            if (UserPhoneNumber.Length != 11)
            {
                //record the error
                Error = Error + "The phone number has to be 11 numbers. ";
            }

            //if the email is blank
            if (UserEmail.Length == 0)
            {
                //record the error
                Error = Error + "The Email address may not be blank : ";
            }
            //if the email is more than 26 
            if (UserEmail.Length > 26)
            {
                //record the error
                Error = Error + "The Email address has to 26 numbers ";
            }

            //if the password is blank
            if (UserPassword.Length == 0)
            {
                //record the error
                Error = Error + "The password may not be blank : ";
            }
            //if the email is more than 16
            if (UserPassword.Length > 16)
            {
                //record the error
                Error = Error + "The password has to be less than 16 characters ";
            }

            //if the Username is blank
            if (Userusername.Length == 0)
            {
                //record the error
                Error = Error + "The username may not be blank : ";
            }
            //if the username is more than 16
            if (Userusername.Length > 16)
            {
                //record the error
                Error = Error + "The username has to be less than 16 characters ";
            }

            //return any error message
            return Error;
        }
    }
}