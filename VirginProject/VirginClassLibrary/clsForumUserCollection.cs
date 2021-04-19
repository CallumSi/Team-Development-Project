using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsForumUserCollection
    {
        //private data member for the list
        List<clsForumUser> mUserList = new List<clsForumUser>();
        //private data menmber thisuser
        clsForumUser mThisUser = new clsForumUser();
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

        public clsForumUser ThisUser
        {
            get
            {
                return mThisUser;
            }
            set
            {
                mThisUser = value;
            }
        }


        //constructor for the user collection class
        public clsForumUserCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblForumUser_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //add a new record to the database based on the values of the mthisUser
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramaeters for the stored procedure
            DB.AddParameter("@UserFirstName", mThisUser.UserFirstName);
            DB.AddParameter("@UserLastName", mThisUser.UserLastName);
            DB.AddParameter("@UserEmailAddress", mThisUser.UserEmail);
            //DB.AddParameter("@UserPassword", mThisUser.UserPassword);
            DB.AddParameter("@UserPhoneNumber", mThisUser.UserPhoneNumber);
            DB.AddParameter("@OriginalID", mThisUser.OriginalID);
            //DB.AddParameter("@Userusername", mThisUser.Userusername);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblForumUser_Insert");

        }
        public void Delete()
        {
            //delete the record pointed to by thisUser
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserID", mThisUser.UserID);
            //execute the stored procedure 
            DB.Execute("sproc_tblForumUser_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisUser
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procdure 
            DB.AddParameter("@UserId", mThisUser.UserID);
            DB.AddParameter("@UserFirstName", mThisUser.UserFirstName);
            DB.AddParameter("@UserLastName", mThisUser.UserLastName);
            DB.AddParameter("@UserEmailAddress", mThisUser.UserEmail);
            //DB.AddParameter("@UserPassword", mThisUser.UserPassword);
            DB.AddParameter("@UserPhoneNumber", mThisUser.UserPhoneNumber);
            //DB.AddParameter("@Userusername", mThisUser.Userusername);
            //execute the stored procedure
            DB.Execute("sproc_tblForumUser_Update");

        }

        public void ReportByUserFirstName(string UserFirstName)
        {
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //sent the Userusername parameter to the database
            DB.AddParameter("@UserFirstName", UserFirstName);
            //execute the stored procedure
            DB.Execute("sproc_tblForumUser_FilterbyUserFirstName");
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
            mUserList = new List<clsForumUser>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank User
                clsForumUser AnUser = new clsForumUser();
                //read in the fields from the current record
                AnUser.UserID = Convert.ToInt32(DB.DataTable.Rows[Index]["UserId"]);
                AnUser.UserFirstName = Convert.ToString(DB.DataTable.Rows[Index]["UserFirstName"]);
                AnUser.UserLastName = Convert.ToString(DB.DataTable.Rows[Index]["UserLastName"]);
                AnUser.UserEmail = Convert.ToString(DB.DataTable.Rows[Index]["UserEmailAddress"]);
                //AnUser.UserPassword = Convert.ToString(DB.DataTable.Rows[Index]["UserPassword"]);
                AnUser.UserPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["UserPhoneNumber"]);
                //AnUser.Userusername = Convert.ToString(DB.DataTable.Rows[Index]["Userusername"]);
                mUserList.Add(AnUser);
                //point at the next record
                Index++;
            }
        }
    }
}