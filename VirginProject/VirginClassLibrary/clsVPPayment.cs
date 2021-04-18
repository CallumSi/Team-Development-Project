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
                mPayment_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Payment_ID"]);
                mCardNo = Convert.ToInt32(DB.DataTable.Rows[0]["CardNo"]);
                mExpiryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpiryDate"]);
                mSecurityNo = Convert.ToInt32(DB.DataTable.Rows[0]["SecurityNo"]);
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

            //// create some variable for later use
            int ConvertedCardNo;
            int ConvertedSecurityNo;

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


            ////***VALIDATION CARDNO***//

            //if (CardNo.Length > 0)
            //{
            //    try
            //    {
            //        Int32 TempCardNo = Convert.ToInt32(CardNo);
            //        {
            //            if (TempCardNo < 16)
            //            {
            //                return "THE CARDNO MUST BE 16 DIGITS ONLY";
            //            }
            //        }

            //    }
            //    catch
            //    {
            //        return "THE CARDNO MUST NOT BE LEFT BLANK";
            //    }
            //}


            try
            {
                if (CardNo.Length == 16)
                {
                    ConvertedCardNo = Convert.ToInt32(CardNo);
                   
                }
                else
                {
                    Error += "PLEASE ENSURE THE CARDNO IS 16 DIGITS";
                }
            }
            catch
            {
                //return error message 
                Error += "THE CARDNO MUST BE ONLY DIGITS";

            }


            try
            {
                if (SecurityNo.Length == 3)
                {
                    ConvertedSecurityNo = Convert.ToInt32(SecurityNo);

                }
                else
                {
                    Error += "PLEASE ENSURE THE SECURITYNO IS 3 DIGITS";
                }
            }
            catch
            {
                //return error message 
                Error += "THE SECURITYNO MUST BE ONLY DIGITS";

            }


            //***VALIDATION SECURITYNO***//

            //try
            //{
            //    if (SecurityNo == "")
            //    {
            //        Error += "PLEASE ENTER A SECURITYNO";
            //    }
            //    else
            //    {
            //        ConvertedSecurityNo = Convert.ToInt32(SecurityNo);
            //        if (ConvertedSecurityNo > 2 && ConvertedSecurityNo < 4)
            //        {
            //            Error += "";
            //        }
            //        else
            //        {
            //            return error message
            //            Error += "THE SECURITYNO MUST ONLY BE 3 DIGITS";
            //        }
            //    }
            //}
            //catch
            //{
            //    return error message
            //    Error += "THE SECURITYNO MUST NOT BE LEFT BLANK";

            //}


            ////***VALIDATION SECURITYNO***//

            //if (SecurityNo.Length > 0)
            //{
            //    try
            //    {
            //        Int32 TempSecurityNo = Convert.ToInt32(SecurityNo);
            //        {
            //            if (TempSecurityNo < 3)
            //            {
            //                return "THE SECURITY MUST BE 3 DIGITS ONLY";
            //            }
            //        }

            //    }
            //    catch
            //    {
            //        return "THE SECURITYNO MUST NOT BE LEFT BLANK";
            //    }
            //}

            return Error;
        }
    }
}
