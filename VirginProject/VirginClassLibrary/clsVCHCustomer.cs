using System;

namespace VirginClassLibrary
{
    public class clsVCHCustomer
    {
        //customer First Name
        public string FirstName { get; set; }

        //customer Last Name
        public string LastName { get; set; }

        //customer Address
        public string Address { get; set; }

        //customer PhoneNumber
        public string PhoneNumber { get; set; }

        //customer Email
        public string Email { get; set; }

        //customer Password
        public string Password { get; set; }

        public Boolean Valid(string FirstName)
        {
            //var to record any errors found in FirstName 
            Boolean OK = true;
            //test to see if the FirstName has 1 character
            if (FirstName.Length == 1)
            {
                //set OK to false
                OK = false;
            }
            
            //test to see that FirstName has no more than 30 character
            if (FirstName.Length > 30)
            {
                //set OK to false
                OK = false;
            }

            //return all test results
            return OK;
        }
    }
}