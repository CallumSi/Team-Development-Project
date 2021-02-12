using System;

namespace VirginClassLibrary
{
    public class clsVHCPatient
    {
        //Patient_ID Property
        public int Patient_ID { get; set; }

        //Patient_Title Property 
        public string Patient_Title { get; set; }

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

        public Boolean Valid(string Patient_Title)
        {
            //var to record any errors found in Patient_Title assuming all is OK
            Boolean OK = true; 
            //test to see if the patient title has zero characters 
            if (Patient_Title.Length == 0)
            {
                //set OK to false
                OK = false; 
            }

            //test to see if the patient title is no more than 5 characters
            if (Patient_Title.Length > 5)
            {
                //set OK to false
                OK = false;
            }

            //return the results of all tests
            return OK; 

            
            
            
           
        }
    }
}