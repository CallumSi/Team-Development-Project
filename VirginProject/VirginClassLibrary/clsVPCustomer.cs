using System;

namespace VirginClassLibrary
{
    public class clsVPCustomer
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Postcode { get; set; }
        public string Street { get; set; }
        public int Telephone { get; set; }

        public string Valid(string FirstName)
        {
            if (FirstName != "")
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
            }
        }
    }
}