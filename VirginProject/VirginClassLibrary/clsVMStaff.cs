using System;

namespace VirginClassLibrary
{
    public class clsVMStaff
    {
        //Unique Customer Identifier
        //private data member for the StaffID property
        private Int32 mVMStaffID;
        //Common Customer Attributes
        String mVMstaffFirstName;
        String mVMstaffLastName;
        String mVMstaffEmail;
        String mVMstaffPassword;
        String mVMstaffPosition;

        //Public property for StaffID
        public int VMstaffID
        {
            get
            {
                //return the private data
                return mVMStaffID;
            }
            set
            {
                //set the private data
                mVMStaffID = value;
            }
        }

        //Public property for staff firstname
        public string VMstaffFirstName
        {
            get
            {
                //return the private data
                return mVMstaffFirstName;
            }
            set
            {
                //set the private data
                mVMstaffFirstName = value;
            }
        }

        //Public property for staff lastname
        public string VMstaffLastName
        {
            get
            {
                //return the private data
                return mVMstaffLastName;
            }
            set
            {
                //set the private data
                mVMstaffLastName = value;
            }
        }

        //Public property for staff email
        public string VMstaffEmail
        {
            get
            {
                //return the private data
                return mVMstaffEmail;
            }
            set
            {
                //set the private data
                mVMstaffEmail = value;
            }
        }


        //Public property for staff password
        public string VMstaffPassword
        {
            get
            {
                //return the private data
                return mVMstaffPassword;
            }
            set
            {
                //set the private data
                mVMstaffPassword = value;
            }
        }

        //mVMstaffPosition
        public string VMstaffPosition
        {
            get
            {
                //return the private data
                return mVMstaffPosition;
            }
            set
            {
                //set the private data
                mVMstaffPosition = value;
            }
        }

        public bool Find(int VMstaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@VMStaffID", VMstaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblVMStaff_FilterByVMStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mVMStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["VMStaffID"]);
                mVMstaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["VMStaffFirstName"]);
                mVMstaffLastName = Convert.ToString(DB.DataTable.Rows[0]["VMStaffLastName"]);
                mVMstaffEmail = Convert.ToString(DB.DataTable.Rows[0]["VMStaffEmail"]);
                mVMstaffPassword = Convert.ToString(DB.DataTable.Rows[0]["VMStaffPassword"]);
                mVMstaffPosition = Convert.ToString(DB.DataTable.Rows[0]["VMStaffPosition"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }


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