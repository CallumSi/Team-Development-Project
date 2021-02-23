using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsForumAdminCollection
    {
        //private data member for the list
        List<clsForumAdmin> mAdminList = new List<clsForumAdmin>();
        //private data menmber thisAdmin
        clsForumAdmin mThisAdmin = new clsForumAdmin();
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
        public clsForumAdmin ThisAdmin
        {
            get
            {
                //return the private data
                return mThisAdmin;
            }
            set
            {
                //set the private data
                mThisAdmin = value;
            }
        }
   

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
                AAdmin.AdminUserName = Convert.ToString(DB.DataTable.Rows[Index]["AdminUserName"]);
                //add the record to the private data member
                mAdminList.Add(AAdmin);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //add a new record to the database based on the values of the mthisAdmin
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaeters for the stored procedure
            DB.AddParameter("@AdminFirstName", mThisAdmin.AdminFirstName);
            DB.AddParameter("@AdminLastName", mThisAdmin.AdminLastName);
            DB.AddParameter("@AdminEmail", mThisAdmin.AdminEmail);
            DB.AddParameter("@AdminPassword", mThisAdmin.AdminPassword);
            DB.AddParameter("@AdminUserName", mThisAdmin.AdminUserName);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblForumAdmin_Insert");
        }

        public void Delete()
        {
            //delete the record pointed to by thisAdmin
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AdminID", mThisAdmin.AdminID);
            //execute the stored procedure 
            DB.Execute("sproc_tblForumAdmin_Delete");
        }
    }
   
   
}