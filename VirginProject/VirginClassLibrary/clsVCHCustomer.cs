using System;

namespace VirginClassLibrary
{
    public class clsVCHCustomer
    {
        //customer FirstName property
        public string FirstName { get; set; }

        //customer LastName property
        public string LastName { get; set; }

        //customer Address property
        public string Address { get; set; }

        //customer PhoneNumber property
        public string PhoneNumber { get; set; }

        //customer Email property
        public string Email { get; set; }

        //customer Password property
        public string Password { get; set; }

        public bool Valid(string FirstName, string LastName)
        {
            //var to record any errors foind in the FirstName (if everything is okay)
            Boolean OK = true;
            
            //test to see if the FirstName has one character
            if (FirstName.Length == 1)
            {
                //set OK to false
                OK = false;
            }

            //test to see the FirstName string has no more than 30 characters
            if (FirstName.Length > 30)
            {
                //set OK to false
                OK = false;
            }

            //test to see if the LastName has one character
            if (LastName.Length == 1)
            {
                //set OK to false
                OK = false;
            }

            //test to see the LastName string has no more than 30 characters
            if (LastName.Length > 30)
            {
                //set OK to false
                OK = false;
            }
            
            //return all test results
            return OK;
        }
    }
}