using System;

namespace VirginClassLibrary
{
    public class clsVMStaff
    {
        public int VMstaffID { get; set; }
        public string VMstaffFirstName { get; set; }
        public string VMstaffLastName { get; set; }
        public string VMstaffEmail { get; set; }
        public string VMstaffPassword { get; set; }
        public string VMstaffPosition { get; set; }

        public string Valid(string VMstaffFirstName, string VMstaffLastName, string VMstaffEmail, string VMstaffPassword, string VMstaffPosition)
        {
            //create a string variable to store the error message
            String Error = "";

            //****************STAFF FIRSTNAME***********************// 
            //test to see if the staff firstname has zero characters
            if (VMstaffFirstName.Length == 0)
            {
                //return error message 
                Error = Error + "Staff Firstname cannot be blank!" + " ";
            }

            //if the staff firstname is less than 1 and greater than 55 characters
            if (VMstaffFirstName.Length < 1 | VMstaffFirstName.Length > 55)
            {
                //return error message 
                Error = Error + "Staff Firstname cannot be more than 55 characters" + " ";
            }

            //****************STAFF LASTNAME***********************// 
            //test to see if the staff lastname has zero characters
            if (VMstaffLastName.Length == 0)
            {
                //return error message 
                Error = Error + "Staff Lastname cannot be blank!" + " ";
            }

            //if the staff lastname is less than 1 and greater than 55 characters
            if (VMstaffLastName.Length < 1 | VMstaffLastName.Length > 55)
            {
                //return error message 
                Error = Error + "Staff Lastname cannot be more than 55 characters" + " ";
            }

            //****************STAFF EMAIL***********************// 
            //test to see if the staff email has zero characters
            if (VMstaffEmail.Length == 0)
            {
                //record the error 
                Error = Error + "Staff Email cannot be blank!" + " ";
            }
            //if the staff email is less than 1 and greater than 55 characters
            if (VMstaffEmail.Length < 11 | VMstaffEmail.Length > 55)
            {
                //set the error message 
                Error = Error + "Staff Email must be between 11 and 55 CHARACTERS!" + " ";
            }

            //****************STAFF PASSWORD***********************// 
            //test to see if the staff password has zero characters
            if (VMstaffPassword.Length == 0)
            {
                //return error message 
                Error = Error + "Staff Password cannot be blank!" + " ";
            }

            //if the staff password is less than 7 and greater than 55 characters
            if (VMstaffPassword.Length < 7 | VMstaffPassword.Length > 55)
            {
                //return error message 
                Error = Error + "Staff Password cannot be less than 7 characters and more than 55 characters" + " ";
            }

            //****************STAFF POSITION***********************// 
            //test to see if the staff position has zero characters
            if (VMstaffPosition.Length == 0)
            {
                //return error message 
                Error = Error + "Staff Position cannot be blank!" + " ";
            }

            //if the staff password is less than 7 and greater than 55 characters
            if (VMstaffPosition.Length < 5 | VMstaffPosition.Length > 55)
            {
                //return error message 
                Error = Error + "Staff Position cannot be less than 5 characters and more than 55 characters" + " ";
            }

            //return any error messages
            return Error;
        }
    }
}