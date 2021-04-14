using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsVPOrderCollection
    {
        //private data member for the list
        List<clsVPOrder> mOrderList = new List<clsVPOrder>();
        //private data member ThisOrder
        clsVPOrder mThisOrder = new clsVPOrder();


        public List<clsVPOrder> OrderList

        {
            get
            {
                //return the private data
                return mOrderList;
            }
                set
            {
                //set the private data
                mOrderList = value;
            }

        }
        public clsVPOrder ThisOrder

        {
            get
            {
                //return the private data
                return mThisOrder;
            }
                set
            {
                //set the private data
                mThisOrder = value;
            }

        }
        public int Count

        {
            get
            {
                //return the private data
                return mOrderList.Count;
            }
                set
            {
                //we shall worry about this later
            }
        }

        //contructor for the class
        public clsVPOrderCollection()
        {
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVPOrder_SelectAll");
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
            mOrderList = new List<clsVPOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff
                clsVPOrder AOrder = new clsVPOrder();
                //read in the field from the current records
                AOrder.Order_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Order_ID"]);
                AOrder.Customer_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Customer_ID"]);
                AOrder.Delivery_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Delivery_Date"]);
                //add the record to the private data member
                mOrderList.Add(AOrder);
                //point to the next record
                Index++;
            }

        }

        public void FilterByCustomerID(Int32 Customer_ID)
        {
            //filters the records based on a full or partials first name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the FirstName parameter to the database
            DB.AddParameter("@Customer_ID", Customer_ID);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPOrder_FilterByCustomerID");
            //populate the aray list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Customer_ID", mThisOrder.Customer_ID);
            DB.AddParameter("@Delivery_Date", mThisOrder.Delivery_Date);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVPOrder_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Order_ID", mThisOrder.Order_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVPOrder_Delete");
        }

        public int Update()
        {
            //updates an existing record based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("Order_ID", mThisOrder.Order_ID);
            DB.AddParameter("@Customer_ID", mThisOrder.Customer_ID);
            DB.AddParameter("@Delivery_Date", mThisOrder.Delivery_Date);
            //execute the stored procedure
            return DB.Execute("sproc_tblVPOrder_Update");

        }
    }
}