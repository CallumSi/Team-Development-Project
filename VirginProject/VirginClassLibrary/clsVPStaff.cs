using System;

namespace VirginClassLibrary
{
    public class clsVPStaff
    {

        //private data member for Staff_ID property 
        private Int32 mStaff_ID;
        //Staff Attributes
        String mStaff_FirstName;
        String mStaff_LastName;
        String mStaff_Street;
        String mStaff_Address;
        String mStaff_Postcode;
        String mStaff_Email;
        String mStaff_Telephone;


        //Staff First Name Property
        public string Staff_FirstName

        {

            get
            {
                //return the private data 
                return mStaff_FirstName;
            }

            set
            {
                //set the private data 
                mStaff_FirstName = value;
            }

        }

        //Staff Last Name Property
        public string Staff_LastName

        {
            get
            {
                //return the private data 
                return mStaff_LastName;
            }
            set
            {
                //set the private data
                mStaff_LastName = value;
            }

        }

        //Staff Street Property
        public string Staff_Street

        {
            get
            {
                //return the private data 
                return mStaff_Street;
            }
            set
            {
                //set the private data 
                mStaff_Street = value;
            }

        }

        //Staff Address Property
        public string Staff_Address

        {
            get
            {
                //return the private data
                return mStaff_Address;
            }
            set
            {
                //set the private data 
                mStaff_Address = value;
            }
        }

        //Staff Postcode Property
        public string Staff_Postcode

        {
            get
            {
                //return the private data 
                return mStaff_Postcode;
            }
            set
            {
                //set the private data 
                mStaff_Postcode = value;
            }
        }

        //Staff Email Property
        public string Staff_Email

        {
            get
            {
                //return the private data 
                return mStaff_Email;
            }
            set
            {
                //set the private data 
                mStaff_Email = value;
            }
        }

        //Staff Telephone Property
        public string Staff_Telephone

        {
            get
            {
                //return the private data 
                return mStaff_Telephone;
            }
            set
            {
                //set the private data 
                mStaff_Telephone = value; 
            }
        }

        //Staff ID Property
        public int Staff_ID
        {
            get
            {
                //return the private data 
                return mStaff_ID;
            }
            set
            {
                //set the private data
                mStaff_ID = value;
            }
        }


        public bool Find (int Staff_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StaffID to search
            DB.AddParameter("@Staff_ID", Staff_ID);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPStaff_FilterByStaffID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaff_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_ID"]);
                mStaff_FirstName = Convert.ToString(DB.DataTable.Rows[0]["Staff_FirstName"]);
                mStaff_LastName = Convert.ToString(DB.DataTable.Rows[0]["Staff_LastName"]);
                mStaff_Street = Convert.ToString(DB.DataTable.Rows[0]["Staff_Street"]);
                mStaff_Address = Convert.ToString(DB.DataTable.Rows[0]["Staff_Address"]);
                mStaff_Postcode = Convert.ToString(DB.DataTable.Rows[0]["Staff_Postcode"]);
                mStaff_Email = Convert.ToString(DB.DataTable.Rows[0]["Staff_Email"]);
                mStaff_Telephone = Convert.ToString(DB.DataTable.Rows[0]["Staff_Telephone"]);
                //return that everything works
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem 
                return false;
            }

        }

        

        public string Valid(string Staff_FirstName, string Staff_LastName, string Staff_Street, string Staff_Address, string Staff_Postcode, string Staff_Email, string Staff_Telephone)
        {
            string Error = "";

            //***VALIDATION FIRST NAME***//

            //record the error
            if (Staff_FirstName.Length == 1)
            {
                //record the error
                Error = Error + "THE FIRST NAME MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message
            if (Staff_FirstName.Length < 2 | Staff_FirstName.Length > 20)
            {
                //record the error 
                Error = Error + "THE FIRST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS." + "";
            }
            
            

            //***VALIDATION LAST NAME***//

            //record the error
            if (Staff_LastName.Length == 1)
            {
                //record the error
                Error = Error + "THE LAST NAME MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message
            if (Staff_LastName.Length < 2 | Staff_LastName.Length > 20)
            {
                //record the error 
                Error = Error + "THE LAST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS." + "";
            }



            //***VALIDATION STREET***//

            //record the error
            if (Staff_Street.Length == 4)
            {
                //record the error
                Error = Error + "THE STREET MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message
            if (Staff_Street.Length < 5 | Staff_Street.Length > 50)
            {
                //record the error 
                Error = Error + "THE STREET MUST BE BETWEEN 5 AND 50 CHARACTERS." + "";
            }



            //***VALIDATION ADDRESS NAME***//

            //record the error
            if (Staff_Address.Length == 4)
            {
                //record the error
                Error = Error + "THE ADDRESS MUST BE MORE THAN 4 CHARACTER." + "";
            }

            //record the error message
            if (Staff_Address.Length < 5 | Staff_Address.Length > 50)
            {
                //record the error 
                Error = Error + "THE ADDRESS MUST BE BETWEEN 5 AND 50 CHARACTERS." + "";
            }


            //***VALIDATION POSTCODE NAME***//

            //record the error
            if (Staff_Postcode.Length == 6)
            {
                //record the error
                Error = Error + "THE POSTCODE MUST BE MORE THAN 6 CHARACTERS." + "";
            }

            //record the error message
            if (Staff_Postcode.Length < 7 | Staff_Postcode.Length > 7)
            {
                //record the error 
                Error = Error + "THE POSTCODE MUST ONLY BE 7 CHARACTERS." + "";
            }


            //***VALIDATION EMAIL NAME***//

            //record the error
            if (Staff_Email.Length == 19)
            {
                //record the error
                Error = Error + "THE EMAIL MUST BE MORE THAN 19 CHARACTERS." + "";
            }

            //record the error message
            if (Staff_Email.Length < 20 | Staff_Email.Length > 50)
            {
                //record the error 
                Error = Error + "THE EMAIL MUST BE BETWEEN 20 AND 50 CHARACTERS." + "";
            }


            ////***VALIDATION TELEPHONE NAME***//

            //record the error
            if (Staff_Telephone.Length == 10)
            {
                //record the error
                Error = Error + "THE TELEPHONE MUST BE MORE THAN 10 DIGITS." + "";
            }

            //record the error message
            if (Staff_Telephone.Length < 11 | Staff_Telephone.Length > 11)
            {
                //record the error 
                Error = Error + "THE TELEPHONE MUST BE ONLY BE 11 DIGITS." + "";
            }

            return Error;

           

        }
    }
}