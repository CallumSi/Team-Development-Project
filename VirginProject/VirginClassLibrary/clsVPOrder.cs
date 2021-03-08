using System;

namespace VirginClassLibrary
{
    public class clsVPOrder
    {
        public int Order_ID { get; set; }
        public int Customer_ID { get; set; }
        public DateTime Delivery_Date { get; set; }

        public string Valid(string Delivery_Date)
        {
            string Error = "";

            //***VALIDATION DELIVERY DATE***//

            DateTime DateTemp;

            try
            {
                //copy the delivery date value to the datetemp variable
                DateTemp = Convert.ToDateTime(Delivery_Date);

                //check to see if the delivery date is less than 100 years
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error 
                    Error = Error + "THE DELIVERY DATE CAN'T BE IN THE PAST, ENTER A VALID DATE" + " ";
                }

                //check to see if the delivery date is more than 100 years
                if (DateTemp > DateTime.Now.Date.AddYears(100))
                {
                    //record the error
                    Error = Error + "ENTER A VALID DELIVERY DATE" + " ";

                }
            }

            catch
            {
                //record the error
                Error = Error + "THE DATE IS NOT A VALID DATE";

            }

            return "";
        }
    }
}