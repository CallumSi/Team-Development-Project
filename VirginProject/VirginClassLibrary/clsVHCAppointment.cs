using System;

namespace VirginClassLibrary
{
    ///This class uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    

    public class clsVHCAppointment
    {
        //private data member for the Appointment_ID property 
        private int mAppointment_ID;

        //private data member for the Appointment_Date property 
        private DateTime mAppointment_Date;

        //private data member for the Appointment_Time property 
        private int mAppointment_Time;

        //private data member for the Appointment_Description property 
        private string mAppointment_Description;

        //Appointment_ID Property 
        public int Appointment_ID 
        {
            get
            {
                //return the private data 
                return mAppointment_ID;
            }

            set
            {
                mAppointment_ID = value;
            }
        }

        //Appointment_Date Property 
        public DateTime Appointment_Date
        {
            get
            {
                //return the private data 
                return mAppointment_Date;
            }

            set
            {
                //return the private data 
                mAppointment_Date = value;
            }
        }

        //Appointment_Time Property 
        public int Appointment_Time 
        {
            get
            {
                //return the private data 
                return mAppointment_Time;
            }

            set
            {
                //return the private data 
                mAppointment_Time = value;
            }
        }

        //Appointment_Description Property 
        public string Appointment_Description 
        {
            get
            {
                //return the private data 
                return mAppointment_Description;
            }

            set
            {
                //return the private data 
                mAppointment_Description = value;
            }
        }


        public bool Find(int Appointment_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Appointment_ID to search for
            DB.AddParameter("@Appointment_ID", Appointment_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCAppointment_FilterByVHCAppointmentID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mAppointment_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Appointment_ID"]);
                mAppointment_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Appointment_Date"]);
                mAppointment_Time = Convert.ToInt32(DB.DataTable.Rows[0]["Appointment_Time"]);
                mAppointment_Description = Convert.ToString(DB.DataTable.Rows[0]["Appointment_Description"]);
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

            ////Appointment Time Validation(2)
            
            try
            {
                Int32 TempAppointmentTemp = Convert.ToInt32(Appointment_Time);

                if (TempAppointmentTemp == 0)
                {
                    Error = Error + "APPOINTMENT TIME CANNOT BE BLANK!" + " ";
                }

                if (TempAppointmentTemp < 0001 | TempAppointmentTemp > 2401)
                {
                    Error = Error + "APPOINTMENT TIME MUST BETWEEN THE RANGE 0900 - 2400 " + " ";
                }
            }
            catch
            {
                Error = Error + "APPOINTMENT TIME IS INVALID" + " ";
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