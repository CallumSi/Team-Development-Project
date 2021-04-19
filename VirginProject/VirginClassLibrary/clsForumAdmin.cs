using System;

namespace VirginClassLibrary
{
    public class clsForumAdmin
    {
        //pribate memeber for the Admin id proptery
        private Int32 mAdminID;
        //pribate memeber for the Admin first name
        private string mAdminFirstName;
        //pribate memeber for the Admin last nane
        private string mAdminLastName;
        //pribate memeber for the Admin email
        private string mAdminEmail;
        //pribate memeber for the Admin password
        private string mAdminPassword;
        //pribate memeber for the Admin username
        private string mAdminUserName;
        //pribate memeber for the OriginalID proptery
        private Int32 mOriginalID;

        //public property for user ID
        public clsForumAdmin()
        {

        }
        //public property for Admin ID
        public int AdminID
        {
            get
            {
                //return the priavate data
                return mAdminID;
            }
            set
            {
                //set the value of the private data member
                mAdminID = value;
            }
        }
        //public property for Admin First name
        public string AdminFirstName
        {
            get
            {
                //return the priavate data
                return mAdminFirstName;
            }
            set
            {
                //set the value of the private data member
                mAdminFirstName = value;
            }
        }
        //public property for Admin First name
        public int OriginalID
        {
            get
            {
                //return the priavate data
                return mOriginalID;
            }
            set
            {
                //set the value of the private data member
                mOriginalID = value;
            }
        }

        public bool FindOriginal(int AdminID)
        {
            //instantiate the data connection
            clsDataConnection DB = new clsDataConnection();
            //ad the parameter we use to search
            DB.AddParameter("OriginalID", AdminID);
            //execute the sproc
            DB.Execute("sproc_tblForumAdmin_FilterByOriginalID");
            //if record found 
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data variables
                AdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminID"]);
                mAdminFirstName = Convert.ToString(DB.DataTable.Rows[0]["AdminFirstName"]);
                mAdminLastName = Convert.ToString(DB.DataTable.Rows[0]["AdminLastName"]);
                mAdminEmail = Convert.ToString(DB.DataTable.Rows[0]["AdminEmailAddress"]);
                mOriginalID = Convert.ToInt32(DB.DataTable.Rows[0]["OriginalID"]);

                return true;
            }
            else
            {
                //return false if no record ofund
                return false;
            }
        }

        //public property for Admin last name
        public string AdminLastName
        {
            get
            {
                //return the priavate data
                return mAdminLastName;
            }
            set
            {
                //set the value of the private data member
                mAdminLastName = value;
            }
        }
        //public property for Admin email
        public string AdminEmail
        {
            get
            {
                //return the priavate data
                return mAdminEmail;
            }
            set
            {
                //set the value of the private data member
                mAdminEmail = value;
            }
        }
        //public property for Admin password
        public string AdminPassword
        {
            get
            {
                //return the priavate data
                return mAdminPassword;
            }
            set
            {
                //set the value of the private data member
                mAdminPassword = value;
            }
        }
        //public property for Admin UserName
        public string AdminUserName
        {
            get
            {
                //return the priavate data
                return mAdminUserName;
            }
            set
            {
                //set the value of the private data member
                mAdminUserName = value;
            }
        }

        public bool Find(int AdminID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the AdminID to search for
            DB.AddParameter("@AdminID", AdminID);
            //execute the stored procedure
            DB.Execute("sproc_tblForumAdmin_FilterByAdminID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mAdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminID"]);
                mAdminFirstName = Convert.ToString(DB.DataTable.Rows[0]["AdminFirstName"]);
                mAdminLastName = Convert.ToString(DB.DataTable.Rows[0]["AdminLastName"]);
                mAdminEmail = Convert.ToString(DB.DataTable.Rows[0]["AdminEmail"]);
                //mAdminPassword = Convert.ToString(DB.DataTable.Rows[0]["AdminPassword"]);
                //mAdminUserName = Convert.ToString(DB.DataTable.Rows[0]["AdminUserName"]);
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

        public string Valid(string AdminFirstName, string AdminLastName, string AdminEmail/*, string AdminPassword, string AdminUserName*/)
        {
            //create a string variable to store the error
            String Error = "";

            //if the first name is blank
            if (AdminFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
            //if the firstname is less than 1 and more than 15
            if (AdminFirstName.Length < 1 | AdminFirstName.Length > 15)
            {
                //record the error
                Error = Error + "The First name can have 1 letter also it must be less than 15 letters : ";
            }

            //if the Last name is blank
            if (AdminLastName.Length == 0)
            {
                //record the error
                Error = Error + "The last name may not be blank : ";
            }
            //if the last name is less than 1 and more than 15
            if (AdminLastName.Length < 1 | AdminLastName.Length > 15)
            {
                //record the error
                Error = Error + "The Last name can have 1 letter also it must be less than 15 letters : ";
            }

            //if the email is blank
            if (AdminEmail.Length == 0)
            {
                //record the error
                Error = Error + "The Email address may not be blank : ";
            }
            //if the email is more than 26 
            if (AdminEmail.Length >= 25)
            {
                //record the error
                Error = Error + "The Email address has to be less than 25.  ";
            }

            ////if the password is blank
            //if (AdminPassword.Length == 0)
            //{
            //    //record the error
            //    Error = Error + "The password may not be blank : ";
            //}
            ////if the password is more than 16
            //if (AdminPassword.Length > 16)
            //{
            //    //record the error
            //    Error = Error + "The password has to be less than 16 characters ";
            //}


            ////if the user name is blank
            //if (AdminUserName.Length == 0)
            //{
            //    //record the error
            //    Error = Error + "The username may not be blank : ";
            //}
            ////if the username is more than 16
            //if (AdminUserName.Length > 16)
            //{
            //    //record the error
            //    Error = Error + "The username has to be less than 16 characters ";
            //}

            return Error;
        }
    }
}