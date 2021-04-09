using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    class clsVMOrder
    {
        public void ProcessCart(clsVMCart ShoppingCart)
        {
            ///at this point all the data has been captured by the presentation layer
            ///this is the stage where all of the data is passed to the data layer via the two stored procedures like so
            ///

            //first we add the order to the database using data from the cart's private data member s
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //pass the data as parameters to the data layer
            DB.AddParameter("@MovieOrderDate", DateTime.Now.Date);
            DB.AddParameter("@CustomerID", ShoppingCart.UserNo);
            DB.AddParameter("@CardNo", ShoppingCart.CardNo);
            //execute the stored procedure capturing the primary key of the new record in the variable OrderNo
            Int32 NewOrderNo;
            NewOrderNo = DB.Execute("sproc_tblVMOrder_Insert");

            //now we need to loop through all the products adding them to the order line table
            Int32 Index = 0;
            Int32 Count = ShoppingCart.Movies.Count;
            while (Index < Count)
            {
                //reset the connection to the database
                DB = new clsDataConnection();
                DB.AddParameter("@MovieOrderID", NewOrderNo);
                DB.AddParameter("@MovieID", ShoppingCart.Movies[Index].MovieID);
                DB.AddParameter("@MovieOrderLineQuantity", ShoppingCart.Movies[Index].QTY);
                Int32 MovieOrderID = DB.Execute("sproc_tblVMOrderLine_Insert");
                Index++;
            }
            //now look in the tables and the order should be present
            //we could also do other things here such as adjust stock levels
        }
    }
}
