using System;

namespace VirginClassLibrary
{
    public class clsVHCAppointment
    {
        //Appointment_ID Property 
        public int Appointment_ID { get; set; }

        //Appointment_Date Property 
        public string Appointment_Date { get; set; }

        //Appointment_Time Property 
        public string Appointment_Time { get; set; }

        //Appointment_Description Property 
        public string Appointment_Description { get; set; }

        public string Valid(string Appointment_Date, string Appointment_Time, string Appointment_Description)
        {
            string Error = "";

            //create a temporary variable to store data values
            DateTime DateTemp;

            //Appointment Date Validation (1) 
            try
            {
                //copy the Appointment_Date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(Appointment_Date);
                //check to see if the appointment date is less than 1 day
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "THE APPOINTMENT DATE CANNOT BE IN THE PAST. PLEASE ENTER A VALID DATE!" + "  ";
                }

                //check to see if the appointment date is greater than 30 days
                if (DateTemp > DateTime.Now.Date.AddDays(30))
                {
                    //record the error
                    Error = Error + "THE APPOINTMENT DATE IS INVALID. PLEASE ENTER A VALID DATE!" + "  ";
                }
            }

            catch
            {
                //record the error 
                Error = Error + " THE DATA WAS NOT A VALID DATE: ";
            }

            //Appointment Time Validation (2) 

            //if appointment time  is blank 
            if (Appointment_Time.Length == 0)
            {
                //record the error 
                Error = Error + "APPOINTMENT TIME CANNOT BE BLANK!" + " ";

            }

            if (Appointment_Time.Length < 5 | Appointment_Time.Length > 5)
            {
                //set the error message 
                Error = Error + "APPOINTMENT TIME MUST BE 5 CHARACTERS!" + " ";
            }

            //Appointment Description Validation (3) 

            //if appointment description  is blank 
            if (Appointment_Description.Length == 0)
            {
                //record the error 
                Error = Error + "APPOINTMENT DESCRIPTION CANNOT BE BLANK!" + " ";

            }

            if (Appointment_Description.Length < 1 | Appointment_Description.Length > 150)
            {
                //set the error message 
                Error = Error + "APPOINTMENT DESCRIPTION MUST BE BETWEEN 1 AND 150 CHARACTERS!" + " ";
            }

            return Error;
        }
    }
}