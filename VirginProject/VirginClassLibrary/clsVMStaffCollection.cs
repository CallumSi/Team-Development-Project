using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsVMStaffCollection
    {
        //private data member for the list
        public List<clsVMStaff> mStaffList = new List<clsVMStaff>();

        public List<clsVMStaff> StaffList
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

        //private data member ThisStaff
        clsVMStaff mThisStaff = new clsVMStaff();

        //public property for ThisStaff
        public clsVMStaff ThisStaff
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

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VMStaffFirstName", mThisStaff.VMstaffFirstName);
            DB.AddParameter("@VMStaffLastName", mThisStaff.VMstaffLastName);
            DB.AddParameter("@VMStaffEmail", mThisStaff.VMstaffEmail);
            DB.AddParameter("@VMStaffPassword", mThisStaff.VMstaffPassword);
            DB.AddParameter("@VMStaffPosition", mThisStaff.VMstaffPosition);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVMStaff_Insert");
        }

        public void Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VMStaffID", mThisStaff.VMstaffID);
            DB.AddParameter("@VMStaffFirstName", mThisStaff.VMstaffFirstName);
            DB.AddParameter("@VMStaffLastName", mThisStaff.VMstaffLastName);
            DB.AddParameter("@VMStaffEmail", mThisStaff.VMstaffEmail);
            DB.AddParameter("@VMStaffPassword", mThisStaff.VMstaffPassword);
            DB.AddParameter("@VMStaffPosition", mThisStaff.VMstaffPosition);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblVMStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@VMStaffID", mThisStaff.VMstaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblVMStaff_Delete");
        }

        public void FilterByFirstName(string VMStaffFirstName)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@VMStaffFirstName", VMStaffFirstName);
            //execute the spoc
            DB.Execute("sproc_tblVMStaff_FilterByFirstName");
            //populate the array with the found data
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var to store the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsVMStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsVMStaff AStaff = new clsVMStaff();
                //read in the fields from the current record
                AStaff.VMstaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["VMStaffID"]);
                AStaff.VMstaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["VMStaffFirstName"]);
                AStaff.VMstaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["VMStaffLastName"]);
                AStaff.VMstaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["VMStaffEmail"]);
                AStaff.VMstaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["VMStaffPassword"]);
                AStaff.VMstaffPosition = Convert.ToString(DB.DataTable.Rows[Index]["VMStaffPosition"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point to the next record
                Index++;
            }
        }
    }
}