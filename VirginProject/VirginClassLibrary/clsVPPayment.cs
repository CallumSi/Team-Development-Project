using System;

namespace VirginClassLibrary
{
    public class clsVPPayment
    {
        public int CardNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int SecurityNo { get; set; }

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