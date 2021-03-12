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

        //customer Username property
        public string Username { get; set; }

        //customer Email property
        public string Email { get; set; }

        //customer Password property
        public string Password { get; set; }

        //customer Phone Number property
        public string PhoneNumber { get; set; }
        
        //Valid Method
        public string Valid(string FirstName, string LastName, string Address, string PostCode, string Username, string Email, string Password, string PhoneNumber)
        {
            //string variable to store the error message
            string Error = "";
            //if the first name length is blank
            if (FirstName.Length == 0)
            {
                //return the following error message
                return "The customers first name may not be blank. Please enter a First Name.";
            }
            //if the first name length is more than 30 characters
            if (FirstName.Length > 30)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a shorter name.";
            }
            //if the first name length is less than 2 characters
            if (FirstName.Length < 2)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a longer name.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the last name length is blank
            if (LastName.Length == 0)
            {
                //return the following error message
                return "The customers last name may not be blank. Please enter a Last Name.";
            }
            //if the last name length is more than 30 characters
            if (LastName.Length > 30)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a shorter name.";
            }
            //if the last name length is less than 2 characters 
            if (LastName.Length < 2)
            {
                //return the following error message
                return "The name entered is not acceptable. Please try again with a longer name.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the address length is blank
            if (Address.Length == 0)
            {
                //return the following error message
                return "The address may not be blank. Please enter an address.";
            }
            //if the address length is more than 50 characters
            if (Address.Length > 50)
            {
                //return the following error message
                return "The address entered holds too many characters. Please enter a shorter address and do not include a postcode.";
            }
            //if the address length is less than 3 characters 
            if (Address.Length < 3)
            {
                //return the following error message
                return "The address entered is too short. Please enter a longer address and do not include a postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the postcode length is blank
            if (PostCode.Length == 0)
            {
                //return the following error message
                return "The postcode may not be blank. Please enter a postcode.";
            }
            //if the post code length is more than 10 characters
            if (PostCode.Length > 10)
            {
                //return the following error message
                return "The postcode entered holds too many characters. Please enter a shorter postcode.";
            }
            //if the post code length is less than 5 characters 
            if (PostCode.Length < 5)
            {
                //return the following error message
                return "The postcode entered is too short. Please enter a longer postcode.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the username length is blank
            if (Username.Length == 0)
            {
                //return the following error message
                return "The Username may not be blank. Please enter a Username.";
            }
            //if the username length is more than 30 characters
            if (Username.Length > 30)
            {
                //return the following error message
                return "Usernames may not exceed 30 characters, please enter a shorter username.";
            }
            //if the username length is less than 2 characters
            if (Username.Length < 2)
            {
                //return the following error message
                return "Usernames require at least 2 characters, please enter a longer username.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the Email length is blank
            if (Email.Length == 0)
            {
                //return the following error message
                return "The Email address may not be blank. Please enter an Email address.";
            }
            //if the Email length is more than 50 characters
            if (Email.Length > 50)
            {
                //return the following error message
                return "Email addresses cannot exceed 50 characters, please enter a shorter email address.";
            }
            //if the Email length is less than 7 characters 
            if (Email.Length < 7)
            {
                //return the following error message
                return "Email addresses require at least 7 characters, please enter a longer email address.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the Password length is blank
            if (Password.Length == 0)
            {
                //return the following error message
                return "The Password may not be blank. Please enter a Password.";
            }
            //if the Password length is more than 20 characters
            if (Password.Length > 20)
            {
                //return the following error message
                return "Passwords may not exceed 20 characters, please enter a shorter password.";
            }
            //if the Password length is less than 6 characters 
            if (Password.Length < 6)
            {
                //return the following error message
                return "Passwords require at least 6 characters, please enter a longer password.";
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //if the Phone number length is blank
            if (PhoneNumber.Length == 0)
            {
                //return the following error message
                return "The Phone number may not be blank. Please enter a Phone number.";
            }
            //if the PhoneNumber length is more than 11 characters
            if (PhoneNumber.Length > 11)
            {
                //return the following error message
                return "Phone numbers may not exceed 11 numbers, please enter a shorter number.";
            }
            //if the PhoneNumber length is less than 11 characters 
            if (PhoneNumber.Length < 11)
            {
                //return the following error message
                return "Phone numbers require at 11 numbers, please enter a longer number.";
            }

            return Error;
        }
    }
}