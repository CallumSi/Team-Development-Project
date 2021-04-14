using System;

namespace VirginClassLibrary
{
    public class clsVPOrder
    {

        //private data member for OrderID property
        private Int32 mOrder_ID;
        //Order Attributes
        Int32 mCustomer_ID;
        DateTime mDelivery_Date;

        //public void ProcessCart (clsVPOrder ShoppingCart)
        //{
        //    ///at this point all the data has been captured by the presentation layer
        //    ///this is the stage where all of the data is passed to the data layer via the two stored procedures like so
        //    ///

        //    //first we add the order to the database using data from the cart's private data member s
        //    //connect to the database
        //    clsDataConnection DB = new clsDataConnection();
        //    //pass the data as parameters to the data layer
        //    DB.AddParameter(Delivery_Date, DateTime.Now);
        //    DB.AddParameter()
        //}




        public int Order_ID

        {
            get
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
        public int Customer_ID

        {
            get
            {
                //return the private data
                return mCustomer_ID;
            }
                set
            {
                //set the private data 
                mCustomer_ID = value;
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
                //set the private 
                mDelivery_Date = value; 
            }
                
                }

        
        public bool Find(int Order_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StaffID to search
            DB.AddParameter("@Order_ID", Order_ID);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPOrder_FilterByOrderID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                Order_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_ID"]);
                Customer_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer_ID"]);
                Delivery_Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Delivery_Date"]);
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

        
        public string Valid(string Delivery_Date)
        {
            string Error = "";

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

            return Error;
        }
    }
}