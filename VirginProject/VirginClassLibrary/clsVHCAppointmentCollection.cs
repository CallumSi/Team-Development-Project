using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVHCAppointmentCollection
    {
        //private data member for the list
        List<clsVHCAppointment> mAppointmentList = new List<clsVHCAppointment>();
        //private data member thisAppointment
        clsVHCAppointment mThisAppointment = new clsVHCAppointment();
        public List<clsVHCAppointment> AppointmentList 
        {
            get
            {
                //return the private data
                return mAppointmentList;
            }


            set
            {
                //set the private data 
                mAppointmentList = value;
            }
        }
        public clsVHCAppointment ThisAppointment 
        {
            get
            {
                //return the private data
                return mThisAppointment;
            }

            set
            {
                //set the private data 
                mThisAppointment = value;
            }
        }

        public int Count 
        {
            get
            {
                //return the count of the list
                return mAppointmentList.Count;
            }
            
            set
            {

            }

        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisAppointment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Appointment_Date", mThisAppointment.Appointment_Date);
            DB.AddParameter("@Appointment_Time", mThisAppointment.Appointment_Time);
            DB.AddParameter("@Appointment_Description", mThisAppointment.Appointment_Description);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVHCAppointment_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisAppointment
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Appointment_ID", mThisAppointment.Appointment_ID);
            DB.AddParameter("@Appointment_Date", mThisAppointment.Appointment_Date);
            DB.AddParameter("@Appointment_Time", mThisAppointment.Appointment_Time);
            DB.AddParameter("@Appointment_Description", mThisAppointment.Appointment_Description);
            //execute the stored procedure 
            DB.Execute("sproc_tblVHCAppointment_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisAppointment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@Appointment_ID", mThisAppointment.Appointment_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCAppointment_Delete");
        }

        public clsVHCAppointmentCollection()
        {

            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure 
            DB.Execute("sproc_tblVHCAppointment_SelectAll");
            //populate the array list with the data table 
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count 
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list 
            mAppointmentList = new List<clsVHCAppointment>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank hospital 
                clsVHCAppointment AnAppointment = new clsVHCAppointment();
                //read in the fields from the current record
                AnAppointment.Appointment_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Appointment_ID"]);
                AnAppointment.Appointment_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Appointment_Date"]);
                AnAppointment.Appointment_Time = Convert.ToInt32(DB.DataTable.Rows[Index]["Appointment_Time"]);
                AnAppointment.Appointment_Description= Convert.ToString(DB.DataTable.Rows[Index]["Appointment_Description"]);
                //add the record to the private data member 
                mAppointmentList.Add(AnAppointment);
                //point at the next record
                Index++;
            }
        }


        public void ReportByAppointment(DateTime Appointment_Date)
        {
            //filters the records based on full or partial make
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the appointment date parameter to the database 
            DB.AddParameter("@Appointment_Date", Appointment_Date);
            //execute the stored procedure 
            DB.Execute("sproc_tblVHCAppointment_FilterByAppointment_Date");
            //populate the array list with the data table 
            PopulateArray(DB);
        }

        //private data member to store he booking date
        private DateTime mApptDate;
        //data connection with class level scope
        clsDataConnection DB = new clsDataConnection();

        //constructor for the class
        public clsVHCAppointmentCollection(DateTime ADate)
        {
            //get appointments for this date
            FilterByDate(ADate);
            //remember the date used
            mApptDate = ADate;
        }

        //use dto generate the list of appointments
        private List<clsVHCAppointment> GetSchedule()
        {
            //list of appts for this function
            List<clsVHCAppointment> mAvailableAppts = new List<clsVHCAppointment>();
            //loop through the times of day 9 - 16
            for (Int32 SomeTime = 9; SomeTime < 17; SomeTime++)
            {
                //check to see if this time has an existing booking
                Int32 Index = HasBooking(SomeTime);
                //if the returned entry is <0 then it does not
                if (Index < 0)
                {
                    //create a new blank slot
                    clsVHCAppointment NewAppt = new clsVHCAppointment();
                    //record the primary key as -time
                    NewAppt.Appointment_ID = -SomeTime;
                    //store the date using the private data member
                    NewAppt.Appointment_Date = mApptDate;
                    //recod the time
                    NewAppt.Appointment_Time = SomeTime;
                    //set the reason to blank
                    NewAppt.Appointment_Description = "";
                    //add it to the list
                    mAvailableAppts.Add(NewAppt);
                }
                else //if the time has a booking
                {
                    //create a new blank appt
                    clsVHCAppointment NewAppt = new clsVHCAppointment();
                    //record the appt no from the db
                    NewAppt.Appointment_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Appointment_ID"]);
                    //redord the appt date
                    NewAppt.Appointment_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Appointment_Date"]);
                    //record the time
                    NewAppt.Appointment_Time = Convert.ToInt32(DB.DataTable.Rows[Index]["Appointment_Time"]);
                    //record the reason
                    NewAppt.Appointment_Description = Convert.ToString(DB.DataTable.Rows[Index]["Appointment_Description"]);
                    //add it to the list
                    mAvailableAppts.Add(NewAppt);
                }
            }
            //return the list to anybody who wants to know
            return mAvailableAppts;
        }

        private Int32 HasBooking(Int32 SomeTime)
        //checks to see if a time for the recorded date has a booking
        {
            //index for the loop
            Int32 Index = 0;
            //Boolean var to indicate if an entry is found
            Boolean Found = false;
            //loop through any records for this dat from th edatabase
            while (Index < DB.Count & Found == false)
            {
                //if a record is found
                if (SomeTime == Convert.ToInt32(DB.DataTable.Rows[Index]["Appointment_Time"]))
                {
                    //set found to true which will make the loop end
                    Found = true;
                }
                else
                {
                    //otherwise keep on searching to the end
                    Index++;
                }
            }
            if (Found) //if a record is found for this time
            {
                return Index;//return the index of the entry 0 or above
            }
            else
            {
                return -1;//return -1 indicating it wasn't found
            }
        }

        private void FilterByDate(DateTime Appointment_Date)
        //filters the data in the table based on the data in question
        {
            //reinitialise the data connection
            DB = new clsDataConnection();
            //add parameter for the date
            DB.AddParameter("@Appointment_Date", Appointment_Date);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCAppointment_FilterByAppointment_Date");
            //get the appt schedule for this date
            mAppointmentList = GetSchedule();
        }

        public void AddBooking(Int32 Appointment_Time, string Appointment_Description)
        //adds a new appt to the table
        {
            //reinitialise the data connection
            DB = new clsDataConnection();
            //send the procedure the parameters
            DB.AddParameter("@Appointment_Date", mApptDate);
            DB.AddParameter("@Appointment_Time", Appointment_Time);
            DB.AddParameter("@Appointment_Description", Appointment_Description);
            //add the new record
            DB.Execute("sproc_tblVHCAppointment_InsertBooking");
        }
    }
}