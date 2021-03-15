using System;

namespace VirginClassLibrary
{
    public class clsVCHCustomer
    {
        //private customer ID property
        private int mCustomerID;
        //private customer First Name property
        private string mFirstName;
        //private customer Last Name property
        private string mLastName;
        //private customer Address property
        private string mAddress;
        //private customer Postcode property
        private string mPostCode;
        //private customer Username property
        private string mUsername;
        //private customer Email property
        private string mEmail;
        //private customer Password property
        private string mPassword;
        //private customer Phone Number property
        private string mPhoneNumber;

        //customer ID property
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the private data
                mCustomerID = value;
            }
        }

        //customer First Name property
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the private data
                mFirstName = value;
            }
        }

        //customer Last Name property
        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the private data
                mLastName = value;
            }
        }

        //customer Address property
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }

        //customer Postcode property
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the private data
                mPostCode = value;
            }
        }

        //customer Username property
        public string Username
        {
            get
            {
                //return the private data
                return mUsername;
            }
            set
            {
                //set the private data
                mUsername = value;
            }
        }

        //customer Email property
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the private data
                mEmail = value;
            }
        }

        //customer Password property
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }

        //customer Phone Number property
        public string PhoneNumber
        {
            get
            {
                //return the private data
                return mPhoneNumber;
            }
            set
            {
                //set the private data
                mPhoneNumber = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for CustomerID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblVCHCustomer_FilterByCustomerID");
            //if one record is found (there should only be 1 or 0 records found)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                //return that the method worked
                return true;
            }
            //if no record is found
            else
            {
                //return false - showing an error
                return false;
            }

        }

        //Valid Method
        public string Valid(string FirstName, string LastName, string Address, string PostCode, string Username, string Email, string Password, string PhoneNumber)
        {
            //string variable to store the error message
            string Error = "";
            //if the first name length is blank
            if (FirstName.Length == 0)
            {
                //return the following error message
                return "The customers first name may not be blank. Please enter a First Name.";
            }
            //if the first name length is more than 30 characters
            if (FirstName.Length > 30)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a shorter name.";
            }
            //if the first name length is less than 2 characters
            if (FirstName.Length < 2)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a longer name.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the last name length is blank
            if (LastName.Length == 0)
            {
                //return the following error message
                return "The customers last name may not be blank. Please enter a Last Name.";
            }
            //if the last name length is more than 30 characters
            if (LastName.Length > 30)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a shorter name.";
            }
            //if the last name length is less than 2 characters 
            if (LastName.Length < 2)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a longer name.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the address length is blank
            if (Address.Length == 0)
            {
                //return the following error message
                return "The address may not be blank. Please enter an address.";
            }
            //if the address length is more than 50 characters
            if (Address.Length > 50)
            {
                //return the following error message
                return "The address entered holds too many characters. Please enter a shorter address and do not include a postcode.";
            }
            //if the address length is less than 3 characters 
            if (Address.Length < 3)
            {
                //return the following error message
                return "The address entered is too short. Please enter a longer address and do not include a postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the postcode length is blank
            if (PostCode.Length == 0)
            {
                //return the following error message
                return "The postcode may not be blank. Please enter a postcode.";
            }
            //if the post code length is more than 10 characters
            if (PostCode.Length > 10)
            {
                //return the following error message
                return "The postcode entered holds too many characters. Please enter a shorter postcode.";
            }
            //if the post code length is less than 5 characters 
            if (PostCode.Length < 5)
            {
                //return the following error message
                return "The postcode entered is too short. Please enter a longer postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the username length is blank
            if (Username.Length == 0)
            {
                //return the following error message
                return "The Username may not be blank. Please enter a Username.";
            }
            //if the username length is more than 30 characters
            if (Username.Length > 30)
            {
                //return the following error message
                return "Usernames may not exceed 30 characters, please enter a shorter username.";
            }
            //if the username length is less than 2 characters
            if (Username.Length < 2)
            {
                //return the following error message
                return "Usernames require at least 2 characters, please enter a longer username.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the Email length is blank
            if (Email.Length == 0)
            {
                //return the following error message
                return "The Email address may not be blank. Please enter an Email address.";
            }
            //if the Email length is more than 50 characters
            if (Email.Length > 50)
            {
                //return the following error message
                return "Email addresses cannot exceed 50 characters, please enter a shorter email address.";
            }
            //if the Email length is less than 7 characters 
            if (Email.Length < 7)
            {
                //return the following error message
                return "Email addresses require at least 7 characters, please enter a longer email address.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the Password length is blank
            if (Password.Length == 0)
            {
                //return the following error message
                return "The Password may not be blank. Please enter a Password.";
            }
            //if the Password length is more than 20 characters
            if (Password.Length > 20)
            {
                //return the following error message
                return "Passwords may not exceed 20 characters, please enter a shorter password.";
            }
            //if the Password length is less than 6 characters 
            if (Password.Length < 6)
            {
                //return the following error message
                return "Passwords require at least 6 characters, please enter a longer password.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the Phone number length is blank
            if (PhoneNumber.Length == 0)
            {
                //return the following error message
                return "The Phone number may not be blank. Please enter a Phone number.";
            }
            //if the PhoneNumber length is more than 11 characters
            if (PhoneNumber.Length > 11)
            {
                //return the following error message
                return "Phone numbers may not exceed 11 numbers, please enter a shorter number.";
            }
            //if the PhoneNumber length is less than 11 characters 
            if (PhoneNumber.Length < 11)
            {
                //return the following error message
                return "Phone numbers require at 11 numbers, please enter a longer number.";
            }

            return Error;
        }
    }
}