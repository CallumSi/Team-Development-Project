using System;

namespace VirginClassLibrary
{
    public class clsVPDelivery
    {

        //private data member for the DeliveryID
        private Int32 mDelivery_ID;
        //Delivery Attributes
        Int32 mOrder_ID;
        String mTitle;
        String mFirstName;
        String mLastName;
        Int32 mHouse_No;
        String mDelivery_Address;
        String mDelivery_Postcode;
        DateTime mDelivery_Date;
        public int Delivery_ID
        {
            get
            {
                //return the private data 
                return mDelivery_ID;
            } 
                
            set
            {
                //set the private data
                mDelivery_ID = value;
            }

        }
        public int Order_ID

        { get
            {
                //return the private data 
                return mOrder_ID;
            }
                
                set
            {
                //set the private data
                mOrder_ID = value;
            }
                
                }
        public string Title

        {
            get
            {
                //return the private data
                return mTitle;
            }
                set
            {
                //set the private data
                mTitle = value;
            }
        }
        public string FirstName

        {
            get
            {
                //return the private data 
                return mFirstName; 
            }
                set
            {
                mFirstName = value;
            }


        }
        public string LastName

        {
            get
            {
                //return the private data 
                return mLastName;
            }
                set
            {
                mLastName = value;
            }


        }
        public int House_No

        {
            get
            {
                //return the private data 
                return mHouse_No;
            }

            set
            {
                mHouse_No = value;
            }

        }
        public string Delivery_Address

        {
            get
            {
                //return the private data 
                return mDelivery_Address;
            } 
                set
            {
                //set the private data
                mDelivery_Address = value;
            }


        }
        public string Delivery_Postcode

        {
            get
            {
                //return the private data 
                return mDelivery_Postcode;
            }
                set
            {
                //set the private data 
                mDelivery_Postcode = value;
            }

        }
        public DateTime Delivery_Date

        {
            get
            {
                //return the private data 
                return mDelivery_Date;
            }

            set
            {
                //set the private data 
                mDelivery_Date = value;
            }
                }


        public bool Find(int Delivery_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer_ID to search
            DB.AddParameter("@Delivery_ID", Delivery_ID);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPDelivery_FilterByDeliveryID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mDelivery_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Delivery_ID"]);
                mOrder_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_ID"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mHouse_No = Convert.ToInt32(DB.DataTable.Rows[0]["House_No"]);
                mDelivery_Address = Convert.ToString(DB.DataTable.Rows[0]["Delivery_Address"]);
                mDelivery_Postcode = Convert.ToString(DB.DataTable.Rows[0]["Delivery_Postcode"]);
                mDelivery_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Delivery_Date"]);
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

        
        public string Valid(string Title, string FirstName, string LastName, string House_No, string Delivery_Address, string Delivery_Postcode, string Delivery_Date)
        {
            string Error = "";

            //// create some variable for later use
            int ConvertedHouse_No;

            //***VALIDATION TITLE***//

            //record the error
            if (Title.Length == 1)
            {
                //record the error
                Error = Error + "THE TITLE MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message  
            if (Title.Length < 2 | Title.Length > 10)
            {
                //record the error
                Error = Error + " THE TITLE MUST BE BETWEEN 2 AND 10 CHARACTERS" + " ";

            }


            //***VALIDATION FIRST NAME***//

            //record the error
            if (FirstName.Length == 1)
            {
                //record the error
                Error = Error + "THE FIRST NAME MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message  
            if (FirstName.Length < 2 | FirstName.Length > 20)
            {
                //record the error
                Error = Error + " THE FIRST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS" + " ";

            }


            //***VALIDATION LAST NAME***//

            //record the error
            if (LastName.Length == 1)
            {
                //record the error
                Error = Error + "THE LAST NAME MUST BE MORE THAN 1 CHARACTER." + "";
            }

            //record the error message  
            if (LastName.Length < 2 | LastName.Length > 20)
            {
                //record the error
                Error = Error + " THE LAST NAME MUST BE BETWEEN 2 AND 20 CHARACTERS" + " ";

            }


            //***VALIDATION DELIVERY ADDRESS***//

            //record the error
            if (Delivery_Address.Length == 4)
            {
                //record the error
                Error = Error + "THE DELIVERY ADDRESS MUST BE MORE THAN 4 CHARACTER." + "";
            }

            //record the error message  
            if (Delivery_Address.Length < 5 | Delivery_Address.Length > 50)
            {
                //record the error
                Error = Error + " THE DELIVERY ADDRESS MUST BE BETWEEN 5 AND 50 CHARACTERS" + " ";

            }


            //***VALIDATION DELIVERY POSTCODE***//

            //record the error
            if (Delivery_Postcode.Length == 6)
            {
                //record the error
                Error = Error + "THE POSTCODE MUST BE MORE THAN 6 CHARACTER." + "";
            }

            //record the error message  
            if (Delivery_Postcode.Length < 7 | Delivery_Postcode.Length > 7)
            {
                //record the error
                Error = Error + " THE POSTCODE MUST ONLY BE 7 CHARACTERS" + " ";

            }


            //***VALIDATION DELIVERY DATE***//

            DateTime DateTemp;

            try
            {
                //copy the delivery date value to the datetemp variable
                DateTemp = Convert.ToDateTime(Delivery_Date);

                //check to see if the delivery date is less than 100 years
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error 
                    Error = Error + "THE DELIVERY DATE CAN'T BE IN THE PAST, ENTER A VALID DATE" + " ";
                }

                //check to see if the delivery date is more than 100 years
                if (DateTemp > DateTime.Now.Date.AddYears(100))
                {
                    //record the error
                    Error = Error + "ENTER A VALID DELIVERY DATE" + " ";

                }
            }

            catch
            {
                //record the error
                Error = Error + "THE DATE IS NOT A VALID DATE";

            }

            //***VALIDATION HOUSE_NO***//

            try
            {
                if (House_No == "")
                {
                    Error += "PLEASE ENTER A HOUSENO";
                }
                else
                {
                    ConvertedHouse_No = Convert.ToInt32(House_No);
                    if (ConvertedHouse_No > 0 && ConvertedHouse_No < 1001)
                    {
                        Error += "";
                    }
                    else
                    {
                        //return error message 
                        Error += "THE HOUSENO MUST BE BETWEEN 1 AND 1000 ";
                    }
                }
            }
            catch
            {
                //return error message 
                Error += "THE HOUSENO MUST NOT BE LEFT BLANK";

            }


            return Error;
        }
    }
}