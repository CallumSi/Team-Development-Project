using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVPCustomerCollection
    {

        //private data member for the list
        List<clsVPCustomer> mCustomerList = new List<clsVPCustomer>();
        //private data member ThisCustomer
        clsVPCustomer mThisCustomer = new clsVPCustomer();

        //public property for the customer list
        public List<clsVPCustomer> CustomerList

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

        public clsVPCustomer ThisCustomer

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

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }

            set
            {
                //we shall worry about this later
            }
        }

        //contructor for the class
        public clsVPCustomerCollection()
        {
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVPCustomer_SelectAll");
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
            //clear the private array list 
            mCustomerList = new List<clsVPCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsVPCustomer ACustomer = new clsVPCustomer();
                //read in the field from the current records
                ACustomer.Customer_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Customer_ID"]);
                ACustomer.Customer_FirstName = Convert.ToString(DB.DataTable.Rows[Index]["Customer_FirstName"]);
                ACustomer.Customer_LastName = Convert.ToString(DB.DataTable.Rows[Index]["Customer_LastName"]);
                ACustomer.Customer_Street = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Street"]);
                ACustomer.Customer_Address = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Address"]);
                ACustomer.Customer_Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Postcode"]);
                ACustomer.Customer_Email = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Email"]);
                ACustomer.Customer_Telephone = Convert.ToString(DB.DataTable.Rows[Index]["Customer_Telephone"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point to the next record
                Index++;

            }

        }

        public void FilterByCustomerFirstName(string Customer_FirstName)
        {
            //filters the records based on a full or partials first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@Customer_FirstName", Customer_FirstName);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPCustomer_FilterByFirstName");
            //populate the aray list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Customer_FirstName", mThisCustomer.Customer_FirstName);
            DB.AddParameter("@Customer_LastName", mThisCustomer.Customer_LastName);
            DB.AddParameter("@Customer_Street", mThisCustomer.Customer_Street);
            DB.AddParameter("@Customer_Address", mThisCustomer.Customer_Address);
            DB.AddParameter("@Customer_Postcode", mThisCustomer.Customer_Postcode);
            DB.AddParameter("@Customer_Email", mThisCustomer.Customer_Email);
            DB.AddParameter("@Customer_Telephone", mThisCustomer.Customer_Telephone);
            DB.AddParameter("@OriginalID", mThisCustomer.OriginalID);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVPCustomer_Insert");

        }


        public void Delete()
        {
            //deletes the record pointed to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Customer_ID", mThisCustomer.Customer_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVPCustomer_Delete");
        }


        public int Update()
        {
            //updates an existing record based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Customer_ID", mThisCustomer.Customer_ID);
            DB.AddParameter("@Customer_FirstName", mThisCustomer.Customer_FirstName);
            DB.AddParameter("@Customer_LastName", mThisCustomer.Customer_LastName);
            DB.AddParameter("@Customer_Street", mThisCustomer.Customer_Street);
            DB.AddParameter("@Customer_Address", mThisCustomer.Customer_Address);
            DB.AddParameter("@Customer_Postcode",mThisCustomer.Customer_Postcode);
            DB.AddParameter("@Customer_Email", mThisCustomer.Customer_Address);
            DB.AddParameter("@Customer_Telephone", mThisCustomer.Customer_Telephone);
            //execute the stored procedure
            return DB.Execute("sproc_tblVPCustomer_Update");


        }
    }

}