using System.Collections.Generic;
using VirginClassLibrary;
using System;

namespace VirginClassLibrary
{
    public class clsVCHStaffCollection
    {
        //private data member for the StaffList list
        List<clsVCHStaff> mStaffList = new List<clsVCHStaff>();
        //private data member for thisStaff
        clsVCHStaff mThisStaff = new clsVCHStaff();

        //public data member for the StaffList list
        public List<clsVCHStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }

            set
            {
                //set the private data 
                mStaffList = value;
            }
        }

        //public data member for the ThisStaff list
        public clsVCHStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }

            set
            {
                //set the private data 
                mThisStaff = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count property of the private list
                return mStaffList.Count;
            }
            set
            {
                //returning to this one soon
            }
        }

        //public constructor for the class
        public clsVCHStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVCHStaff_SelectAll");
            //populate the array list wit the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsVCHStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsVCHStaff AStaff = new clsVCHStaff();
                //read in the fields from the curent record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                //AStaff.AdminID = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminID"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AStaff.StaffPostCode = Convert.ToString(DB.DataTable.Rows[Index]["StaffPostCode"]);
                AStaff.StaffUsername = Convert.ToString(DB.DataTable.Rows[Index]["StaffUsername"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                AStaff.StaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneNumber"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //add a new staff record to the database, based on values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@AdminID", mThisStaff.AdminID);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffPostCode", mThisStaff.StaffPostCode);
            DB.AddParameter("@StaffUsername", mThisStaff.StaffUsername);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@StaffPhoneNumber", mThisStaff.StaffPhoneNumber);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVCHStaff_Insert");
        }

        public void Delete()
        {
            //deletes a staff record as indicted by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHStaff_Delete");
        }

        public void Update()
        {
            //update an existing staff record in the database, based on values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //DB.AddParameter("@AdminID", mThisStaff.AdminID);
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffPostCode", mThisStaff.StaffPostCode);
            DB.AddParameter("@StaffUsername", mThisStaff.StaffUsername);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@StaffPhoneNumber", mThisStaff.StaffPhoneNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHStaff_Update");
        }

        public void ReportByStaffUsername(string StaffUsername)
        {
            //filter staff records according to complete or partial Username
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the Username parameter for this stored procedure
            DB.AddParameter("@StaffUsername", StaffUsername);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHStaff_FilterByUsername");
            //populate the array list wit the data table
            PopulateArray(DB);
        }
    }
}