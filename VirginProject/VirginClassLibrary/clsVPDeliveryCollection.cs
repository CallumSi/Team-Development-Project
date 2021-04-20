using System;
using System.Collections.Generic;



namespace VirginClassLibrary
{
    public class clsVPDeliveryCollection
    {
        //private data member for the list
        List<clsVPDelivery> mDeliveryList = new List<clsVPDelivery>();
        //private data member ThisDelivery
        clsVPDelivery mThisDelivery = new clsVPDelivery();

        //public property for the delivery list 
        public List<clsVPDelivery> DeliveryList

        {
            get
            {
                //return the private data 
                return mDeliveryList;
            }

            set
            {
                //set the private data 
                mDeliveryList = value;
            }

        }
        public clsVPDelivery ThisDelivery

        {
            get
            {
                //return the private data
                return mThisDelivery;
            }


            set
            {
                //set the private data
                mThisDelivery = value;
            }


        }
        public int Count

        {

            get
            {
                //return the private data 
                return mDeliveryList.Count;
            }

            set
            {
                //we shall worry about this later
            }

        }


        //contructor for the class
        public clsVPDeliveryCollection()
        {
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVPDelivery_SelectAll");
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
            mDeliveryList = new List<clsVPDelivery>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsVPDelivery ADelivery = new clsVPDelivery();
                //read in the field from the current records
                ADelivery.Delivery_ID = Convert.ToInt32(DB.DataTable.Rows[Index]["Delivery_ID"]);
                ADelivery.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                ADelivery.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ADelivery.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ADelivery.House_No = Convert.ToInt32(DB.DataTable.Rows[Index]["House_No"]);
                ADelivery.Delivery_Address = Convert.ToString(DB.DataTable.Rows[Index]["Delivery_Address"]);
                ADelivery.Delivery_Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Delivery_Postcode"]);
                ADelivery.Delivery_Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Delivery_Date"]);
                //add the record to the private data member
                mDeliveryList.Add(ADelivery);
                //point to the next record
                Index++;
            }
        }

            public void FilterByDeliveryDate(DateTime Delivery_Date)
            {
                //filters the records based on a full or partials delivery date 
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //send the date parameter to the database
                DB.AddParameter("@Delivery_Date", Delivery_Date);
                //execute the stored procedure 
                DB.Execute("sproc_tblVPDelivery_FilterByDeliveryDate");
                //populate the aray list with the data table
                PopulateArray(DB);
            }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Title", mThisDelivery.Title);
            DB.AddParameter("@FirstName", mThisDelivery.FirstName);
            DB.AddParameter("@LastName", mThisDelivery.LastName);
            DB.AddParameter("@House_No", mThisDelivery.House_No);
            DB.AddParameter("@Delivery_Address", mThisDelivery.Delivery_Address);
            DB.AddParameter("@Delivery_Postcode", mThisDelivery.Delivery_Postcode);
            DB.AddParameter("@Delivery_Date", mThisDelivery.Delivery_Date);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVPDelivery_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Delivery_ID", mThisDelivery.Delivery_ID);
            //execute the stored procedure
            DB.Execute("sproc_tblVPDelivery_Delete");
        }

        public int Update()
        {
            //updates an existing record based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //set the parameters for the stored procedure
            DB.AddParameter("@Delivery_ID", mThisDelivery.Delivery_ID);
            DB.AddParameter("@Title", mThisDelivery.Title);
            DB.AddParameter("@FirstName", mThisDelivery.FirstName);
            DB.AddParameter("@LastName", mThisDelivery.LastName);
            DB.AddParameter("@House_No", mThisDelivery.House_No);
            DB.AddParameter("@Delivery_Address", mThisDelivery.Delivery_Address);
            DB.AddParameter("@Delivery_Postcode", mThisDelivery.Delivery_Postcode);
            DB.AddParameter("@Delivery_Date", mThisDelivery.Delivery_Date);
            //execute the stored procedure
            return DB.Execute("sproc_tblVPDelivery_Update");


        }

    }
}
