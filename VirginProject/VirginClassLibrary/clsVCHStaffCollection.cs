using System.Collections.Generic;
using VirginClassLibrary;
using System;

namespace VirginClassLibrary
{
    public class clsVCHStaffCollection
    {
        //private data member for the StaffList list
        List<clsVCHStaff> mStaffList = new List<clsVCHStaff>();

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

        public clsVCHStaff ThisStaff { get; set; }

        //public constructor for the class
        public clsVCHStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVCHStaff_SelectAll");
            //get the count of staff records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsVCHStaff AStaff = new clsVCHStaff();
                //read in the fields from the curent record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
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
    }
}