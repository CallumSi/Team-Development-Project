using System;

namespace VirginClassLibrary
{
    public class clsVMCustomer
    {
        public string VMcustomerFirstName { get; set; }
        public string VMcustomerLastName { get; set; }
        public string VMcustomerEmail { get; set; }
        public string VMcustomerUsername { get; set; }

        public string Valid(string VMcustomerFirstName)
        {
            if (VMcustomerFirstName != "")
                //test to see if the county has zero characters
                if (VMcustomerFirstName.Length < 56)
                {
                    //return no error message 
                    return "";
                }
                else
                {
                    //return no error message 
                    return "Customer first name cannot be more than 55 characters";
                }
            else
            {
                //return error message 
                return "Customer first name cannot be blank! ";
            }
        }
    }
}