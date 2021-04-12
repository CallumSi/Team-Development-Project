using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsVPStaffCollection
    {

        //private data member for the list
       List<clsVPStaff> mStaffList = new List<clsVPStaff>();
        //private data member ThisStaff
        clsVPStaff mThisStaff = new clsVPStaff();
        
        //public property for the staff list
        public List<clsVPStaff> StaffList
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
        public clsVPStaff ThisStaff

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


        //contructor for the class
         public clsVPStaffCollection()
        {
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVPStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table
            //var to store the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of the records
            RecordCount = DB.Count;
            //clesr the private array list 
            mStaffList = new List<clsVPStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsVPStaff AStaff = new clsVPStaff();
                //read in the field from the current records
                AStaff.Staff_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_ID"]);
                AStaff.Staff_FirstName = Convert.ToString(DB.DataTable.Rows[Index]["Staff_FirstName"]);
                AStaff.Staff_LastName = Convert.ToString(DB.DataTable.Rows[Index]["Staff_LastName"]);
                AStaff.Staff_Street = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Street"]);
                AStaff.Staff_Address = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Address"]);
                AStaff.Staff_Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Postcode"]);
                AStaff.Staff_Email = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Email"]);
                AStaff.Staff_Telephone = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Telephone"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point to the next record
                Index++;

            }

        }

        public void FilterByStaffFirstName (string Staff_FirstName)
        {
            //filters the records based on a full or partials first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@Staff_FirstName", Staff_FirstName);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPStaff_FilterByFirstName");
            //populate the aray list with the data table
            PopulateArray(DB);
        }



        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Staff_FirstName", mThisStaff.Staff_FirstName);
            DB.AddParameter("@Staff_LastName", mThisStaff.Staff_LastName);
            DB.AddParameter("@Staff_Street", mThisStaff.Staff_Street);
            DB.AddParameter("@Staff_Address", mThisStaff.Staff_Address);
            DB.AddParameter("@Staff_Postcode", mThisStaff.Staff_Postcode);
            DB.AddParameter("@Staff_Email", mThisStaff.Staff_Email);
            DB.AddParameter("@Staff_Telephone", mThisStaff.Staff_Telephone);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVPStaff_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Staff_ID", mThisStaff.Staff_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVPStaff_Delete");
        }

        public int Update()
        {
            //updates an existing record based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("Staff_ID", mThisStaff.Staff_ID);
            DB.AddParameter("@Staff_FirstName", mThisStaff.Staff_FirstName);
            DB.AddParameter("@Staff_LastName", mThisStaff.Staff_LastName);
            DB.AddParameter("@Staff_Street", mThisStaff.Staff_Street);
            DB.AddParameter("@Staff_Address", mThisStaff.Staff_Address);
            DB.AddParameter("@Staff_Postcode", mThisStaff.Staff_Postcode);
            DB.AddParameter("@Staff_Email", mThisStaff.Staff_Email);
            DB.AddParameter("@Staff_Telephone", mThisStaff.Staff_Telephone);
            //execute the stored procedure
            return DB.Execute("sproc_tblVPStaff_Update");

        }

    }
}