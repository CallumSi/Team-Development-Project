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

        public string Valid(string VMcustomerFirstName)
        {
            if (VMcustomerFirstName != "")
                //test to see if the county has zero characters
                if (VMcustomerFirstName.Length < 56)
                {
                    //return no error message 
                    return "";
                }
                else
                {
                    //return no error message 
                    return "Customer first name cannot be more than 55 characters";
                }
            else
            {
                //return error message 
                return "Customer first name cannot be blank!";
            }
        }
    }
}