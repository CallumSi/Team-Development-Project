using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    ///This class uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019

    public class clsVHCHospitalCollection
    {
        //private data member for the list
        List<clsVHCHospital> mHospitalList = new List<clsVHCHospital>();
        //private data member thisHospital
        clsVHCHospital mThisHospital = new clsVHCHospital();

        //public property for the hospital list 
        public List<clsVHCHospital> HospitalList
        {
            get
            {
                //return the private data
                return mHospitalList;
            }

            set
            {
                //set the private data 
                mHospitalList = value;
            }
        }

        //private property for ThisHospital
        public clsVHCHospital ThisHospital
        {
            get
            {
                //return the private data 
                return mThisHospital;
            }

            set
            {
                //set the private data 
                mThisHospital = value;

            }
        }

        public int Count 
        {
            get
            {
                //return the count of the list
                return mHospitalList.Count;
            }
            set
            {
                
            }
        }

        //Add Method
        public int Add()
        {
            //adds a new record to the database based on the values of mThisHospital
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Hospital_Name", mThisHospital.Hospital_Name);
            DB.AddParameter("@Hospital_Place", mThisHospital.Hospital_Place);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVHCHospital_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisHospital
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Hospital_ID", mThisHospital.Hospital_ID);
            DB.AddParameter("@Hospital_Name", mThisHospital.Hospital_Name);
            DB.AddParameter("@Hospital_Place", mThisHospital.Hospital_Place);
            //execute the stored procedure 
            DB.Execute("sproc_tblVHCHospital_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisHospital
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@Hospital_ID", mThisHospital.Hospital_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCHospital_Delete");
        }

        public clsVHCHospitalCollection()
        {

            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure 
            DB.Execute("sproc_tblVHCHospital_SelectAll");
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
            mHospitalList = new List<clsVHCHospital>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank hospital 
                clsVHCHospital AHospital = new clsVHCHospital();
                //read in the fields from the current record
                AHospital.Hospital_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Hospital_ID"]);
                AHospital.Hospital_Name = Convert.ToString(DB.DataTable.Rows[Index]["Hospital_Name"]);
                AHospital.Hospital_Place = Convert.ToString(DB.DataTable.Rows[Index]["Hospital_Place"]);
                //add the record to the private data member 
                mHospitalList.Add(AHospital);
                //point at the next record
                Index++;
            }
        }

        public void ReportByHospital(string Hospital_Place)
        {
            //filters the records based on full or partial make
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the hospital place parameter to the database 
            DB.AddParameter("@Hospital_Place", Hospital_Place);
            //execute the stored procedure 
            DB.Execute("sproc_tblVHCHospital_FilterByHospital");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
    }
}