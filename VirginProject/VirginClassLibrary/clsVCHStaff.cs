using System;

namespace VirginClassLibrary
{
    public class clsVCHStaff
    {
        //staff first name property 
        public string StaffFirstName { get; set; }
        
        //staff last name property 
        public string StaffLastName { get; set; }

        //staff address property 
        public string StaffAddress { get; set; }

        //staff postcode property 
        public string StaffPostCode { get; set; }

        //staff email property
        public string StaffEmail { get; set; }

        //staff password property
        public string StaffPassword { get; set; }

        //staff phone number property
        public string StaffPhoneNumber { get; set; }

        //Valid Method
        public string Valid(string StaffFirstName, string StaffLastName, string StaffAddress, string StaffPostCode, string StaffEmail, string StaffPassword, string StaffPhoneNumber)
        {
            //string variable to store the error message
            string Error = "";
            //if the staff first name length is more than 30 characters
            if (StaffFirstName.Length > 30)
            {
                //return the following error message
                return "The staffs first name may not exceed 30 characters, please fill it in accordingly.";
            }
            //if the staff first name length is less than 2 characters
            if (StaffFirstName.Length < 2)
            {
                //return the following error message
                return "The staffs first name is too short, please fill it in accordingly.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the staff last name length is more than 30 characters
            if (StaffLastName.Length > 30)
            {
                //return the following error message
                return "The staffs last name may not exceed 30 characters, please fill it in accordingly.";
            }
            //if the staff last name length is less than 2 characters
            if (StaffLastName.Length < 2)
            {
                //return the following error message
                return "The staffs last name is too short, please fill it in accordingly.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the staff address length is more than 50 characters
            if (StaffAddress.Length > 50)
            {
                //return the following error message
                return "An address may not exceed 50 characters, please fill it in accordingly.";
            }
            //if the staff address length is less than 3 characters 
            if (StaffAddress.Length < 3)
            {
                //return the following error message
                return "An address may not be blank, please fill it in accordingly.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffPostCode length is more than 10 characters
            if (StaffPostCode.Length > 10)
            {
                //return the following error message
                return "Postcodes cannot exceed 10 characters, please fill it in accordingly.";
            }
            //if the StaffPostCode length is less than 5 characters 
            if (StaffPostCode.Length < 5)
            {
                //return the following error message
                return "Postcodes cannot have less than 5 characters, please fill it in accordingly.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffEmail length is more than 50 characters
            if (StaffEmail.Length > 50)
            {
                //return the following error message
                return "An Email address cannot exceed 50 characters, please fill it in accordingly.";
            }
            //if the StaffEmail length is less than 7 characters 
            if (StaffEmail.Length < 7)
            {
                //return the following error message
                return "An Email address cannot have less than 7 characters, please fill it in accordingly.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffPassword length is more than 20 characters
            if (StaffPassword.Length > 20)
            {
                //return the following error message
                return "Passwords may not exceed 20 characters, please fill it in accordingly.";
            }
            //if the StaffPassword length is less than 6 characters 
            if (StaffPassword.Length < 6)
            {
                //return the following error message
                return "Passwords cannot have less than 6 characters, please fill it in accordingly.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffPhoneNumber length is more than 12 characters
            if (StaffPhoneNumber.Length > 12)
            {
                //return the following error message
                return "Phone numbers may not exceed 12 characters, please fill it in accordingly.";
            }
            //if the StaffPhoneNumber length is less than 11 characters 
            if (StaffPhoneNumber.Length < 11)
            {
                //return the following error message
                return "Phone numbers cannot have less than 11 characters, please fill it in accordingly.";
            }

            return Error;
        }
    }
}