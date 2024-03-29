﻿using System.Collections.Generic;
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
          

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblForumAdmin_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

         
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
            DB.AddParameter("@OriginalID", mThisAdmin.OriginalID);
            //DB.AddParameter("@AdminPassword", mThisAdmin.AdminPassword);
            //DB.AddParameter("@AdminUserName", mThisAdmin.AdminUserName);
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

        public void Update()
        {
            //update an existing record based on the values of thisUser
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procdure 
            DB.AddParameter("@AdminID", mThisAdmin.AdminID);
            DB.AddParameter("@AdminFirstName", mThisAdmin.AdminFirstName);
            DB.AddParameter("@AdminLastName", mThisAdmin.AdminLastName);
            DB.AddParameter("@AdminEmail", mThisAdmin.AdminEmail);
            //DB.AddParameter("@AdminPassword", mThisAdmin.AdminPassword);
            //DB.AddParameter("@AdminUserName", mThisAdmin.AdminUserName);
            //execute the stored procedure
            DB.Execute("sproc_tblForumAdmin_Update");
        }
        public void ReportByAdminFirstName(string AdminFirstName)
        {
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //sent the Userusername parameter to the database
            DB.AddParameter("@AdminFirstName", AdminFirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblForumAdmin_FilterbyAdminFirstName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {

            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count record
            RecordCount = DB.Count;
            //clear the private array list
            mAdminList = new List<clsForumAdmin>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Admin
                clsForumAdmin AnAdmin = new clsForumAdmin();
                //read in the fields from the current record
                AnAdmin.AdminID = Convert.ToInt32(DB.DataTable.Rows[Index]["AdminID"]);
                AnAdmin.AdminFirstName = Convert.ToString(DB.DataTable.Rows[Index]["AdminFirstName"]);
                AnAdmin.AdminLastName = Convert.ToString(DB.DataTable.Rows[Index]["AdminLastName"]);
                AnAdmin.AdminEmail = Convert.ToString(DB.DataTable.Rows[Index]["AdminEmail"]);
                //AnAdmin.AdminPassword = Convert.ToString(DB.DataTable.Rows[Index]["AdminPassword"]);
                //AnAdmin.AdminUserName = Convert.ToString(DB.DataTable.Rows[Index]["AdminUserName"]);
                mAdminList.Add(AnAdmin);
                //point at the next record
                Index++;
            }
        }

    }

}