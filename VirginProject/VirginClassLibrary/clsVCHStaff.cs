using System;

namespace VirginClassLibrary
{
    public class clsVCHStaff
    {
        //staff ID property
        public int StaffID { get; set; }
        
        //staff first name property 
        public string StaffFirstName { get; set; }
        
        //staff last name property 
        public string StaffLastName { get; set; }

        //staff address property 
        public string StaffAddress { get; set; }

        //staff postcode property 
        public string StaffPostCode { get; set; }

        //staff username property
        public string StaffUsername { get; set; }

        //staff email property
        public string StaffEmail { get; set; }

        //staff password property
        public string StaffPassword { get; set; }

        //staff phone number property
        public string StaffPhoneNumber { get; set; }

        //Valid Method
        public string Valid(string StaffFirstName, string StaffLastName, string StaffAddress, string StaffPostCode, string StaffUsername, string StaffEmail, string StaffPassword, string StaffPhoneNumber)
        {
            //string variable to store the error message
            string Error = "";
            //if the staff first name length is more than 30 characters
            if (StaffFirstName.Length > 30)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a shorter name.";
            }
            //if the staff first name length is less than 2 characters
            if (StaffFirstName.Length < 2)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a longer name.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the staff last name length is more than 30 characters
            if (StaffLastName.Length > 30)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a shorter name.";
            }
            //if the staff last name length is less than 2 characters
            if (StaffLastName.Length < 2)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a longer name.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the staff address length is more than 50 characters
            if (StaffAddress.Length > 50)
            {
                //return the following error message
                return "The address entered holds too many characters. Please enter a shorter address and do not include a postcode.";
            }
            //if the staff address length is less than 3 characters 
            if (StaffAddress.Length < 3)
            {
                //return the following error message
                return "The address entered is too short. Please enter a longer address and do not include a postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffPostCode length is more than 10 characters
            if (StaffPostCode.Length > 10)
            {
                //return the following error message
                return "The postcode entered holds too many characters. Please enter a shorter postcode.";
            }
            //if the StaffPostCode length is less than 5 characters 
            if (StaffPostCode.Length < 5)
            {
                //return the following error message
                return "The postcode entered is too short. Please enter a longer postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the username length is more than 30 characters
            if (StaffUsername.Length > 30)
            {
                //return the following error message
                return "Usernames may not exceed 30 characters, please enter a shorter username.";
            }
            //if the username length is less than 2 characters
            if (StaffUsername.Length < 2)
            {
                //return the following error message
                return "Usernames require at least 2 characters, please enter a longer username.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffEmail length is more than 50 characters
            if (StaffEmail.Length > 50)
            {
                //return the following error message
                return "Email addresses cannot exceed 50 characters, please enter a shorter email address.";
            }
            //if the StaffEmail length is less than 7 characters 
            if (StaffEmail.Length < 7)
            {
                //return the following error message
                return "Email addresses require at least 7 characters, please enter a longer email address.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffPassword length is more than 20 characters
            if (StaffPassword.Length > 20)
            {
                //return the following error message
                return "Passwords may not exceed 20 characters, please enter a shorter password.";
            }
            //if the StaffPassword length is less than 6 characters 
            if (StaffPassword.Length < 6)
            {
                //return the following error message
                return "Passwords require at least 6 characters, please enter a longer password.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the StaffPhoneNumber length is more than 12 characters
            if (StaffPhoneNumber.Length > 12)
            {
                //return the following error message
                return "Phone numbers may not exceed 12 numbers, please enter a shorter number.";
            }
            //if the StaffPhoneNumber length is less than 11 characters 
            if (StaffPhoneNumber.Length < 11)
            {
                //return the following error message
                return "Phone numbers require at 11 numbers, please enter a longer number.";
            }

            return Error;
        }
    }
}