using System;

namespace VirginClassLibrary
{
    public class clsVPCustomer
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string FirstName { get;set; }
        public string LastName { get; set; }
        public string Postcode { get; set; }
        public string Street { get; set; }
        public int Telephone { get; set; }

        public string Valid(string FirstName)
        {
            string Error = "";

            // if the first name is blank
            if (FirstName.Length<= 1)
            {
                //record the error
               Error = Error + "The first name must be more than 1 character ";
            }

            //if the first name is greater than 21 characters 
            if (FirstName.Length > 21)
            {
                //record the error
                Error = Error + "The first name must be less than 21 characters";

            }

            //if last name is blank 
            if (LastName.Length <= 1)
            {
                Error = Error + "The last name must be more than 1 character";
            }
            //if the last name is greater than 21 characters
            if (LastName.Length > 21)
            {
                //record the error
                Error = Error + "The last name must be less than 21 characters";
            }

            return Error;

            /*if (FirstName != "")
                //test to see if the first name has any characters
                if (FirstName.Length < 21)
                {
                    return "";
                }
                else
                {
                    //return no error message
                    return " The customer first name must not be more than 20 characters";
                }
            else
            {
                //return an error message
                return "The customer first name cannot be left blank";
            }*/
        }
    }
}