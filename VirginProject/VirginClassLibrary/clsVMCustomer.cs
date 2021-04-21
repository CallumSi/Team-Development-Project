using System;

namespace VirginClassLibrary
{
    public class clsVMCustomer
    {
        //Unique Customer Identifier
        //private data member for the CustomerID property
        private Int32 mVMCustomerID;
        //Common Customer Attributes
        String mVMcustomerFirstName;
        String mVMcustomerLastName;
        String mVMcustomerEmail;
        String mVMcustomerUsername;
        String mVMcustomerPassword;
        Int32 mOriginalID;

        //Public property for CustomerID
        public int VMCustomerID
        {
            get
            {
                //return the private data
                return mVMCustomerID;
            }
            set
            {
                //set the private data
                mVMCustomerID = value;
            }
        }

        //Public property for customer firstname
        public string VMcustomerFirstName
        {
            get
            {
                //return the private data
                return mVMcustomerFirstName;
            }
            set
            {
                //set the private data
                mVMcustomerFirstName = value;
            }
        }

        //Public property for customer lastname
        public string VMcustomerLastName
        {
            get
            {
                //return the private data
                return mVMcustomerLastName;
            }
            set
            {
                //set the private data
                mVMcustomerLastName = value;
            }
        }

        //Public property for customer email
        public string VMcustomerEmail
        {
            get
            {
                //return the private data
                return mVMcustomerEmail;
            }
            set
            {
                //set the private data
                mVMcustomerEmail = value;
            }
        }

        //Public property for customer username
        public string VMcustomerUsername
        {
            get
            {
                //return the private data
                return mVMcustomerUsername;
            }
            set
            {
                //set the private data
                mVMcustomerUsername = value;
            }
        }

        //Public property for customer password
        public string VMcustomerPassword
        {
            get
            {
                //return the private data
                return mVMcustomerPassword;
            }
            set
            {
                //set the private data
                mVMcustomerPassword = value;
            }
        }

        //public property for OriginalID
        public int OriginalID
        {
            get
            {
                //return the private data
                return mOriginalID;
            }
            set
            {
                //set the value of the private data member
                mOriginalID = value;
            }
        }


        public bool Find(int VMCustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@VMCustomerID", VMCustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblVMCustomer_FilterByVMCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mVMCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["VMCustomerID"]);
                mVMcustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerFirstName"]);
                mVMcustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerLastName"]);
                mVMcustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerEmail"]);
                mVMcustomerUsername = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerUsername"]);
                mVMcustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerPassword"]);
                //mOriginalID = Convert.ToInt32(DB.DataTable.Rows[0]["OriginalID"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public bool FindOriginal(int VMCustomerID)
        {
            //instantiate the data connection
            clsDataConnection DB = new clsDataConnection();
            //ad the parameter we use to search
            DB.AddParameter("OriginalID", VMCustomerID);
            //execute the sproc
            DB.Execute("sproc_tblVMCustomer_FilterByOriginalID");
            //if record found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mVMCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["VMCustomerID"]);
                mVMcustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerFirstName"]);
                mVMcustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerLastName"]);
                mVMcustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerEmail"]);
                mVMcustomerUsername = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerUsername"]);
                mVMcustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["VMCustomerPassword"]);
                mOriginalID = Convert.ToInt32(DB.DataTable.Rows[0]["OriginalID"]);

                return true;
            }
            else
            {
                //return false if no record ofund
                return false;
            }
        }

        public string Valid(string VMcustomerFirstName, string VMcustomerLastName, string VMcustomerEmail, string VMcustomerUsername, string VMcustomerPassword)
        {
            //create a string variable to store the error message
            String Error = "";

           //****************CUSTOMER FIRSTNAME***********************// 
            //test to see if the customer firstname has zero characters
            if (VMcustomerFirstName.Length == 0)
            {
                //return error message 
                Error = Error + "Customer Firstname cannot be blank!" + " ";
            }

            //if the customer firstname is less than 1 and greater than 55 characters
            if (VMcustomerFirstName.Length < 1 | VMcustomerFirstName.Length > 55)
            {
                //return error message 
                Error = Error + "Customer Firstname cannot be more than 55 characters" + " ";

            }

            //****************CUSTOMER LASTNAME***********************// 
            //test to see if the customer lastname has zero characters
            if (VMcustomerLastName.Length == 0)
            {
                //return error message 
                Error = Error + "Customer Lastname cannot be blank!";
            }

            //if the customer lastname is less than 1 and greater than 55 characters
            if (VMcustomerLastName.Length < 1 | VMcustomerLastName.Length > 55)
            {
                //return error message 
                Error = Error + "Customer Lastname cannot be more than 55 characters" + " ";
            }

            //****************CUSTOMER EMAIL***********************// 
            //if customer email is blank 
            if (VMcustomerEmail.Length == 0)
            {
                //record the error 
                Error = Error + "Customer Email cannot be blank!" + " ";
            }

            if (VMcustomerEmail.Length < 11 | VMcustomerEmail.Length > 55)
            {
                //set the error message 
                Error = Error + "Customer Email must be between 11 and 55 CHARACTERS!" + " ";
            }

            //****************CUSTOMER USERNAME***********************// 
            //test to see if the customer username has zero characters
            if (VMcustomerUsername.Length == 0)
            {
                //return error message 
                Error = Error + "Customer Username cannot be blank!" + " ";
            }

            //if the customer username is less than 1 and greater than 55 characters
            if (VMcustomerUsername.Length < 1 | VMcustomerUsername.Length > 55)
            {
                //return error message 
                Error = Error + "Customer Username cannot be more than 55 characters" + " ";
            }

            //****************CUSTOMER PASSWORD***********************// 
            //test to see if the customer password has zero characters
            if (VMcustomerPassword.Length == 0)
            {
                //return error message 
                Error = Error + "Customer Password cannot be blank!" + " ";
            }

            //if the customer password is less than 7 and greater than 55 characters
            if (VMcustomerPassword.Length < 7 | VMcustomerPassword.Length > 55)
            {
                //return error message 
                Error = Error + "Customer Password cannot be less than 7 and more than 55 characters" + " ";
            }

            //return any error messages
            return Error; 
        }
    }
}