using System;

namespace VirginClassLibrary
{
    public class clsVPPayment
    {

        //private data member for Payment_ID
        private Int32 mPayment_ID;
        //payment attributes
        Int32 mCardNo;
        DateTime mExpiryDate;
        Int32 mSecurityNo;
       
        //card no
        public int CardNo

        {
            get
            {
                //return the private data
                return mCardNo;
            }
                 set
            {
                //set the private data
                mCardNo = value;
            }


        }
        public DateTime ExpiryDate

        {
            get
            {
                //return the private data
                return mExpiryDate;
            }
                set
            {
                //set the private data 
                mExpiryDate = value;
            }


        }
        public int SecurityNo

        {
            get
            {
                //return the private data
                return mSecurityNo;
            }
                
                set
            {
                //set the private data
                mSecurityNo = value;
            }


        }
        public int Payment_ID

        {
            get
            {
                //return the private data 
                return mPayment_ID;
            }
                
                set
            {
                //set the private data 
                mPayment_ID = value;
            }

        }

        public bool Find(int Payment_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StaffID to search
            DB.AddParameter("@Payment_ID", Payment_ID);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPPayment_FilterByPaymentID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                Payment_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Payment_ID"]);
                CardNo = Convert.ToInt32(DB.DataTable.Rows[0]["CardNo"]);
                ExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpiryDate"]);
                SecurityNo = Convert.ToInt32(DB.DataTable.Rows[0]["SecurityNo"]);
                              //return that everything works
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem 
                return false;
            }

        }
        
        public string Valid(string CardNo, string ExpiryDate, string SecurityNo)
        {
            string Error = "";

            //***VALIDATION EXPIRY DATE***//

            DateTime DateTemp;

            try
            {
                //copy the expiry date value to the datetemp variable
                DateTemp = Convert.ToDateTime(ExpiryDate);

                //check to see if the expiry date is less than 100 years
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error 
                    Error = Error + "THE EXPIRY DATE CAN'T BE IN THE PAST, ENTER A VALID DATE" + " ";
                }

                //check to see if the expiry date is more than 100 years
                if (DateTemp > DateTime.Now.Date.AddYears(100))
                {
                    //record the error
                    Error = Error + "ENTER A VALID EXPIRY DATE" + " ";

                }
            }

            catch
            {
                //record the error
                Error = Error + "THE DATE IS NOT A VALID DATE";

            }

            return Error;
        }
    }
}
