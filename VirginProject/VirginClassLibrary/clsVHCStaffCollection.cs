using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    ///This class uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019

    public class clsVHCStaffCollection
    {
        //private data member for the list 
        List<clsVHCStaff> mStaffList = new List<clsVHCStaff>();
        //private data member thisStaff
        clsVHCStaff mThisStaff = new clsVHCStaff();


        public List<clsVHCStaff> StaffList 
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

        public clsVHCStaff ThisStaff
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
                //return the count of the list
                return mStaffList.Count;
            }

            set 
            { 

            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Staff_Title", mThisStaff.Staff_Title);
            DB.AddParameter("@Staff_Firstname", mThisStaff.Staff_Firstname);
            DB.AddParameter("@Staff_Lastname", mThisStaff.Staff_Lastname);
            DB.AddParameter("@Staff_Email", mThisStaff.Staff_Email);
            DB.AddParameter("@Staff_Username", mThisStaff.Staff_Username);
            DB.AddParameter("@Staff_Password", mThisStaff.Staff_Password);
            DB.AddParameter("@Staff_Role", mThisStaff.Staff_Role);
            DB.AddParameter("@Staff_Status", mThisStaff.Staff_Status);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVHCStaff_Insert");

        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Staff_ID", mThisStaff.Staff_ID);
            DB.AddParameter("@Staff_Title", mThisStaff.Staff_Title);
            DB.AddParameter("@Staff_Firstname", mThisStaff.Staff_Firstname);
            DB.AddParameter("@Staff_Lastname", mThisStaff.Staff_Lastname);
            DB.AddParameter("@Staff_Email", mThisStaff.Staff_Email);
            DB.AddParameter("@Staff_Username", mThisStaff.Staff_Username);
            DB.AddParameter("@Staff_Password", mThisStaff.Staff_Password);
            DB.AddParameter("@Staff_Role", mThisStaff.Staff_Role);
            DB.AddParameter("@Staff_Status", mThisStaff.Staff_Status);
            //execute the stored procedure 
            DB.Execute("sproc_tblVHCStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@Staff_ID", mThisStaff.Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVHCStaff_Delete");
        }


        public clsVHCStaffCollection()
        {
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure 
            DB.Execute("sproc_tblVHCStaff_SelectAll");
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
            mStaffList = new List<clsVHCStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank hospital 
                clsVHCStaff AStaff = new clsVHCStaff();
                //read in the fields from the current record
                AStaff.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                AStaff.Staff_Title = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Title"]);
                AStaff.Staff_Firstname = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Firstname"]);
                AStaff.Staff_Lastname = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Lastname"]);
                AStaff.Staff_Email = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Email"]);
                AStaff.Staff_Username = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Username"]);
                AStaff.Staff_Password = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Password"]);
                AStaff.Staff_Role = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Role"]);
                AStaff.Staff_Status = Convert.ToBoolean(DB.DataTable.Rows[Index]["Staff_Status"]);
                //add the record to the private data member 
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

        public void ReportByStaff(string Staff_Firstname)
        {
            //filters the records based on full or partial make
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the staff firstname parameter to the database 
            DB.AddParameter("@Staff_Firstname", Staff_Firstname);
            //execute the stored procedure 
            DB.Execute("sproc_tblVHCStaff_FilterByStaff_Firstname");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
    }
}