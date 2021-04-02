using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVHCPatientCollection
    {
        //private data member for the list
        List<clsVHCPatient> mPatientList = new List<clsVHCPatient>();
        //private data member thisHospital
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
    }
}