using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVMCustomerCollection
    {
        //private data member for the list
        public List<clsVMCustomer> mCustomerList = new List<clsVMCustomer>();

        public List<clsVMCustomer> CustomerList
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

        //private data member thisCustomer
        clsVMCustomer mThisCustomer = new clsVMCustomer();

        //public property for ThisCustomer
        public clsVMCustomer ThisCustomer
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

        //constructor for the class
        public clsVMCustomerCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblVMCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var to store the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsVMCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsVMCustomer ACustomer = new clsVMCustomer();
                //read in the fields from the current record
                ACustomer.VMCustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["VMCustomerID"]);
                ACustomer.VMcustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["VMCustomerFirstName"]);
                ACustomer.VMcustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["VMCustomerLastname"]);
                ACustomer.VMcustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["VMCustomerEmail"]);
                ACustomer.VMcustomerUsername = Convert.ToString(DB.DataTable.Rows[Index]["VMCustomerUsername"]);
                ACustomer.VMcustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["VMCustomerPassword"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point to the next record
                Index++;
            }
        }

        //Add method
        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VMCustomerFirstName", mThisCustomer.VMcustomerFirstName);
            DB.AddParameter("@VMCustomerLastName", mThisCustomer.VMcustomerLastName);
            DB.AddParameter("@VMCustomerEmail", mThisCustomer.VMcustomerEmail);
            DB.AddParameter("@VMCustomerUsername", mThisCustomer.VMcustomerUsername);
            DB.AddParameter("@VMCustomerPassword", mThisCustomer.VMcustomerPassword);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVMCustomer_Insert");
        }

        //Update method
        public void Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VMCustomerID", mThisCustomer.VMCustomerID);
            DB.AddParameter("@VMCustomerFirstName", mThisCustomer.VMcustomerFirstName);
            DB.AddParameter("@VMCustomerLastName", mThisCustomer.VMcustomerLastName);
            DB.AddParameter("@VMCustomerEmail", mThisCustomer.VMcustomerEmail);
            DB.AddParameter("@VMCustomerUsername", mThisCustomer.VMcustomerUsername);
            DB.AddParameter("@VMCustomerPassword", mThisCustomer.VMcustomerPassword);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblVMCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@VMCustomerID", mThisCustomer.VMCustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblVMCustomer_Delete");
        }

        public void FilterByUsername(string VMCustomerUsername)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@VMCustomerUsername", VMCustomerUsername);
            //execute the spoc
            DB.Execute("sproc_tblVMCustomer_FilterByUsername");
            //populate the array with the found data
            PopulateArray(DB);
        }
    }
}