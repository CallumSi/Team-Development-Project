using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsVPCartCollection
    {
        //private data member for the list 
        List<clsVPCart> mCartList = new List<clsVPCart>();
        //private data member for ThisCart 
        clsVPCart mThisCart = new clsVPCart();

        //public property for the cart list
        public List<clsVPCart> CartList
        {
            get
            {
                //return the private data 
                return mCartList;
            }
            set
            {
                //set the private data 
                mCartList = value;
            }

        }
        public clsVPCart ThisCart

        {
            get
            {
                //return the private data 
                return mThisCart;
            }

            set
            {
                //set the private data 
                mThisCart = value;
            }


        }
        public int Count

        {
            get
            {
                //return the private data 
                return mCartList.Count;
            }
            set
            {
                //we shall worry about this later 

            }

        }

        //contructor for the class
        public clsVPCartCollection()
        {
            //object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVPCart_SelectAll");
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
            mCartList = new List<clsVPCart>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank cart
                clsVPCart ACart = new clsVPCart();
                //read in the field from the current records
                ACart.CartNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CartNo"]);
                ACart.Products = Convert.ToString(DB.DataTable.Rows[Index]["Products"]);
                //add the record to the private data member
                mCartList.Add(ACart);
                //point to the next record
                Index++;

            }
        }

        public void FilterByProducts(string Products)
        {
            //filters the records based on a full or partials products
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Products parameter to the database
            DB.AddParameter("@Products", Products);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPCart_FilterByProducts");
            //populate the aray list with the data table
            PopulateArray(DB);
        }


        public int Add()
        {
            //adds a new record to the database based on the values of mThisCart
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Products", mThisCart.Products);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVPCart_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCart
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CartNo", mThisCart.CartNo);
            //execute the stored procedure
            DB.Execute("sproc_tblVPCart_Delete");
        }

        public int Update()
        {
            //updates an existing record based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("CartNo", mThisCart.CartNo);
            DB.AddParameter("@Products", mThisCart.Products);
            //execute the stored procedure
            return DB.Execute("sproc_tblVPCart_Update");

        }
    }
}