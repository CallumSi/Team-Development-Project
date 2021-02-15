using System;

namespace VirginClassLibrary
{
    public class clsVHCPatient
    {

        //Patient_ID Property
        public int Patient_ID { get; set; }

        //Patient_Title Property 
        public string Patient_Title { get; set;}

        //Patient_Firstname Property 
        public string Patient_Firstname { get; set; }

        //Patient_Lastname Property 
        public string Patient_Lastname { get; set; }

        //Patient_Address Property 
        public string Patient_Address { get; set; }

        //Patient_DOB Property
        public DateTime Patient_DOB { get; set; }

        //Patient_Email Property 
        public string Patient_Email { get; set; }

        //Patient_Username Property
        public string Patient_Username { get; set; }

        //Patient_Password Property 
        public string Patient_Password { get; set; }

        //Patient_Telephone Property
        public string Patient_Telephone { get; set; }

        //Patient_Status Property
        public bool Patient_Status { get; set; }

        public string Valid(string Patient_Title, string Patient_Firstname, string Patient_Lastname, string Patient_Address, string Patient_DOB, string Patient_Email, string Patient_Username, string Patient_Password, string Patient_Telephone, string Patient_Status)
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

            if (Patient_Title.Length < 1 | Patient_Title.Length > 5)
            {
                //set the error message 
                Error = Error + "PATIENT TITLE MUST BE BETWEEN 1 TO 5 CHARACTERS!" + " ";
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
                Error = Error + "PATIENT TITLE MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
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

            //return any error messages
            return Error;

        }
    }
}