using System;

namespace VirginClassLibrary
{
    public class clsVPStaff
    {
        public string Staff_FirstName { get; set; }
        public string Staff_LastName { get; set; }
        public string Staff_Street { get; set; }
        public string Staff_Address { get; set; }
        public string Staff_Postcode { get; set; }
        public string Staff_Email { get; set; }
        public string Staff_Telephone { get; set; }

        public string Valid(string Staff_FirstName, string Staff_LastName, string Staff_Street, string Staff_Address, string Staff_Postcode, string Staff_Email, string Staff_Telephone)
        {
            string Error = "";

            //***VALIDATION FIRST NAME***//

            //record the error
            if (Staff_FirstName.Length == 1)
            {
                //record the error
                Error = Error + "THE FIRST NAME MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message
            if (Staff_FirstName.Length < 2 | Staff_FirstName.Length > 20)
            {
                //record the error 
                Error = Error + "THE FIRST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS." + "";
            }
            



            //***VALIDATION LAST NAME***//

            //record the error
            if (Staff_LastName.Length == 1)
            {
                //record the error
                Error = Error + "THE LAST NAME MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message
            if (Staff_LastName.Length < 2 | Staff_LastName.Length > 20)
            {
                //record the error 
                Error = Error + "THE LAST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS." + "";
            }



            //***VALIDATION STREET***//

            //record the error
            if (Staff_Street.Length == 4)
            {
                //record the error
                Error = Error + "THE STREET MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message
            if (Staff_Street.Length < 5 | Staff_Street.Length > 50)
            {
                //record the error 
                Error = Error + "THE STREET MUST BE BETWEEN 5 AND 50 CHARACTERS." + "";
            }



            //***VALIDATION ADDRESS NAME***//

            //record the error
            if (Staff_Address.Length == 19)
            {
                //record the error
                Error = Error + "THE ADDRESS MUST BE MORE THAN 19 CHARACTER." + "";
            }

            //record the error message
            if (Staff_Address.Length < 20 | Staff_Address.Length > 50)
            {
                //record the error 
                Error = Error + "THE ADDRESS MUST BE BETWEEN 20 AND 50 CHARACTERS." + "";
            }


            //***VALIDATION POSTCODE NAME***//

            //record the error
            if (Staff_Postcode.Length == 6)
            {
                //record the error
                Error = Error + "THE POSTCODE MUST BE MORE THAN 6 CHARACTERS." + "";
            }

            //record the error message
            if (Staff_Postcode.Length < 7 | Staff_Postcode.Length > 7)
            {
                //record the error 
                Error = Error + "THE POSTCODE MUST ONLY BE 7 CHARACTERS." + "";
            }


            //***VALIDATION EMAIL NAME***//

            //record the error
            if (Staff_Email.Length == 19)
            {
                //record the error
                Error = Error + "THE EMAIL MUST BE MORE THAN 19 CHARACTERS." + "";
            }

            //record the error message
            if (Staff_Email.Length < 20 | Staff_Email.Length > 50)
            {
                //record the error 
                Error = Error + "THE EMAIL MUST BE BETWEEN 20 AND 50 CHARACTERS." + "";
            }


            ////***VALIDATION TELEPHONE NAME***//

            //record the error
            if (Staff_Telephone.Length == 10)
            {
                //record the error
                Error = Error + "THE TELEPHONE MUST BE MORE THAN 10 DIGITS." + "";
            }

            //record the error message
            if (Staff_Telephone.Length < 11 | Staff_Telephone.Length > 11)
            {
                //record the error 
                Error = Error + "THE TELEPHONE MUST BE ONLY BE 11 DIGITS." + "";
            }

            return Error;

           

        }
    }
}