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

        //constructor for the class
        public clsVCHHireCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute stored procedure
            DB.Execute("sproc_tblVCHHire_SelectAll");
            //get the record count
            RecordCount = DB.Count;
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
                AHire.DriverAge = Convert.ToInt32(DB.DataTable.Rows[Index]["DriverAge"]);
                AHire.DriverLicenseNumber = Convert.ToString(DB.DataTable.Rows[Index]["DriverLicenseNumber"]);
                //add the record to the private data member
                mHireList.Add(AHire);
                //point at the next record
                Index++;
            }

            /*//create item of test data
            clsVCHHire TestItem = new clsVCHHire();
            //set the properties
            TestItem.HireID = 1;
            TestItem.CarID = 1;
            TestItem.CustomerID = 1;
            TestItem.HireCollectionDate = DateTime.Now.Date;
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(7);
            TestItem.HireLocation = "14-16 Gulliard Lane, Leicester, LE2 5RE";
            TestItem.DriverAge = 26;
            TestItem.DriverLicenseNumber = "ALIGH902245DA99S";
            //add the item to the hire list
            mHireList.Add(TestItem);
            //re-initialise the object for some new data
            TestItem = new clsVCHHire();
            //set the properties
            TestItem.HireID = 2;
            TestItem.CarID = 2;
            TestItem.CustomerID = 2;
            TestItem.HireCollectionDate = DateTime.Now.Date.AddDays(14);
            TestItem.HireReturnDate = DateTime.Now.Date.AddDays(28);
            TestItem.HireLocation = "30 Glaxon Street, Shropshire, SH7 3FG";
            TestItem.DriverAge = 42;
            TestItem.DriverLicenseNumber = "STONES895523RH00A";
            //add the item to the hire list
            mHireList.Add(TestItem);*/
        }
    }
}