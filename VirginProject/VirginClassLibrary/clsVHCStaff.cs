﻿using System;

namespace VirginClassLibrary
{
    public class clsVHCStaff
    {
        //Staff_ID roperty
        public int Staff_ID { get; set; }

        //Staff_Title Property
        public string Staff_Title { get; set; }

        //Staff_Firstname Property
        public string Staff_Firstname { get; set; }

        //Staff_Lastname Property
        public string Staff_Lastname { get; set; }

        //Staff_Email Property
        public string Staff_Email { get; set; }

        //Staff_Username Property
        public string Staff_Username { get; set; }

        //Staff_Password Property
        public string Staff_Password { get; set; }

        //Staff_Role Property
        public string Staff_Role { get; set; }

        //Staff_Status Property
        public bool Staff_Status { get; set; }

        public string Valid(string Staff_Title, string Staff_Firstname, string Staff_Lastname, string Staff_Email, string Staff_Username, string Staff_Password, string Staff_Role, string Staff_Status)
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


            // (2) Staff Firstname Validation

            //if staff firstname is blank 
            if (Staff_Firstname.Length == 0)
            {
                //record the error 
                Error = Error + "STAFF FIRSTNAME CANNOT BE BLANK!" + " ";

            }

            if (Staff_Firstname.Length < 1 | Staff_Firstname.Length > 50)
            {
                //set the error message 
                Error = Error + "STAFF FIRSTNAME MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            }


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

            //// (4) Patient Address Validation

            ////if patient address is blank 
            //if (Patient_Address.Length == 0)
            //{
            //    //record the error 
            //    Error = Error + "PATIENT ADDRESS CANNOT BE BLANK!" + " ";

            //}

            //if (Patient_Address.Length < 1 | Patient_Address.Length > 100)
            //{
            //    //set the error message 
            //    Error = Error + "PATIENT ADDRESS MUST BE BETWEEN 1 TO 100 CHARACTERS!" + " ";
            //}


            //// (6) Patient Email Validation

            ////if patient email is blank 
            //if (Patient_Email.Length == 0)
            //{
            //    //record the error 
            //    Error = Error + "PATIENT EMAIL CANNOT BE BLANK!" + " ";

            //}

            //if (Patient_Email.Length < 11 | Patient_Email.Length > 50)
            //{
            //    //set the error message 
            //    Error = Error + "PATIENT EMAIL MUST BE BETWEEN 11 TO 50 CHARACTERS!" + " ";
            //}

            //// (7) Patient Username Validation

            ////if patient username is blank 
            //if (Patient_Username.Length == 0)
            //{
            //    //record the error 
            //    Error = Error + "PATIENT USERNAME CANNOT BE BLANK!" + " ";

            //}

            //if (Patient_Username.Length < 8 | Patient_Username.Length > 50)
            //{
            //    //set the error message 
            //    Error = Error + "PATIENT USERNAME MUST BE BETWEEN 8 TO 50 CHARACTERS!" + " ";
            //}

            //// (8) Patient Password Validation

            ////if patient password is blank 
            //if (Patient_Password.Length == 0)
            //{
            //    //record the error 
            //    Error = Error + "PATIENT PASSWORD CANNOT BE BLANK!" + " ";
            //}

            //if (Patient_Password.Length < 8 | Patient_Password.Length > 50)
            //{
            //    //set the error message 
            //    Error = Error + "PATIENT PASSWORD MUST BE BETWEEN 8 TO 50 CHARACTERS!" + " ";
            //}

            //// (9) Patient Telephone Validation

            ////if patient telephone is blank 
            //if (Patient_Telephone.Length == 0)
            //{
            //    //record the error 
            //    Error = Error + "PATIENT TELEPHONE CANNOT BE BLANK!" + " ";
            //}

            //if (Patient_Telephone.Length < 7 | Patient_Telephone.Length > 15)
            //{
            //    //set the error message 
            //    Error = Error + "PATIENT TELEPHONE MUST BE BETWEEN 7 TO 15 DIGITS!" + " ";
            //}


            //return any error messages
            return Error;

        }
    }
}