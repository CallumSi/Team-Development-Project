using System;

namespace VirginClassLibrary
{
    public class clsVPPhone
    {
        public string Capacity { get; set; }
        public string Colour { get; set; }
        public string Description { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public bool StockStatus { get; set; }

        public string Valid(string capacity, string colour, string description, string make, string model, decimal price, bool stockStatus)
        {
            string Error = "";

            //***VALIDATION CAPACITY***//

            //record the error
            if(Capacity.Length == 3)
            {
                //record the error 
                Error = Error + "THE CAPACITY MUST BE MORE THAN 3 CHARACTERS/NUMBERS";
            }

            //record the error message 
            if (Capacity.Length < 4 | Capacity.Length > 5)
            {
                //record the error 
                Error = Error + "THE CAPACITY MUST BE BETWEEN 4 AND 5 CHARACTERS/NUMBERS" + "";
            }

            return Error;
        }
    }
}