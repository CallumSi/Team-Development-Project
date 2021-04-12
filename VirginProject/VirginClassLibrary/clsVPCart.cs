using System;

namespace VirginClassLibrary
{
    public class clsVPCart
    {
        //private data for the CartNo property 
        private Int32 mCartNo;
        //Cart Attributes
        String mProducts;

        //CartNo Property
        public int CartNo

        {
            get
            {
                //return the private data 
                return mCartNo;
            }
                
           set
            {
                //set the private data 
                mCartNo = value;
            }


        }

        //Products Property 
        public string Products

        {
            get
            {
                //return the private data 
                return mProducts;

            }
                
          set
            {
                //set the private data 
                mProducts = value; 
            }

        }


        public bool Find(int CartNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StaffID to search
            DB.AddParameter("@CartNo", CartNo);
            //execute the stored procedure 
            DB.Execute("sproc_tblVPCart_FilterByCartNo");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                CartNo = Convert.ToInt32(DB.DataTable.Rows[0]["CartNo"]);
                Products = Convert.ToString(DB.DataTable.Rows[0]["Products"]);
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






        public string Valid(string Products)
        {
            string Error = "";

            //***VALIDATION PRODUCTS***//

            //record the error
            if (Products.Length == 1)
            {
                //record the error 
                Error = Error + "THE PRODUCTS MUST BE MORE THAN 1 CHARACTER" + "";
            }

            //record the error message
            if (Products.Length < 2 | Products.Length > 50)
            {
                //record the error
                Error = Error + "THE PRODUCT MUST BEEN BETWEEN 2 AND 50 CHARACTERS" + "";
            }

            return Error;
        }
    }
}