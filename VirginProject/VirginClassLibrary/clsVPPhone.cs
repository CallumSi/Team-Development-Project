using System;

namespace VirginClassLibrary
{
    public class clsVPPhone
    {
        //private data member for PhoneID property 
        private Int32 mPhoneID;
        //Phone Attributes
        String mCapacity;
        String mColour;
        String mDescription;
        String mMake;
        String mModel;
        Decimal mPrice;
        Boolean mStockStatus;

        
        //Phone Capacity Property
        public string Capacity

        {
            get
            {
                //return the private data 
                return mCapacity;
            }
                
          set
            {
                //set the private data
                mCapacity = value;
            }


        }

        //Phone Colour Property
        public string Colour

        {
            get
            {
                //return the private data 
                return mColour;
            }
                
           set
            {
                //set the private data
                mColour = value;
            }


        }

        //Phone Description Property
        public string Description

        {
            get
            {
                //return the private data 
                return mDescription; 
            }

            set
            {
                //set the private data
                mDescription = value;
            }
                }

        //Phone Make Property
        public string Make

        {
            get
            {
                //return the private data
                return mMake;
            }
            set
            {
                //set the private data
                mMake = value;
            }

        }

        //Phone Model Property
        public string Model

        {
            get
            {
                //return the private data
                return mModel;
            }

            set
            {
                //set the private data
                mModel = value;
            }
        }

        //Phone Price Property
        public decimal Price

        {
           get
            {
                //return the private data
                return mPrice;
            }
           set
            {
                //set the private data
                mPrice = value;
            }

        }

        //Phone Stock Status Property
        public bool StockStatus

        {
            get
            {
                //return the private data
                return mStockStatus;
            }

            set
            {
                //set the private data
                mStockStatus = value; 
            }

        }

        //Phone ID Property
        public int PhoneID

        {
            get
            {
                //return the private data 
                return mPhoneID;
            }

            set
            {
                //set the private data
                mPhoneID = value;
            }

        }


        public bool Find(int PhoneID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the PhoneID to search
            DB.AddParameter("@PhoneID", PhoneID);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPPhone_FilterByPhoneID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                PhoneID = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneID"]);
                Capacity = Convert.ToString(DB.DataTable.Rows[0]["Capacity"]);
                Colour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                Description = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                Make = Convert.ToString(DB.DataTable.Rows[0]["Make"]);
                Model = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                Price = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                StockStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["StockStatus"]);
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
        
        public string Valid(string Capacity, string Colour, string Description, string Make, string Model, string Price, string StockStatus)
        {
            string Error = "";

            //***VALIDATION CAPACITY***//

            //record the error
            if (Capacity.Length == 3)
            {
                //record the error 
                Error = Error + "THE CAPACITY MUST BE MORE THAN 3 CHARACTERS";
            }

            //record the error message 
            if (Capacity.Length < 4 | Capacity.Length > 5)
            {
                //record the error 
                Error = Error + "THE CAPACITY MUST BE BETWEEN 4 AND 5 CHARACTERS" + "";
            }



            //***VALIDATION COLOUR***//

            //record the error
            if (Colour.Length == 1)
            {
                //record the error 
                Error = Error + "THE COLOUR MUST BE MORE THAN 2 CHARACTERS";
            }

            //record the error message 
            if (Colour.Length < 2 | Colour.Length > 10)
            {
                //record the error 
                Error = Error + "THE COLOUR MUST BE BETWEEN 2 AND 10 CHARACTERS" + "";
            }


            //***VALIDATION DESCRIPTION***//

            //record the error
            if (Description.Length == 4)
            {
                //record the error 
                Error = Error + "THE DESCRIPTION MUST BE MORE THAN 4 CHARACTERS";
            }

            //record the error message 
            if (Description.Length < 5 | Description.Length > 50)
            {
                //record the error 
                Error = Error + "THE DESCRIPTION MUST BE BETWEEN 5 AND 50 CHARACTERS" + "";
            }



            //***VALIDATION MAKE***//

            //record the error
            if (Make.Length == 3)
            {
                //record the error 
                Error = Error + "THE MAKE MUST BE MORE THAN 3 CHARACTERS";
            }

            //record the error message 
            if (Make.Length < 4 | Make.Length > 15)
            {
                //record the error 
                Error = Error + "THE MAKE MUST BE BETWEEN 4 AND 15 CHARACTERS" + "";
            }


            //***VALIDATION MODEL***//

            //record the error
            if (Model.Length == 1)
            {
                //record the error 
                Error = Error + "THE MODEL MUST BE MORE THAN 1 CHARACTERS";
            }

            //record the error message 
            if (Model.Length < 2 | Model.Length > 30)
            {
                //record the error 
                Error = Error + "THE MODEL MUST BE BETWEEN 2 AND 30 CHARACTERS" + "";
            }



            return Error;
        }
    }
}