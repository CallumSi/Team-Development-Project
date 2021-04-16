using System.Collections.Generic;
using VirginClassLibrary;
using System;

namespace VirginClassLibrary
{
    public class clsVCHCustomerCollection
    {
        //private data member for the customer list
        List<clsVCHCustomer> mCustomerList = new List<clsVCHCustomer>();

        //private data member for thisCustomer
        clsVCHCustomer mThisCustomer = new clsVCHCustomer();

        //public property for CustomerList
        //publicly exposing CustomerList priavte data
        public List<clsVCHCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for Count
        public int Count
        {
            get
            {
                //return the count property of the private list
                return mCustomerList.Count;
            }
            set
            {
                //returning to this one soon
            }
        }

        //public property for ThisCustomer
        public clsVCHCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }
    
        //constructor for the class
        public clsVCHCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVCHCustomer_SelectAll");
            //populate the array list wit the data table
            PopulateArray(DB);
            
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsVCHCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsVCHCustomer ACustomer = new clsVCHCustomer();
                //read in the fields from the curent record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.Age = Convert.ToInt32(DB.DataTable.Rows[Index]["Age"]);
                ACustomer.DriverLicenseNumber = Convert.ToString(DB.DataTable.Rows[Index]["DriverLicenseNumber"]);
                ACustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["Username"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //add a new customer record to the database, based on values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Age", mThisCustomer.Age);
            DB.AddParameter("@DriverLicenseNumber", mThisCustomer.DriverLicenseNumber);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVCHCustomer_Insert");
        }

        public void Delete()
        {
            //deletes indicated customer record according to thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHCustomer_Delete");
        }

        public void Update()
        {
            //update an existing customer record in the database, based on values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Age", mThisCustomer.Age);
            DB.AddParameter("@DriverLicenseNumber", mThisCustomer.DriverLicenseNumber);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            //execute the query and update the customer record
            DB.Execute("sproc_tblVCHCustomer_Update");
        }

        public void ReportByUsername(string Username)
        {
            //filter customer records according to complete or partial Username
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the Username parameter for this stored procedure
            DB.AddParameter("@Username", Username);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHCustomer_FilterByUsername");
            //populate the array list wit the data table
            PopulateArray(DB);
        }
    }
}