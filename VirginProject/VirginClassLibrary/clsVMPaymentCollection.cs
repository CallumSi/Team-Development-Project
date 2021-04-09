using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVMPaymentCollection
    {
        //private data member for the list
        public List<clsVMPayment> mPaymentList = new List<clsVMPayment>();

        public List<clsVMPayment> PaymentList
        {
            get
            {
                //return the private data
                return mPaymentList;
            }
            set
            {
                //set the private data
                mPaymentList = value;
            }
        }

        //private data member ThisPayment
        clsVMPayment mThisPayment = new clsVMPayment();

        //public property for ThisCustomer
        public clsVMPayment ThisPayment
        {
            get
            {
                //return the private data
                return mThisPayment;
            }
            set
            {
                //set the private data
                mThisPayment = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mPaymentList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsVMPaymentCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblVMPayment_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VMPaymentStatus", mThisPayment.VMPaymentStatus);
            DB.AddParameter("@VMPaymentType", mThisPayment.VMPaymentType);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVMPayment_Insert");
        }

        //Update method
        public void Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VMPaymentID", mThisPayment.VMPaymentID);
            DB.AddParameter("@VMPaymentStatus", mThisPayment.VMPaymentStatus);
            DB.AddParameter("@VMPaymentType", mThisPayment.VMPaymentType);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblVMPayment_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@VMPaymentID", mThisPayment.VMPaymentID);
            //execute the stored procedure
            DB.Execute("sproc_tblVMPayment_Delete");
        }

        public void FilterByPaymentType(string VMPaymentType)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@VMPaymentType", VMPaymentType);
            //execute the spoc
            DB.Execute("sproc_tblVMPayment_FilterByPaymentType");
            //populate the array with the found data
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
            mPaymentList = new List<clsVMPayment>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsVMPayment APayment = new clsVMPayment();
                //read in the fields from the current record
                APayment.VMPaymentID = Convert.ToInt32(DB.DataTable.Rows[Index]["VMPaymentID"]);
                APayment.VMPaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["VMPaymentStatus"]);
                APayment.VMPaymentType = Convert.ToString(DB.DataTable.Rows[Index]["VMPaymentType"]);
                //add the record to the private data member
                mPaymentList.Add(APayment);
                //point to the next record
                Index++;
            }
        }
    }
}