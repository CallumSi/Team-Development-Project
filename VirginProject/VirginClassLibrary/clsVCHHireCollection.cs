using System.Collections.Generic;
using VirginClassLibrary;
using System;

namespace VirginClassLibrary
{
    public class clsVCHHireCollection
    {
        //private data member for the car hire list
        List<clsVCHHire> mHireList = new List<clsVCHHire>();

        //private data member for ThisHire 
        clsVCHHire mThisHire = new clsVCHHire();

        //public property for HireList
        public List<clsVCHHire> HireList
        {
            get
            {
                //return the private data
                return mHireList;
            }
            set
            {
                //set the private data
                mHireList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return private data 
                return mHireList.Count;
            }
            set
            {
                //I will come back to this later
            }
        }

        //public property for ThisHire
        public clsVCHHire ThisHire
        {
            get
            {
                //return the private data
                return mThisHire;
            }
            set
            {
                //set the private data
                mThisHire = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the record count
            RecordCount = DB.Count;
            //clear the private array list
            mHireList = new List<clsVCHHire>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank hire record
                clsVCHHire AHire = new clsVCHHire();
                //read in the fields from the curent record
                AHire.HireID = Convert.ToInt32(DB.DataTable.Rows[Index]["HireID"]);
                AHire.CarID = Convert.ToInt32(DB.DataTable.Rows[Index]["CarID"]);
                AHire.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AHire.HireCollectionDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HireCollectionDate"]);
                AHire.HireReturnDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["HireReturnDate"]);
                AHire.HireLocation = Convert.ToString(DB.DataTable.Rows[Index]["HireLocation"]);
                AHire.HireStatus = Convert.ToString(DB.DataTable.Rows[Index]["HireStatus"]);
                //add the record to the private data member
                mHireList.Add(AHire);
                //point at the next record
                Index++;
            }
        }

        //constructor for the class
        public clsVCHHireCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblVCHHire_SelectAll");
            //populate the array list with the data
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new hire record to the database, based on values of ThisHire
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@CarID", mThisHire.CarID);
            DB.AddParameter("@CustomerID", mThisHire.CustomerID);
            DB.AddParameter("@HireCollectionDate", mThisHire.HireCollectionDate);
            DB.AddParameter("@HireReturnDate", mThisHire.HireReturnDate);
            DB.AddParameter("@HireLocation", mThisHire.HireLocation);
            DB.AddParameter("@HireStatus", mThisHire.HireStatus);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVCHHire_Insert");
        }

        public void Delete()
        {
            //deletes a car hire record as indicted by ThisHire
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@HireID", mThisHire.HireID);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHHire_Delete");
        }

        public void Update()
        {
            //update an existing car hire record in the database, based on values of thisHire
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@HireID", mThisHire.HireID);
            DB.AddParameter("@CarID", mThisHire.CarID);
            DB.AddParameter("@CustomerID", mThisHire.CustomerID);
            DB.AddParameter("@HireCollectionDate", mThisHire.HireCollectionDate);
            DB.AddParameter("@HireReturnDate", mThisHire.HireReturnDate);
            DB.AddParameter("@HireLocation", mThisHire.HireLocation);
            DB.AddParameter("@HireStatus", mThisHire.HireStatus);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHHire_Update");
        }

        public void ReportByHireLocation(string HireLocation)
        {
            //filter car hire records according to complete or partial Hire Location
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the hire location parameter for this stored procedure
            DB.AddParameter("@HireLocation", HireLocation);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHHire_FilterByHireLocation");
            //populate the array list wit the data table
            PopulateArray(DB);
        }
    }
}