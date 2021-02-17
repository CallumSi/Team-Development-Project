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

        public clsVMCustomerCollection()
        {
            //create the item of test data
            clsVMCustomer TestItem = new clsVMCustomer();
            //set its properties
            TestItem.VMCustomerID = 1;
            TestItem.VMcustomerFirstName = "Paul";
            TestItem.VMcustomerLastName = "Pogba";
            TestItem.VMcustomerEmail = "PPogba6@hotmail.co.uk";
            TestItem.VMcustomerUsername = "MUFCForever";
            TestItem.VMcustomerPassword = "PaulPogba6";
            //add the item to the test item
            mCustomerList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsVMCustomer();
            //set its properties            
            TestItem.VMCustomerID = 2;
            TestItem.VMcustomerFirstName = "Sufiyaan";
            TestItem.VMcustomerLastName = "Hussain";
            TestItem.VMcustomerEmail = "SufiyaanHussain@yahoo.com";
            TestItem.VMcustomerUsername = "SufiyaanHussain97";
            TestItem.VMcustomerPassword = "ManUtd97";
            //add the item to the test list
            mCustomerList.Add(TestItem);
        }

        //Add method
        public int Add()
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            //DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.VMcustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.VMcustomerLastName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.VMcustomerEmail);
            DB.AddParameter("@CustomerUsername", mThisCustomer.VMcustomerUsername);
            DB.AddParameter("@CustomerPassword", mThisCustomer.VMcustomerPassword);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVMCustomer_Insert");
        }
    }
}