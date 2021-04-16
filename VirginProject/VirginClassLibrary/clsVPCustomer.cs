using System;

namespace VirginClassLibrary
{
    public class clsVPCustomer
    {

        //private data member for the Customer ID property
        private Int32 mCustomer_ID;
        //Customer Attributes 
        String mCustomer_FirstName;
        String mCustomer_LastName;
        String mCustomer_Street;
        String mCustomer_Address;
        String mCustomer_Postcode;
        String mCustomer_Email;
        String mCustomer_Telephone;
        

        //Customer Address Property
        public string Customer_Address

        {
       
            get
            {
                //return the private data 
               return mCustomer_Address;
            }

            set
            {
                //set the private data
                mCustomer_Address = value;

            }

        }

        //Customer  Email Property
        public string Customer_Email

        {
            get
            {
                //return the private data
                return mCustomer_Email;
            } 
                
            set
            {
                //set the private data
                mCustomer_Email = value;
            }

        }


        //Customer First Name Property
        public string Customer_FirstName

        {
            get
            {
                //return the private data
                return mCustomer_FirstName;
            }
                
           set
            {
                //set the private data
                mCustomer_FirstName = value;
            }

        }

        //Customer Last Name Property
        public string Customer_LastName
        {

            get
            {
                //return the private data
                return mCustomer_LastName;

            }

            set
            {
                //set the private data
                mCustomer_LastName = value;
            }

        }

        //Customer Postcode Property
        public string Customer_Postcode

        {
            get
            {
                //return the private data
                return mCustomer_Postcode;

            }

            set
            {
                //set the private data
                mCustomer_Postcode = value;
            }
        }

        //Customer Street Property
        public string Customer_Street

        {
            get
            {
                //return the private data
                return mCustomer_Street;
            }

            set
            {
                mCustomer_Street = value;
            }

        }

        //Customer Telephone Property
        public string Customer_Telephone

        {

            get
            {
                //return the private data
                return mCustomer_Telephone;
            }
                
            set
            {
                mCustomer_Telephone = value;
            }

        }

        //Customer ID Property 
        public int Customer_ID

        {

            get
            {
                //return the private data
                return mCustomer_ID;
            }


            set
            {
                mCustomer_ID = value;
            }
        }



        public bool Find(int Customer_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer_ID to search
            DB.AddParameter("@Customer_ID", Customer_ID);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPCustomer_FilterByCustomerID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomer_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_ID"]);
                mCustomer_FirstName = Convert.ToString(DB.DataTable.Rows[0]["Customer_FirstName"]);
                mCustomer_LastName = Convert.ToString(DB.DataTable.Rows[0]["Customer_LastName"]);
                mCustomer_Street = Convert.ToString(DB.DataTable.Rows[0]["Customer_Street"]);
                mCustomer_Address = Convert.ToString(DB.DataTable.Rows[0]["Customer_Address"]);
                mCustomer_Postcode = Convert.ToString(DB.DataTable.Rows[0]["Customer_Postcode"]);
                mCustomer_Email = Convert.ToString(DB.DataTable.Rows[0]["Customer_Email"]);
                mCustomer_Telephone = Convert.ToString(DB.DataTable.Rows[0]["Customer_Telephone"]);
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

       

            public string Valid(string Customer_FirstName, string Customer_LastName, string Customer_Street, string Customer_Address, string Customer_Postcode, string Customer_Email, string Customer_Telephone)
        {
            string Error = "";


            //***VALIDATION FIRST NAME***//

            //record the error
            if (Customer_FirstName.Length == 1)
            {
                //record the error
                Error = Error + "THE FIRST NAME MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message  
            if (Customer_FirstName.Length < 2 | Customer_FirstName.Length > 20)
            {
                //record the error
                Error = Error + "THE FIRST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS" + " ";

            }


            //***VALIDATION LAST NAME***//

            //record the error
            if (Customer_LastName.Length == 1)
            {
                //record the error
                Error = Error + "THE LAST NAME MUST BE MORE THAN 1 CHARACTER." + " ";
            }

            //record the error message  
            if (Customer_LastName.Length < 2 | Customer_LastName.Length > 20)
            {
                //record the error
                Error = Error + "THE LAST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS" + " ";

            }


            //***VALIDATION STREET NAME***//

            //record the error
            if (Customer_Street.Length == 4)
            {
                //record the error
                Error = Error + "THE STREET MUST BE MORE THAN 4 CHARACTERS." + " ";
            }

            //record the error message  
            if (Customer_Street.Length < 5 | Customer_Street.Length > 50)
            {
                //record the error
                Error = Error + "THE STREET MUST BE BETWEEN 5 AND 50 CHARACTERS" + " ";

            }


            //***VALIDATION ADDRESS NAME***//

            //record the error
            if (Customer_Address.Length == 4)
            {
                //record the error
                Error = Error + "THE ADDRESS MUST BE MORE THAN 4 CHARACTERS." + " ";
            }

            //record the error message  
            if (Customer_Address.Length < 5 | Customer_Address.Length > 50)
            {
                //record the error
                Error = Error + "THE ADDRESS MUST BE BETWEEN 5 AND 50 CHARACTERS";

            }

            //***VALIDATION POSTCODE NAME***//

            //record the error
            if (Customer_Postcode.Length == 6)
            {
                //record the error
                Error = Error + "THE POSTCODE MUST BE MORE THAN 6 CHARACTERS." + " ";
            }

            //record the error message  
            if (Customer_Postcode.Length < 7 | Customer_Postcode.Length > 7)
            {
                //record the error
                Error = Error + "THE POSTCODE MUST ONLY BE 7 CHARACTERS" + " ";

            }


            //***VALIDATION EMAIL NAME***//

            //record the error
            if (Customer_Email.Length == 19)
            {
                //record the error
                Error = Error + "THE EMAIL MUST BE MORE THAN 19 CHARACTERS." + " ";
            }

            //record the error message  
            if (Customer_Email.Length < 20 | Customer_Email.Length > 50)
            {
                //record the error
                Error = Error + "THE EMAIL MUST BE BETWEEN 20 AND 50 CHARACTERS" + " ";

            }


            //***VALIDATION TELEPHONE NAME***//

            //record the error
            if (Customer_Telephone.Length == 10)
            {
                //record the error
                Error = Error + "THE TELEPHONE NUMBER MUST BE MORE THAN 10 DIGITS." + " ";
            }

            //record the error message  
            if (Customer_Telephone.Length < 11 | Customer_Telephone.Length > 11)
            {
                //record the error
                Error = Error + "THE TELEPHONE MUST ONLY BE 11 DIGITS" + " ";

            }

            return Error;


        }
    }
}