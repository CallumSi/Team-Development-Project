using System.Collections.Generic;
using System;

namespace VirginClassLibrary
{
    public class clsVCHCustomerCollection
    {
        //private data member for CustomerList list
        List<clsVCHCustomer> mCustomerList = new List<clsVCHCustomer>();
        //private data member for thisCustomer
        clsVCHCustomer mThisCustomer = new clsVCHCustomer();

        //public constructor for the class
        public clsVCHCustomerCollection()
        {
            //create an instance of the class
            clsVCHCustomer VCHCustomer = new clsVCHCustomer();
            //set the first customers details 
            VCHCustomer.FirstName = "Dante";
            VCHCustomer.LastName = "Alighieri";
            VCHCustomer.Address = "12 Florence Cresent, Leicestershire";
            VCHCustomer.PostCode = "LE13 2RV";
            VCHCustomer.Username = "DanteAyyy";
            VCHCustomer.Email = "d.alighieri@outlook.com";
            VCHCustomer.Password = "3InPuPa";
            VCHCustomer.PhoneNumber = "07912345678";
            //add the first customer to the private list of customers
            mCustomerList.Add(VCHCustomer);

            //re initialising the object for new customer data
            VCHCustomer = new clsVCHCustomer();
            //set the second customers details 
            VCHCustomer.FirstName = "Carl";
            VCHCustomer.LastName = "Weber";
            VCHCustomer.Address = "17 Eutin Road, Leicester";
            VCHCustomer.PostCode = "LE2 6LD";
            VCHCustomer.Username = "Carl_Webz";
            VCHCustomer.Email = "c.mv-weber@gmail.com";
            VCHCustomer.Password = "A1A2A3DF";
            VCHCustomer.PhoneNumber = "07956781234";
            //add the second customer to the private list of customers
            mCustomerList.Add(VCHCustomer);
        }

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
        
        //public property for allCustomers
        public List<clsVCHCustomer> CustomerList
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mCustomerList;
            }
            //setter accepts data from other object
            set
            {
                //assign the incoming value to the private data member
                mCustomerList = value;
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
        
        public int Add()
        {
            //add a new customer record to the database, based on values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@Username", mThisCustomer.Username);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@Password", mThisCustomer.Password);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVCHCustomer_Insert");
        }

        /*
        //constructor for the class
        public clsVCHCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblVCHCustomer_SelectAll");
            //get the count of the records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsVCHCustomer ACustomer = new clsVCHCustomer();
                //read in the fields from the curent record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
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
            
        }*/

    }
}