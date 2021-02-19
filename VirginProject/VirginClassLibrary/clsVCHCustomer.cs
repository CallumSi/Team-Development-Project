using System;

namespace VirginClassLibrary
{
    public class clsVCHCustomer
    {
        //customer ID property
        public int CustomerID { get; set; }
        
        //customer First Name property
        public string FirstName { get; set; }

        //customer Last Name property
        public string LastName { get; set; }
        
        //customer Address property
        public string Address { get; set; }

        //customer Postcode property
        public string PostCode { get; set; }

        //customer Email property
        public string Email { get; set; }

        //customer Password property
        public string Password { get; set; }

        //customer Phone Number property
        public string PhoneNumber { get; set; }
        
        //Valid Method
        public string Valid(string FirstName, string LastName, string Address, string PostCode, string Email, string Password, string PhoneNumber)
        {
            //string variable to store the error message
            string Error = "";
            //if the first name length is more than 30 characters
            if (FirstName.Length > 30)
            {
                //return the following error message
                return "The customers first name may not exceed 30 characters, please fill it in accordingly.";
            }
            //if the first name length is less than 2 characters
            if (FirstName.Length < 2)
            {
                //return the following error message
                return "The customers first name is too short, please fill it in accordingly.";
            }
            /*if the first name length is blank
            if (FirstName.Length == 0)
            {
                //return the following error message
                return "The customers first name may not be blank, please fill it in accordingly.";
            }*/

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the last name length is more than 30 characters
            if (LastName.Length > 30)
            {
                //return the following error message
                return "The customers last name may not exceed 30 characters, please fill it in accordingly.";
            }
            //if the last name length is less than 2 characters 
            if (LastName.Length < 2)
            {
                //return the following error message
                return "The customers last name is too short, please fill it in accordingly.";
            }
            /*if the last name length is blank
            if (LastName.Length == 0)
            {
                //return the following error message
                return "The customers last name may not be blank, please fill it in accordingly.";
            }*/

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the address length is more than 50 characters
            if (Address.Length > 50)
            {
                //return the following error message
                return "An address may not exceed 50 characters, please fill it in accordingly.";
            }
            //if the address length is less than 3 characters 
            if (Address.Length < 3)
            {
                //return the following error message
                return "An address may not be blank, please fill it in accordingly.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the post code length is more than 10 characters
            if (PostCode.Length > 10)
            {
                //return the following error message
                return "Postcodes cannot exceed 10 characters, please fill it in accordingly.";
            }
            //if the post code length is less than 5 characters 
            if (PostCode.Length < 5)
            {
                //return the following error message
                return "Postcodes cannot have less than 5 characters, please fill it in accordingly.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the Email length is more than 50 characters
            if (Email.Length > 50)
            {
                //return the following error message
                return "An Email address cannot exceed 50 characters, please fill it in accordingly.";
            }
            //if the Email length is less than 7 characters 
            if (Email.Length < 7)
            {
                //return the following error message
                return "An Email address cannot have less than 7 characters, please fill it in accordingly.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the Password length is more than 20 characters
            if (Password.Length > 20)
            {
                //return the following error message
                return "Passwords may not exceed 20 characters, please fill it in accordingly.";
            }
            //if the Password length is less than 6 characters 
            if (Password.Length < 6)
            {
                //return the following error message
                return "Passwords cannot have less than 6 characters, please fill it in accordingly.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the PhoneNumber length is more than 12 characters
            if (PhoneNumber.Length > 12)
            {
                //return the following error message
                return "Phone numbers may not exceed 12 characters, please fill it in accordingly.";
            }
            //if the PhoneNumber length is less than 11 characters 
            if (PhoneNumber.Length < 11)
            {
                //return the following error message
                return "Phone numbers cannot have less than 11 characters, please fill it in accordingly.";
            }

            return Error;
        }
    }
}