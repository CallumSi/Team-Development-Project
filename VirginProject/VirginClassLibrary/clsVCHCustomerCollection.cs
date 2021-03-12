using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVCHCustomerCollection
    {
        //private data member for allCustomers list
        public List<clsVCHCustomer> mAllCustomers = new List<clsVCHCustomer>();
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
            mAllCustomers.Add(VCHCustomer);
            
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
            mAllCustomers.Add(VCHCustomer);
        }

        public int Count
        {
            get
            {
                //return the count property of the private list
                return mAllCustomers.Count;
            }
            set
            {
                //returning to this one soon
            }
        }
        
        //public property for allCustomers
        public List<clsVCHCustomer> AllCustomers
        {
            //getter sends data to requesting code
            get
            {
                //return the private data member
                return mAllCustomers;
            }
            //setter accepts data from other object
            set
            {
                //assign the incoming value to the private data member
                mAllCustomers = value;
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
        
    }
}