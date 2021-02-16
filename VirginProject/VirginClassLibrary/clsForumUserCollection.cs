using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsForumUserCollection
    {
        //private data member for the list
        List<clsForumUser> mUserList = new List<clsForumUser>();
        public List<clsForumUser> UserList
        {
            get
            {
                //return the private data
                return mUserList;
            }
            set
            {
                //set the private data
                mUserList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mUserList.Count;
            }
            set
            {

            }
        }
        public clsForumUser ThisUser { get; set; }

        //constructor for the class
        public clsForumUserCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblUser_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank user
                clsForumUser AUser = new clsForumUser();
                //read in the fields from the current record
                AUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserID"]);
                AUser.UserFirstName = Convert.ToString(DB.DataTable.Rows[Index]["UserFirstName"]);
                AUser.UserLastName = Convert.ToString(DB.DataTable.Rows[Index]["UserLastName"]);
                AUser.UserPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["UserPhoneNumber"]);
                AUser.UserEmail = Convert.ToString(DB.DataTable.Rows[Index]["UserEmailAddress"]);
                AUser.UserPassword = Convert.ToString(DB.DataTable.Rows[Index]["UserPassword"]);
                //add the record to the private data member
                mUserList.Add(AUser);
                //point at the next record
                Index++;
            }
        }


    }
}