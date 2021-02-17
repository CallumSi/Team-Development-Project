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
        //String mVMcustomerEmail;
        String mVMcustomerUsername;
        String mVMcustomerPassword;

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
        public string VMcustomerEmail { get; set; }
        //{
        //    get
        //    {
        //        //return the private data
        //        //return mVMcustomerEmail;
        //    }
        //    set
        //    {
        //        //set the private data
        //        mVMcustomerEmail = value;
        //    }
        //}

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

        public string Valid(string VMcustomerFirstName, string VMcustomerLastName, string VMcustomerEmail, string VMcustomerUsername, string VMcustomerPassword)
        {
            //create a string variable to store the error message
            String Error = "";

           //****************CUSTOMER FIRSTNAME***********************// 
            //test to see if the customer firstname has zero characters
            if (VMcustomerFirstName.Length == 0)
            {
                //return error message 
                Error = Error + "Customer Firstname cannot be blank!";
            }

            //if the customer firstname is less than 1 and greater than 55 characters
            if (VMcustomerFirstName.Length < 1 | VMcustomerFirstName.Length > 55)
            {
                //return error message 
                Error = Error + "Customer Firstname cannot be more than 55 characters";

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
                Error = Error + "Customer Lastname cannot be more than 55 characters";

            }

            //  Customer Email Validation

            //if customer email is blank 
            if (VMcustomerEmail.Length == 0)
            {
                //record the error 
                Error = Error + "CUSTOMER EMAIL CANNOT BE BLANK!" + " ";

            }

            if (VMcustomerEmail.Length < 11 | VMcustomerEmail.Length > 55)
            {
                //set the error message 
                Error = Error + "CUSTOMER EMAIL MUST BE BETWEEN 11 TO 55 CHARACTERS!" + " ";
            }


            //return any error messages
            return Error; 
        }
    }
}