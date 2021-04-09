using System;

namespace VirginClassLibrary
{
    public class clsVCHHire
    {
        //Car Hire ID property
        public int HireID { get; set; }

        //hire date property
        public DateTime HireDate { get; set; }

        //hire price property
        public decimal HirePrice { get; set; }

        //hire location - address property
        public string HireAddress { get; set; }

        //hire location - postcode property
        public string HirePostCode { get; set; }

        //Car ID property
        //foreign key
        public int CarID { get; set; }
        
        //customer ID property
        //foreign key
        public int CustomerID { get; set; }
        
        //staff ID property
        //foreign key
        public int StaffID { get; set; }

        //driver age property
        public string DriverAge { get; set; }

        //drivers license number property
        public string DriverLicenseNumber { get; set; }

        //Valid method
        public string Valid(string HireAddress, string HirePostCode, string DriverAge, string DriverLicenseNumber)
        {
            //string variable to store the error message
            string Error = "";

            //if the hire address length is  blank 
            if (HireAddress.Length == 0)
            {
                //return the following error message
                return "The address cannot be blank. Please enter an address.";

            }
            //if the hire address length is more than 50 characters
            if (HireAddress.Length > 50)
            {
                //return the following error message
                return "The address entered holds too many characters. Please enter a shorter address and do not include a postcode.";
            }
            //if the hire address length is less than 3 characters 
            if (HireAddress.Length < 3)
            {
                //return the following error message
                return "The address entered is too short. Please enter a longer address and do not include a postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the HirePostCode length is  blank 
            if (HirePostCode.Length == 0)
            {
                //return the following error message
                return "The postcode cannot be blank. Please enter a postcode.";

            }
            //if the HirePostCode length is more than 10 characters
            if (HirePostCode.Length > 10)
            {
                //return the following error message
                return "The postcode entered holds too many characters. Please enter a shorter postcode.";
            }
            //if the HirePostCode length is less than 5 characters 
            if (HirePostCode.Length < 5)
            {
                //return the following error message
                return "The postcode entered is too short. Please enter a longer postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the driver age is blank 
            if (DriverAge.Length == 0)
            {
                //return the following error message
                return "The drivers age cannot be blank. Please enter a suitable age.";

            }
            //if the Drivers age length is more than 2 characters
            if (DriverAge.Length > 2)
            {
                //return the following error message
                return "Drivers younger than 18 are not permitted to hire a vehicle.";
            }
            //if the Drivers age length is less than 2 characters
            if (DriverAge.Length < 2 )
            {
                //return the following error message
                return "Drivers older than 99 are not permitted to hire a vehicle.";
            }
            
            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the driver license number is blank 
            if (DriverLicenseNumber.Length == 0)
            {
                //return the following error message
                return "The drivers license number cannot be blank. Please enter a suitable license number.";

            }
            //if the driver license number length is more than 20 characters
            if (DriverLicenseNumber.Length > 16)
            {
                //return the following error message
                return "Drivers license numbers must contain 16 characters, please enter a shorter number.";
            }
            //if the driver license number length is less than 6 characters 
            if (DriverLicenseNumber.Length < 16)
            {
                //return the following error message
                return "Drivers license numbers must contain 16 characters, please enter a longer number.";
            }
            return Error;
        }
    }
}