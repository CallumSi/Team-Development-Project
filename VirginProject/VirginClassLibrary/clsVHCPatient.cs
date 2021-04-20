using System;

namespace VirginClassLibrary
{
    ///This class uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019

    public class clsVHCPatient
    {
        //private data member for the Patient_ID property 
        private int mPatient_ID;

        //private data member for the Patient_Title property 
        private string mPatient_Title;

        //private data member for the Patient_Firstname property 
        private string mPatient_Firstname;

        //private data member for the Patient_Lastname property 
        private string mPatient_Lastname;

        //private data member for the Patient_Address property 
        private string mPatient_Address;

        //private data member for the Patient_DOB property 
        private DateTime mPatient_DOB;

        //private data member for the Patient_Email property 
        private string mPatient_Email;

        //private data member for the Patient_Username property 
        private string mPatient_Username;

        //private data member for the Patient_Password property 
        private string mPatient_Password;

        //private data member for the Patient_Telephone property 
        private string mPatient_Telephone;

        //private data member for the Patient_Status property 
        private bool mPatient_Status;


        //Patient_ID Property
        public int Patient_ID
        {
            get
            {
                //return the private data 
                return mPatient_ID;
            }

            set
            {
                mPatient_ID = value;
            }
        }

        //Patient_Title Property 
        public string Patient_Title
        {
            get
            {
                //return the private data 
                return mPatient_Title;
            }

            set
            {
                mPatient_Title = value;
            }
        }

        //Patient_Firstname Property 
        public string Patient_Firstname
        {
            get
            {
                //return the private data 
                return mPatient_Firstname;
            }

            set
            {
                mPatient_Firstname = value;
            }
        }

        //Patient_Lastname Property 
        public string Patient_Lastname
        {
            get
            {
                //return the private data 
                return mPatient_Lastname;
            }

            set
            {
                mPatient_Lastname = value;
            }
        }

        //Patient_Address Property 
        public string Patient_Address
        {
            get
            {
                //return the private data 
                return mPatient_Address;
            }

            set
            {
                mPatient_Address = value;
            }
        }

        //Patient_DOB Property
        public DateTime Patient_DOB
        {
            get
            {
                //return the private data 
                return mPatient_DOB;
            }

            set
            {
                mPatient_DOB = value;
            }
        }

        //Patient_Email Property 
        public string Patient_Email
        {
            get
            {
                //return the private data 
                return mPatient_Email;
            }

            set
            {
                mPatient_Email = value;
            }
        }

        //Patient_Username Property
        public string Patient_Username
        {
            get
            {
                //return the private data 
                return mPatient_Username;
            }

            set
            {
                mPatient_Username = value;
            }
        }

        //Patient_Password Property 
        public string Patient_Password

        {
            get
            {
                //return the private data 
                return mPatient_Password;
            }

            set
            {
                mPatient_Password = value;
            }

        }

        //Patient_Telephone Property
        public string Patient_Telephone
        {
            get
            {
                //return the private data 
                return mPatient_Telephone;
            }

            set
            {
                mPatient_Telephone = value;
            }
        }

        //Patient_Status Property
        public bool Patient_Status
        {
            get
            {
                //return the private data 
                return mPatient_Status;
            }

            set
            {
                mPatient_Status = value;
            }
        }

        public bool Find(int Patient_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Patient_ID to search for
            DB.AddParameter("@Patient_ID", Patient_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCPatient_FilterByVHCPatientID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mPatient_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Patient_ID"]);
                mPatient_Title = Convert.ToString(DB.DataTable.Rows[0]["Patient_Title"]);
                mPatient_Firstname = Convert.ToString(DB.DataTable.Rows[0]["Patient_Firstname"]);
                mPatient_Lastname = Convert.ToString(DB.DataTable.Rows[0]["Patient_Lastname"]);
                mPatient_Address = Convert.ToString(DB.DataTable.Rows[0]["Patient_Address"]);
                mPatient_DOB = Convert.ToDateTime(DB.DataTable.Rows[0]["Patient_DOB"]);
                mPatient_Email = Convert.ToString(DB.DataTable.Rows[0]["Patient_Email"]);
                mPatient_Username = Convert.ToString(DB.DataTable.Rows[0]["Patient_Username"]);
                mPatient_Password = Convert.ToString(DB.DataTable.Rows[0]["Patient_Password"]);
                mPatient_Telephone = Convert.ToString(DB.DataTable.Rows[0]["Patient_Telephone"]);
                mPatient_Status = Convert.ToBoolean(DB.DataTable.Rows[0]["Patient_Status"]);

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

        public string Valid(string Patient_Title, string Patient_Firstname, string Patient_Lastname, string Patient_Address, string Patient_DOB, string Patient_Email, string Patient_Username, string Patient_Password, string Patient_Telephone)
        {
            //create a string variable to store data values
            String Error = "";
       
            // (1) Patient Title Validation

            //if patient title is blank 
            if (Patient_Title.Length == 0)
            {
                //record the error 
                Error = Error + "PATIENT TITLE CANNOT BE BLANK!" + " ";

            }

            if (Patient_Title.Length < 2 | Patient_Title.Length > 5)
            {
                //set the error message 
                Error = Error + "PATIENT TITLE MUST BE BETWEEN 2 TO 5 CHARACTERS!" + " ";
            }


            // (2) Patient Firstname Validation

            //if patient firstname is blank 
            if (Patient_Firstname.Length == 0)
            {
                //record the error 
                Error = Error + "PATIENT FIRSTNAME CANNOT BE BLANK!" + " ";

            }

            if (Patient_Firstname.Length < 1 | Patient_Firstname.Length > 50)
            {
                //set the error message 
                Error = Error + "PATIENT FIRSTNAME MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            }

            // (3) Patient Lastname Validation

            //if patient lastname is blank 
            if (Patient_Lastname.Length == 0)
            {
                //record the error 
                Error = Error + "PATIENT LASTNAME CANNOT BE BLANK!" + " ";

            }

            if (Patient_Lastname.Length < 1 | Patient_Lastname.Length > 50)
            {
                //set the error message 
                Error = Error + "PATIENT LASTNAME MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            }

            // (4) Patient Address Validation

            //if patient address is blank 
            if (Patient_Address.Length == 0)
            {
                //record the error 
                Error = Error + "PATIENT ADDRESS CANNOT BE BLANK!" + " ";

            }

            if (Patient_Address.Length < 1 | Patient_Address.Length > 100)
            {
                //set the error message 
                Error = Error + "PATIENT ADDRESS MUST BE BETWEEN 1 TO 100 CHARACTERS!" + " ";
            }

            // (5) Patient DOB Validation
   
            //create a temporary variable to store data values
            DateTime DateTemp;

            // (5) Patient DOB Validation 
            try
            {
                //copy the Patient_DOB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(Patient_DOB);

                //check to see if the patient dob is less than 100 years
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error 
                    Error = Error + "THE PATIENT DOB CANNOT BE IN THE PAST. PLEASE ENTER A VALID DATE!" + "  ";
                }

                //check to see if the patient dob is greater than 100 years
                if (DateTemp > DateTime.Now.Date.AddYears(100))
                {
                    //record the error
                    Error = Error + "THE PATIENT DOB IS INVALID. PLEASE ENTER A VALID DATE!" + "  ";
                }
            }

            catch
            {
                //record the error 
                Error = Error + " THE DATA WAS NOT A VALID DATE: ";
            }

            // (6) Patient Email Validation

            //if patient email is blank 
            if (Patient_Email.Length == 0)
            {
                //record the error 
                Error = Error + "PATIENT EMAIL CANNOT BE BLANK!" + " ";

            }

            if (Patient_Email.Length < 11 | Patient_Email.Length > 50)
            {
                //set the error message 
                Error = Error + "PATIENT EMAIL MUST BE BETWEEN 11 TO 50 CHARACTERS!" + " ";
            }

            // (7) Patient Username Validation

            //if patient username is blank 
            if (Patient_Username.Length == 0)
            {
                //record the error 
                Error = Error + "PATIENT USERNAME CANNOT BE BLANK!" + " ";

            }

            if (Patient_Username.Length < 8 | Patient_Username.Length > 50)
            {
                //set the error message 
                Error = Error + "PATIENT USERNAME MUST BE BETWEEN 8 TO 50 CHARACTERS!" + " ";
            }

            // (8) Patient Password Validation

            //if patient password is blank 
            if (Patient_Password.Length == 0)
            {
                //record the error 
                Error = Error + "PATIENT PASSWORD CANNOT BE BLANK!" + " ";
            }

            if (Patient_Password.Length < 8 | Patient_Password.Length > 50)
            {
                //set the error message 
                Error = Error + "PATIENT PASSWORD MUST BE BETWEEN 8 TO 50 CHARACTERS!" + " ";
            }

            // (9) Patient Telephone Validation

            //if patient telephone is blank 
            if (Patient_Telephone.Length == 0)
            {
                //record the error 
                Error = Error + "PATIENT TELEPHONE CANNOT BE BLANK!" + " ";
            }

            if (Patient_Telephone.Length < 7 | Patient_Telephone.Length > 15)
            {
                //set the error message 
                Error = Error + "PATIENT TELEPHONE MUST BE BETWEEN 7 TO 15 DIGITS!" + " ";
            }

            //return any error messages
            return Error;
        }

       
    }
}