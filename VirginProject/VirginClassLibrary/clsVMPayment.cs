using System;

namespace VirginClassLibrary
{
    public class clsVMPayment
    {
        //Unique Payment Identifier
        //private data member for the VMPaymentID property
        private int mVMPaymentID;
        Boolean mVMPaymentStatus;
        String mVMPaymentType;

        public int VMPaymentID
        {
            get
            {
                //return private data
                return mVMPaymentID;
            }
            set
            {
                //set value to private data
                mVMPaymentID = value;
            }
        }

        public bool VMPaymentStatus
        {
            get
            {
                //return private data
                return mVMPaymentStatus;
            }
            set
            {
                //set value to private data
                mVMPaymentStatus = value;
            }
        }

        public string VMPaymentType
        {
            get
            {
                //return private data
                return mVMPaymentType;
            }
            set
            {
                //set value to private data
                mVMPaymentType = value;
            }
        }

        public bool Find(int VMPaymentID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@VMPaymentID", VMPaymentID);
            //execute the stored procedure
            DB.Execute("sproc_tblVMPayment_FilterByVMPaymentID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mVMPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["VMPaymentID"]);
                mVMPaymentStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["VMPaymentStatus"]);
                mVMPaymentType = Convert.ToString(DB.DataTable.Rows[0]["VMPaymentType"]);
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

        public string Valid(string VMPaymentType)
        {
            //create a string variable to store the error message
            String Error = "";

            //****************PAYMENT TYPPE***********************// 
            //test to see if the Payment Type has zero characters
            if (VMPaymentType.Length == 0)
            {
                //return error message 
                Error = Error + "Payment Type cannot be blank!" + " ";
            }

            //if the Payment Type is less than 1 and greater than 55 characters
            if (VMPaymentType.Length < 1 | VMPaymentType.Length > 55)
            {
                //return error message 
                Error = Error + "Payment Type cannot be more than 55 characters" + " ";
            }

            //return any error messages
            return Error;
        }
    }
}