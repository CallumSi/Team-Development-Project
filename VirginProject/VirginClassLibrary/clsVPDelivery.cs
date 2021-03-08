using System;

namespace VirginClassLibrary
{
    public class clsVPDelivery
    {
        public int Delivery_ID { get; set; }
        public int Order_ID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int House_No { get; set; }
        public string Delivery_Address { get; set; }
        public string Delivery_Postcode { get; set; }
        public DateTime Delivery_Date { get; set; }

        public string Valid(string Title, string FirstName, string LastName, string House_No, string Delivery_Address, string Delivery_Postcode, string Delivery_Date)
        {
            string Error = "";


            //***VALIDATION TITLE***//

            //record the error
            if (Title.Length == 1)
            {
                //record the error
                Error = Error + "THE TITLE MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message  
            if (Title.Length < 2 | Title.Length > 10)
            {
                //record the error
                Error = Error + " THE TITLE MUST BE BETWEEN 2 AND 10 CHARACTERS" + " ";

            }


            //***VALIDATION FIRST NAME***//

            //record the error
            if (FirstName.Length == 1)
            {
                //record the error
                Error = Error + "THE FIRST NAME MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message  
            if (FirstName.Length < 2 | FirstName.Length > 20)
            {
                //record the error
                Error = Error + " THE FIRST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS" + " ";

            }


            //***VALIDATION LAST NAME***//

            //record the error
            if (LastName.Length == 1)
            {
                //record the error
                Error = Error + "THE LAST NAME MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message  
            if (LastName.Length < 2 | LastName.Length > 20)
            {
                //record the error
                Error = Error + " THE LAST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS" + " ";

            }


            //***VALIDATION DELIVERY ADDRESS***//

            //record the error
            if (Delivery_Address.Length == 19)
            {
                //record the error
                Error = Error + "THE DELIVERY ADDRESS MUST BE MORE THAN 19 CHARACTER." + "";
            }

            //record the error message  
            if (Delivery_Address.Length < 20 | Delivery_Address.Length > 50)
            {
                //record the error
                Error = Error + " THE DELIVERY ADDRESS MUST BE BETWEEN 2 AND 50 CHARACTERS" + " ";

            }


            //***VALIDATION DELIVERY POSTCODE***//

            //record the error
            if (Delivery_Postcode.Length == 6)
            {
                //record the error
                Error = Error + "THE POSTCODE MUST BE MORE THAN 6 CHARACTER." + "";
            }

            //record the error message  
            if (Delivery_Postcode.Length < 7 | Delivery_Postcode.Length > 7)
            {
                //record the error
                Error = Error + " THE POSTCODE MUST ONLY BE 7 CHARACTERS" + " ";

            }


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


            return Error;
        }
    }
}