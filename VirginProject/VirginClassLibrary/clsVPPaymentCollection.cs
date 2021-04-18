using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVPPaymentCollection
    {

        //private data member for the list 
        List<clsVPPayment> mPaymentList = new List<clsVPPayment>();
        //private data member ThisPayment 
        clsVPPayment mThisPayment = new clsVPPayment();

        //public property for the payment list 
        public List<clsVPPayment> PaymentList

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
        public clsVPPayment ThisPayment

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
        public int Count

        {
            get
            {
                //return the private data
                return mPaymentList.Count;
            }
                
                set
            {
                //we shall wory about this later 
            }


        }



        //contructor for the class
        public clsVPPaymentCollection()
        {
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVPPayment_SelectAll");
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
            //clesr the private array list 
            mPaymentList = new List<clsVPPayment>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsVPPayment APayment = new clsVPPayment();
                //read in the field from the current records
                APayment.Payment_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Payment_ID"]);
                APayment.CardNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CardNo"]);
                APayment.ExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ExpiryDate"]);
                APayment.SecurityNo = Convert.ToInt32(DB.DataTable.Rows[Index]["SecurityNo"]);
                //add the record to the private data member
                mPaymentList.Add(APayment);
                //point to the next record
                Index++;

            }

        }

        public void FilterByStaffCardNo(string CardNo)
        {
            //filters the records based on a full or partials card no
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@CardNo", CardNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPPayment_FilterByCardNo");
            //populate the aray list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
             //adds a new record to the database based on the values of mThisPayment
             //connect to the database 
             clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CardNo", mThisPayment.CardNo);
            DB.AddParameter("@ExpiryDate", mThisPayment.ExpiryDate);
            DB.AddParameter("@SecurityNo", mThisPayment.SecurityNo);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVPPayment_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisPayment
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Payment_ID", mThisPayment.Payment_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVPPayment_Delete");
        }


        public int Update()
        {
            //updates an existing record based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("Payment_ID", mThisPayment.Payment_ID);
            DB.AddParameter("@CardNo", mThisPayment.CardNo);
            DB.AddParameter("@ExpiryDate", mThisPayment.ExpiryDate);
            DB.AddParameter("@SecurityNo", mThisPayment.SecurityNo);
            //execute the stored procedure
            return DB.Execute("sproc_tblVPPayment_Update");

        }
    }
}