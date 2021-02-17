using System;

namespace VirginClassLibrary
{
    public class clsVPCustomer
    {
        //Customer Address Property
        public string Customer_Address { get; set; }

        //Customer  Email Property
        public string Customer_Email { get; set; }

        //Customer First Name Property
        public string Customer_FirstName { get;set; }

        //Customer Last Name Property
        public string Customer_LastName { get; set; }

        //Customer Postcode Property
        public string Customer_Postcode { get; set; }

        //Customer Street Property
        public string Customer_Street { get; set; }

        //Customer Address Property
        public int Customer_Telephone { get; set; }

        public string Valid(string Customer_FirstName, string Customer_LastName, string Customer_Street, string Customer_Address, string Customer_Postcode, string Customer_Email /*string Customer_Telephone*/)
        {
            string Error = "";


            //***VALIDATION FIRST NAME***//

            //record the error
            if (Customer_FirstName.Length == 0)
            {
                //record the error
                Error = Error + "THE FIRST NAME CAN'T BE LEFT BLANK." + "";
            }

            //record the error message  
            if (Customer_FirstName.Length < 2 | Customer_FirstName.Length > 20)
            {
                //record the error
                Error = Error + "THE FIRST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS" + " ";

            }


            //***VALIDATION LAST NAME***//

            //record the error
            if (Customer_LastName.Length == 0)
            {
                //record the error
                Error = Error + "THE LAST NAME CAN'T BE LEFT BLANK." + " ";
            }

            //record the error message  
            if (Customer_LastName.Length < 2 | Customer_LastName.Length > 20)
            {
                //record the error
                Error = Error + "THE LAST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS" + " ";

            }


            //***VALIDATION STREET NAME***//

            //record the error
            if (Customer_Street.Length == 0)
            {
                //record the error
                Error = Error + "THE STREET CAN'T BE LEFT BLANK." + " ";
            }

            //record the error message  
            if (Customer_Street.Length < 5 | Customer_Street.Length > 50)
            {
                //record the error
                Error = Error + "THE STREET MUST BE BETWEEN 20 AND 50 CHARACTERS" + " ";

            }


            //***VALIDATION ADDRESS NAME***//

            //record the error
            if (Customer_Address.Length == 0)
            {
                //record the error
                Error = Error + "THE ADDRESS CAN'T BE LEFT BLANK." + " ";
            }

            //record the error message  
            if (Customer_Address.Length < 15 | Customer_Address.Length > 50)
            {
                //record the error
                Error = Error + "THE ADDRESS MUST BE BETWEEN 30 AND 50 CHARACTERS";

            }

            //***VALIDATION POSTCODE NAME***//

            //record the error
            if (Customer_Postcode.Length == 0)
            {
                //record the error
                Error = Error + "THE POSTCODE CAN'T BE LEFT BLANK." + " ";
            }

            //record the error message  
            if (Customer_Postcode.Length < 7 | Customer_Postcode.Length > 7)
            {
                //record the error
                Error = Error + "THE POSTCODE MUST ONLY BE 7 CHARACTERS" + " ";

            }


            //***VALIDATION EMAIL NAME***//

            //record the error
            if (Customer_Email.Length == 0)
            {
                //record the error
                Error = Error + "THE EMAIL CAN'T BE LEFT BLANK." + " ";
            }

            //record the error message  
            if (Customer_Email.Length < 20 | Customer_Email.Length > 50)
            {
                //record the error
                Error = Error + "THE EMAIL MUST BE BETWEEN 20 AN 50 CHARACTERS" + " ";

            }
            return Error;

            //***VALIDATION TELEPHONE NAME***//


            ////record the error
            //if (Customer_Telephone.Length == 0)
            //{
            //    //record the error
            //    Error = Error + "THE TELEPHONE CAN'T BE LEFT BLANK." + "";
            //}

            ////record the error message  
            //if (Customer_Telephone.Length < 11 | Customer_Telephone.Length > 11)
            //{
            //    //record the error
            //    Error = Error + "THE TELEPHONE MUST ONLY BE 11 NUMBERS";

            //}



        }
    }
}