using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VirginClassLibrary
{
    public class clsVPCart
    {

        //initialise a list of products
        List<clsVPCartItem> mProducts = new List<clsVPCartItem>();

        //create some getters/ setters
        private Int32 mUserNo;
        public Int32 UserNo
        {
            get
            {
                return mUserNo;
            }
            set
            {
                mUserNo = value;
            }
        }

        
        private string mCardNo;
        public string CardNo
        {
            get
            {
                return mCardNo;
            }
            set
            {
                mCardNo = value;
            }
        }

        public List<clsVPCartItem> Products
        {
            get
            {
                return mProducts;
            }
        }

        public void Checkout()
        {
            //create an instance of the order class
            clsVPOrder Order = new clsVPOrder();
            //invoke the ProcessCart method
            Order.ProcessCart(this);
        }
            

        //        private data for the CartNo property
        //        private Int32 mCartNo;
        //        Cart Attributes
        //        String mProducts;

        //        CartNo Property
        //        public int CartNo

        //        {
        //            get
        //            {
        //                return the private data 
        //                return mCartNo;
        //            }

        //    set
        //            {
        //                set the private data
        //                mCartNo = value;
        //}


        //        }

        //        Products Property
        //        public string Products

        //{
        //    get
        //    {
        //        return the private data 
        //                return mProducts;

        //            }

        //          set
        //            {
        //                set the private data
        //                mProducts = value; 
        //            }

        //        }



        //        public bool Find(int CartNo)
        //{
        //    create an instance of the data connection
        //    clsDataConnection DB = new clsDataConnection();
        //    add the parameter for the StaffID to search

        //    DB.AddParameter("@CartNo", CartNo);
        //    execute the stored procedure
        //            DB.Execute("sproc_tblVPCart_FilterByCartNo");
        //    if one record is found
        //            if (DB.Count == 1)
        //    {
        //        copy the data from the database to the private data members
        //                CartNo = Convert.ToInt32(DB.DataTable.Rows[0]["CartNo"]);
        //                Products = Convert.ToString(DB.DataTable.Rows[0]["Products"]);
        //                return that everything works
        //                return true;
        //            }
        //            if no record was found
        //            else
        //            {
        //                return false indicating a problem 
        //                return false;
        //            }

        //        }


        //        public string Valid(string Products)
        //{
        //    string Error = "";

        //    ***VALIDATION PRODUCTS***//

        //    record the error
        //            if (Products.Length == 1)
        //    {
        //        record the error
        //        Error = Error + "THE PRODUCTS MUST BE MORE THAN 1 CHARACTER" + "";
        //    }

        //    record the error message
        //            if (Products.Length < 2 | Products.Length > 50)
        //    {
        //        record the error
        //        Error = Error + "THE PRODUCT MUST BEEN BETWEEN 2 AND 50 CHARACTERS" + "";
        //    }

        //    return Error;
        //}
    }
}

