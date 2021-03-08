using System;

namespace VirginClassLibrary
{
    public class clsVPCart
    {
        public int CartNo { get; set; }
        public string Products { get; set; }

        public string Valid(string Products)
        {
            string Error = "";

            //***VALIDATION PRODUCTS***//

            //record the error
            if (Products.Length == 1)
            {
                //record the error 
                Error = Error + "THE PRODUCTS MUST BE MORE THAN 1 CHARACTER" + "";
            }

            //record the error message
            if (Products.Length < 2 | Products.Length > 50)
            {
                //record the error
                Error = Error + "THE PRODUCT MUST BEEN BETWEEN 2 AND 50 CHARACTERS" + "";
            }

            return Error;
        }
    }
}