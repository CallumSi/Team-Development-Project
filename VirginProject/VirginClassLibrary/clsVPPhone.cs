using System;

namespace VirginClassLibrary
{
    public class clsVPPhone
    {
        //Phone Capacity Property
        public string Capacity { get; set; }

        //Phone Colour Property
        public string Colour { get; set; }

        //Phone Description Property
        public string Description { get; set; }

        //Phone Make Property
        public string Make { get; set; }

        //Phone Model Property
        public string Model { get; set; }

        //Phone Price Property
        public decimal Price { get; set; }

        //Phone Stock Status Property
        public bool StockStatus { get; set; }

        //Phone ID Property
        public int PhoneID { get; set; }

        public string Valid(string Capacity, string Colour, string Description, string Make, string Model, string Price, string StockStatus)
        {
            string Error = "";

            //***VALIDATION CAPACITY***//

            //record the error
            if (Capacity.Length == 3)
            {
                //record the error 
                Error = Error + "THE CAPACITY MUST BE MORE THAN 3 CHARACTERS";
            }

            //record the error message 
            if (Capacity.Length < 4 | Capacity.Length > 5)
            {
                //record the error 
                Error = Error + "THE CAPACITY MUST BE BETWEEN 4 AND 5 CHARACTERS" + "";
            }



            //***VALIDATION COLOUR***//

            //record the error
            if (Colour.Length == 1)
            {
                //record the error 
                Error = Error + "THE COLOUR MUST BE MORE THAN 2 CHARACTERS";
            }

            //record the error message 
            if (Colour.Length < 2 | Colour.Length > 10)
            {
                //record the error 
                Error = Error + "THE COLOUR MUST BE BETWEEN 2 AND 10 CHARACTERS" + "";
            }


            //***VALIDATION DESCRIPTION***//

            //record the error
            if (Description.Length == 4)
            {
                //record the error 
                Error = Error + "THE DESCRIPTION MUST BE MORE THAN 4 CHARACTERS";
            }

            //record the error message 
            if (Description.Length < 5 | Description.Length > 50)
            {
                //record the error 
                Error = Error + "THE DESCRIPTION MUST BE BETWEEN 5 AND 50 CHARACTERS" + "";
            }



            //***VALIDATION MAKE***//

            //record the error
            if (Make.Length == 3)
            {
                //record the error 
                Error = Error + "THE MAKE MUST BE MORE THAN 3 CHARACTERS";
            }

            //record the error message 
            if (Make.Length < 4 | Make.Length > 15)
            {
                //record the error 
                Error = Error + "THE MAKE MUST BE BETWEEN 4 AND 15 CHARACTERS" + "";
            }


            //***VALIDATION MODEL***//

            //record the error
            if (Model.Length == 1)
            {
                //record the error 
                Error = Error + "THE MODEL MUST BE MORE THAN 1 CHARACTERS";
            }

            //record the error message 
            if (Model.Length < 2 | Model.Length > 30)
            {
                //record the error 
                Error = Error + "THE MODEL MUST BE BETWEEN 2 AND 30 CHARACTERS" + "";
            }



            return Error;
        }
    }
}