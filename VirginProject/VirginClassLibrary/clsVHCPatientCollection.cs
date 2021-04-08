using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVHCPatientCollection
    {
        //private data member for the list
        List<clsVHCPatient> mPatientList = new List<clsVHCPatient>();
        //private data member thisPatient
        clsVHCPatient mThisPatient = new clsVHCPatient();

        public List<clsVHCPatient> PatientList
        {
            get
            {
                //return the private data
                return mPatientList;
            }

            set
            {
                //set the private data 
                mPatientList = value;
            }
        }

        public clsVHCPatient ThisPatient
        {
            get
            {
                //return the private data 
                return mThisPatient;
            }

            set
            {
                //set the private data 
                mThisPatient = value;

            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mPatientList.Count;
            }
            set
            {

            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisPatient
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Patient_Title", mThisPatient.Patient_Title);
            DB.AddParameter("@Patient_Firstname", mThisPatient.Patient_Firstname);
            DB.AddParameter("@Patient_Lastname", mThisPatient.Patient_Lastname);
            DB.AddParameter("@Patient_Address", mThisPatient.Patient_Address);
            DB.AddParameter("@Patient_DOB", mThisPatient.Patient_DOB);
            DB.AddParameter("@Patient_Email", mThisPatient.Patient_Email);
            DB.AddParameter("@Patient_Username", mThisPatient.Patient_Username);
            DB.AddParameter("@Patient_Password", mThisPatient.Patient_Password);
            DB.AddParameter("@Patient_Telephone", mThisPatient.Patient_Telephone);
            DB.AddParameter("@Patient_Status", mThisPatient.Patient_Status);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVHCPatient_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisPatient
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Patient_ID", mThisPatient.Patient_ID);
            DB.AddParameter("@Patient_Title", mThisPatient.Patient_Title);
            DB.AddParameter("@Patient_Firstname", mThisPatient.Patient_Firstname);
            DB.AddParameter("@Patient_Lastname", mThisPatient.Patient_Lastname);
            DB.AddParameter("@Patient_Address", mThisPatient.Patient_Address);
            DB.AddParameter("@Patient_DOB", mThisPatient.Patient_DOB);
            DB.AddParameter("@Patient_Email", mThisPatient.Patient_Email);
            DB.AddParameter("@Patient_Username", mThisPatient.Patient_Username);
            DB.AddParameter("@Patient_Password", mThisPatient.Patient_Password);
            DB.AddParameter("@Patient_Telephone", mThisPatient.Patient_Telephone);
            DB.AddParameter("@Patient_Status", mThisPatient.Patient_Status);
            //execute the stored procedure 
            DB.Execute("sproc_tblVHCPatient_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisPatient
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@Patient_ID", mThisPatient.Patient_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCPatient_Delete");
        }

        public clsVHCPatientCollection()
        {

            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure 
            DB.Execute("sproc_tblVHCPatient_SelectAll");
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
            mPatientList = new List<clsVHCPatient>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank hospital 
                clsVHCPatient APatient = new clsVHCPatient();
                //read in the fields from the current record
                APatient.Patient_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Patient_ID"]);
                APatient.Patient_Title = Convert.ToString(DB.DataTable.Rows[Index]["Patient_Title"]);
                APatient.Patient_Firstname = Convert.ToString(DB.DataTable.Rows[Index]["Patient_Firstname"]);
                APatient.Patient_Lastname = Convert.ToString(DB.DataTable.Rows[Index]["Patient_Lastname"]);
                APatient.Patient_Address = Convert.ToString(DB.DataTable.Rows[Index]["Patient_Address"]);
                APatient.Patient_DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["Patient_DOB"]);
                APatient.Patient_Email = Convert.ToString(DB.DataTable.Rows[Index]["Patient_Email"]);
                APatient.Patient_Username = Convert.ToString(DB.DataTable.Rows[Index]["Patient_Username"]);
                APatient.Patient_Password = Convert.ToString(DB.DataTable.Rows[Index]["Patient_Password"]);
                APatient.Patient_Telephone = Convert.ToString(DB.DataTable.Rows[Index]["Patient_Telephone"]);
                APatient.Patient_Status = Convert.ToBoolean(DB.DataTable.Rows[Index]["Patient_Status"]);
                //add the record to the private data member 
                mPatientList.Add(APatient);
                //point at the next record
                Index++;
            }
        }

        public void ReportByPatient(DateTime Patient_DOB)
        {
            //filters the records based on full or partial make
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the patient DOB parameter to the database 
            DB.AddParameter("@Patient_DOB", Patient_DOB);
            //execute the stored procedure 
            DB.Execute("sproc_tblVHCPatient_FilterByPatientDOB");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
    }
}