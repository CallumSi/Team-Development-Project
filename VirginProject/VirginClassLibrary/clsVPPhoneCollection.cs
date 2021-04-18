using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVPPhoneCollection
    {
        //private data member for the list
        List<clsVPPhone> mPhoneList = new List<clsVPPhone>();
        //private data member ThisPhone
        clsVPPhone mThisPhone = new clsVPPhone();

        //public property for the phone list
        public List<clsVPPhone> PhoneList

        {
            get
            {
                //return the private data
                return mPhoneList;
            }
               
            set
            {
                //set the private data 
                mPhoneList = value;
            }
                
                }
        public clsVPPhone ThisPhone

        {
            get
            {
                //return the private data 
                return mThisPhone;
            } 
                
            set
            {
                //set the private data 
                mThisPhone = value;
            }


        }
        //public property for count
        public int Count

        {
            get
            {
                //return that private data
                return mPhoneList.Count;
            }
                
            set
            {
                //we shall worry about this later
            }


        }

        //contructor for the class
        public clsVPPhoneCollection()
        {
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVPPhone_SelectAll");
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
            mPhoneList = new List<clsVPPhone>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank phone
                clsVPPhone APhone = new clsVPPhone();
                //read in the field from the current records
                APhone.PhoneID = Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneID"]);
                APhone.Capacity = Convert.ToString(DB.DataTable.Rows[Index]["Capacity"]);
                APhone.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                APhone.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                APhone.Make = Convert.ToString(DB.DataTable.Rows[Index]["Make"]);
                APhone.Model = Convert.ToString(DB.DataTable.Rows[Index]["Model"]);
                APhone.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                APhone.StockStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["StockStatus"]);
                APhone.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                //add the record to the private data member
                mPhoneList.Add(APhone);
                //point to the next record
                Index++;

            }
        }

            public void FilterByMake(string Make)
            {
                //filters the records based on a full or partials make
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //send the Make parameter to the database
                DB.AddParameter("@Make", Make);
                //execute the stored procedure 
                DB.Execute("sproc_tblVPPhone_FilterByMake");
                //populate the aray list with the data table
                PopulateArray(DB);
            }

       

        public int Add()
        {
            //adds a new record to the database based on the values of mThisPhone
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure

            DB.AddParameter("@Capacity", mThisPhone.Capacity);
            DB.AddParameter("@Colour", mThisPhone.Colour);
            DB.AddParameter("@Description", mThisPhone.Description);
            DB.AddParameter("@Make", mThisPhone.Make);
            DB.AddParameter("@Model", mThisPhone.Model);
            DB.AddParameter("@Price", mThisPhone.Price);
            DB.AddParameter("@StockStatus", mThisPhone.StockStatus);
            DB.AddParameter("@Quantity", mThisPhone.Quantity);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVPPhone_Insert");
        }


        public void Delete()
        {
            //deletes the record pointed to by ThisPhone
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PhoneID", mThisPhone.PhoneID);
            //execute the stored procedure
            DB.Execute("sproc_tblVPPhone_Delete");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of mThisPhone
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PhoneID", mThisPhone.PhoneID);
            DB.AddParameter("@Capacity", mThisPhone.Capacity);
            DB.AddParameter("@Colour", mThisPhone.Colour);
            DB.AddParameter("@Description", mThisPhone.Description);
            DB.AddParameter("@Make", mThisPhone.Make);
            DB.AddParameter("@Model", mThisPhone.Model);
            DB.AddParameter("@Price", mThisPhone.Price);
            DB.AddParameter("@StockStatus", mThisPhone.StockStatus);
            DB.AddParameter("@Quantity", mThisPhone.Quantity);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblVPPhone_Update");
        }

    }
}