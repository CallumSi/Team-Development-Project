using System;

namespace VirginClassLibrary
{
    public class clsVHCStaff
    {
        //private data member for the Staff_ID property 
        private int mStaff_ID;

        //private data member for the Staff_Title property 
        private string mStaff_Title;

        //private data member for the Staff_Firstname property 
        private string mStaff_Firstname;

        //private data member for the Staff_Lastname property 
        private string mStaff_Lastname;

        //private data member for the Staff_Email property 
        private string mStaff_Email;

        //private data member for the Staff_Username property 
        private string mStaff_Username;

        //private data member for the Staff_Password property 
        private string mStaff_Password;

        //private data member for the Staff_Role property 
        private string mStaff_Role;

        //private data member for the Staff_Status property 
        private bool mStaff_Status;


        //Staff_ID roperty
        public int Staff_ID
        {
            get
            {
                //return the private data 
                return mStaff_ID;
            }


            set
            {

                mStaff_ID = value;
            }
        }
    
       
        //Staff_Title Property
        public string Staff_Title 
        {
            get
            {
                //return the private data 
                return mStaff_Title;
            }


            set
            {

                mStaff_Title = value;
            }

        }

        //Staff_Firstname Property
        public string Staff_Firstname 
        {
            get
            {
                //return the private data 
                return mStaff_Firstname;
            }


            set
            {

                mStaff_Firstname = value;
            }
        }

        //Staff_Lastname Property
        public string Staff_Lastname 
        {
            get
            {
                //return the private data 
                return mStaff_Lastname;
            }


            set
            {

                mStaff_Lastname = value;
            }

        }

        //Staff_Email Property
        public string Staff_Email
        {
            get
            {
                //return the private data 
                return mStaff_Email;
            }


            set
            {

                mStaff_Email = value;
            }
        }

        //Staff_Username Property
        public string Staff_Username 
        {
            get
            {
                //return the private data 
                return mStaff_Username;
            }


            set
            {

                mStaff_Username = value;
            }
        }

        //Staff_Password Property
        public string Staff_Password 
        {
            get
            {
                //return the private data 
                return mStaff_Password;
            }


            set
            {

                mStaff_Password = value;
            }
        }

        //Staff_Role Property
        public string Staff_Role 
        {
            get
            {
                //return the private data 
                return mStaff_Role;
            }


            set
            {

                mStaff_Role = value;
            }
        }

        //Staff_Status Property
        public bool Staff_Status 
        {
            get
            {
                //return the private data 
                return mStaff_Status;
            }


            set
            {

                mStaff_Status = value;
            }
        }

        public bool Find(int Staff_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Staff_ID to search for
            DB.AddParameter("@Staff_ID", Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCStaff_FilterByVHCStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaff_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_ID"]);
                mStaff_Title = Convert.ToString(DB.DataTable.Rows[0]["Staff_Title"]);
                mStaff_Firstname = Convert.ToString(DB.DataTable.Rows[0]["Staff_Firstname"]);
                mStaff_Lastname = Convert.ToString(DB.DataTable.Rows[0]["Staff_Lastname"]);
                mStaff_Email = Convert.ToString(DB.DataTable.Rows[0]["Staff_Email"]);
                mStaff_Username = Convert.ToString(DB.DataTable.Rows[0]["Staff_Username"]);
                mStaff_Password = Convert.ToString(DB.DataTable.Rows[0]["Staff_Password"]);
                mStaff_Role = Convert.ToString(DB.DataTable.Rows[0]["Staff_Role"]);
                mStaff_Status = Convert.ToBoolean(DB.DataTable.Rows[0]["Staff_Status"]);

                //return that everything worked OK
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid (string Staff_Title, string Staff_Firstname, string Staff_Lastname, string Staff_Email, string Staff_Username, string Staff_Password, string Staff_Role, string Staff_Status)
        {   
            //create a string variable to store data values
            String Error = "";

            // (1) Staff Title Validation

            //if staff title is blank 
            if (Staff_Title.Length == 0)
            {
                //record the error 
                Error = Error + "STAFF TITLE CANNOT BE BLANK!" + " ";

            }

            if (Staff_Title.Length < 2 | Staff_Title.Length > 5)
            {
                //set the error message 
                Error = Error + "STAFF TITLE MUST BE BETWEEN 2 TO 5 CHARACTERS!" + " ";
            }


            //// (2) Patient Firstname Validation

            ////if patient firstname is blank 
            //if (Patient_Firstname.Length == 0)
            //{
            //    //record the error 
            //    Error = Error + "PATIENT FIRSTNAME CANNOT BE BLANK!" + " ";

            //}

            //if (Patient_Firstname.Length < 1 | Patient_Firstname.Length > 50)
            //{
            //    //set the error message 
            //    Error = Error + "PATIENT FIRSTNAME MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            //}

            //// (3) Patient Lastname Validation

            ////if patient lastname is blank 
            //if (Patient_Lastname.Length == 0)
            //{
            //    //record the error 
            //    Error = Error + "PATIENT LASTNAME CANNOT BE BLANK!" + " ";

            //}

            //if (Patient_Lastname.Length < 1 | Patient_Lastname.Length > 50)
            //{
            //    //set the error message 
            //    Error = Error + "PATIENT LASTNAME MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            //}

            // (4) Staff Email Validation

            //if staff email is blank 
            if (Staff_Email.Length == 0)
            {
                //record the error 
                Error = Error + "STAFF EMAIL CANNOT BE BLANK!" + " ";

            }

            if (Staff_Email.Length < 11 | Staff_Email.Length > 50)
            {
                //set the error message 
                Error = Error + "STAFF EMAIL MUST BE BETWEEN 11 TO 50 CHARACTERS!" + " ";
            }

            // (5) Staff Username Validation

            //if staff username is blank 
            if (Staff_Username.Length == 0)
            {
                //record the error 
                Error = Error + "STAFF USERNAME CANNOT BE BLANK!" + " ";

            }

            if (Staff_Username.Length < 8 | Staff_Username.Length > 50)
            {
                //set the error message 
                Error = Error + "STAFF USERNAME MUST BE BETWEEN 8 TO 50 CHARACTERS!" + " ";
            }

            // (6) Staff Password Validation

            //if staff password is blank 
            if (Staff_Password.Length == 0)
            {
                //record the error 
                Error = Error + "STAFF PASSWORD CANNOT BE BLANK!" + " ";

            }

            if (Staff_Password.Length < 8 | Staff_Password.Length > 50)
            {
                //set the error message 
                Error = Error + "STAFF PASSWORD MUST BE BETWEEN 8 TO 50 CHARACTERS!" + " ";
            }


            // (7) Staff Role Validation

            //if staff role is blank 
            if (Staff_Role.Length == 0)
            {
                //record the error 
                Error = Error + "STAFF ROLE CANNOT BE BLANK!" + " ";

            }

            if (Staff_Role.Length < 1 | Staff_Role.Length > 50)
            {
                //set the error message 
                Error = Error + "STAFF ROLE MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            }


           

            //return any error messages
            return Error;

        }
    }
}