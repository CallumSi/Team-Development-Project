using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsForumAdminCollection
    {
        //private data member for the list
        List<clsForumAdmin> mAdminList = new List<clsForumAdmin>();
        public List<clsForumAdmin> AdminList
        {
            get
            {
                //return the private data
                return mAdminList;
            }
            set
            {
                //set the private data
                mAdminList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mAdminList.Count;
            }
            set
            {

            }
        }
        public clsForumAdmin ThisAdmin { get; set; }

        //constructor for the class
        public clsForumAdminCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblForumAdmin_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank user
                clsForumAdmin AAdmin = new clsForumAdmin();
                //read in the fields from the current record
                AAdmin.AdminID = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminID"]);
                AAdmin.AdminFirstName = Convert.ToString(DB.DataTable.Rows[Index]["AdminFirstName"]);
                AAdmin.AdminLastName = Convert.ToString(DB.DataTable.Rows[Index]["AdminLastName"]);
                AAdmin.AdminEmail = Convert.ToString(DB.DataTable.Rows[Index]["AdminEmail"]);
                AAdmin.AdminPassword = Convert.ToString(DB.DataTable.Rows[Index]["AdminPassword"]);
                //add the record to the private data member
                mAdminList.Add(AAdmin);
                //point at the next record
                Index++;
            }
        }
    }
   
   
}