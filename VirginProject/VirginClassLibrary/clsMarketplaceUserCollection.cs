using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    class clsMarketplaceUserCollection
    {

        //declare private variables for use list
        List<clsMarketplaceUser> mUserList = new List<clsMarketplaceUser>();
        //declarte private variables for a specific User
        clsMarketplaceUser mThisUser = new clsMarketplaceUser();

        //constructor
        public clsMarketplaceUserCollection()
        {
            //declare data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblUser_SelectAll");
            //populate the array with the data
            PopulateArray(DB);

        }





        //get set for User list
        public List<clsMarketplaceUser> UserList
        {

            get
            {
                //return private data
                return mUserList;
            }
            set
            {
                //set the private data
                mUserList = value;
            }
        }

        // count property to return count of list
        public int Count
        {
            get
            {
                return mUserList.Count;
            }
        }

        //public property for single user
        public clsMarketplaceUser ThisUser
        {
            get
            {
                //return the private data
                return mThisUser;
            }
            set
            {
                //set private data
                mThisUser = value;
            }
        }

        public int AddUser()
        {

            //used to add a new record into the database
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@Admin", mThisUser.Admin);
            DB.AddParameter("@DeliveryAdressLineOne", mThisUser.DeliveryAdressLineOne);
            DB.AddParameter("@DeliveryAdressLineTwo", mThisUser.DeliveryAdressLineTwo);
            DB.AddParameter("@PostCode", mThisUser.PostCode);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@Rating", mThisUser.Rating);
            DB.AddParameter("@UserID", mThisUser.UserID);
            //execute the insert sproc
            return DB.Execute("sproc_tblUser_Insert");

        }
        public void DeleteUser()
        {
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sproc
            DB.AddParameter("@UserID", mThisUser.UserID);
            //execute the stored procedure
            DB.Execute("sproc_tblUser_Delete");


        }
        public void UpdateUser()
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@Admin", mThisUser.Admin);
            DB.AddParameter("@DeliveryAdressLineOne", mThisUser.DeliveryAdressLineOne);
            DB.AddParameter("@DeliveryAdressLineTwo", mThisUser.DeliveryAdressLineTwo);
            DB.AddParameter("@PostCode", mThisUser.PostCode);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@Password", mThisUser.Password);
            DB.AddParameter("@Rating", mThisUser.Rating);
            DB.AddParameter("@UserID", mThisUser.UserID);
            //execute the spoc
            DB.Execute("sproc_tblUser_Update");


        }

        public void FilterByEmail(string Email)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@Email", mThisUser.Email);
            //execute the spoc
            DB.Execute("sproc_tblUser_FilterByEmail");
            //populate the array with the found data
            PopulateArray(DB);

        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates array list based on database in paramater
            //index vairables
            Int32 Index = 0;
            //vare to store the record count
            Int32 RecordCount;
            //get the record count
            RecordCount = DB.Count;
            //clear the list
            mUserList = new List<clsMarketplaceUser>();
            //loop through all the records
            while (Index < RecordCount)
            {
                //create a blank record
                clsMarketplaceUser AnUser = new clsMarketplaceUser();
                //read the data and add the record
                AnUser.Admin = Convert.ToBoolean(DB.DataTable.Rows[0]["Admin"]);
                AnUser.DeliveryAdressLineOne = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAdressLineOne"]);
                AnUser.DeliveryAdressLineTwo = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAdressLineTwo"]);
                AnUser.PostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                AnUser.Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                AnUser.Rating = Convert.ToInt32(DB.DataTable.Rows[0]["Rating"]);
                AnUser.UserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                AnUser.Password = Convert.ToString(DB.DataTable.Rows[0]["Password"]);

                //add the record t
                mUserList.Add(AnUser);
                //GO TO NEXT RECORD
                Index++;
            }

        }

    }
}
