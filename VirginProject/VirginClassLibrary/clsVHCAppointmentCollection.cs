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
            DB.AddParameter("@Hospital_ID", mThisAppointment.Hospital_ID);
            DB.AddParameter("@Patient_ID", mThisAppointment.Patient_ID);
            DB.AddParameter("@Staff_ID", mThisAppointment.Staff_ID);
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
            DB.AddParameter("@Hospital_ID", mThisAppointment.Hospital_ID);
            DB.AddParameter("@Patient_ID", mThisAppointment.Patient_ID);
            DB.AddParameter("@Staff_ID", mThisAppointment.Staff_ID);

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
                AnAppointment.Appointment_Time = Convert.ToString(DB.DataTable.Rows[Index]["Appointment_Time"]);
                AnAppointment.Appointment_Description= Convert.ToString(DB.DataTable.Rows[Index]["Appointment_Description"]);
                AnAppointment.Hospital_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Hospital_ID"]);
                AnAppointment.Patient_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Patient_ID"]);
                AnAppointment.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
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
    }
}