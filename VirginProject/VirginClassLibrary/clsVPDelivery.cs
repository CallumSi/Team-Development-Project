using System;

namespace VirginClassLibrary
{
    public class clsVPDelivery
    {
        
        //Delivery ID Property
        public int Delivery_ID { get; set; }

        //Order ID Property
        public int Order_ID { get; set; }

        //Title Property
        public string Title { get; set; }

        //FirstName Property
        public string FirstName { get; set; }

        //LastName Property
        public string LastName { get; set; }

        //House No Property
        public int House_No { get; set; }

        //Delivery Address Property
        public string Delivery_Address { get; set; }

        //Delivery Postcode Property
        public string Delivery_Postcode { get; set; }

        //Delivery Date Property
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



            return "";
        }
    }
}