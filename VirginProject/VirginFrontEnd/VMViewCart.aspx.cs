using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMViewCart : System.Web.UI.Page
    {
        //variable to store the CustomerID from session obect
        Int32 VMCustomerID;
        Int32 VMMovieID;
        //create an instance of the clsVMCart
        clsVMCart MyCart = new clsVMCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the customers Id
            VMCustomerID = Convert.ToInt32(Session["VMCustomerID"]);
            VMMovieID = Convert.ToInt32(Session["VMMovieID"]);
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsVMCart)Session["MyCart"];
            //display the cart contents
            DisplayCart();
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        void DisplayCart()
        {

            //cerate some variables 
            Int32 Index = 0;
            Int32 Count = MyCart.Products.Count;
            string Moviename;
            //display the movie 
            Response.Write("Movie ID");
            Response.Write("Quantity");
            //if the cart is empty tell the user
            if (Count == 0)
            {
                lblError.Text = ("Shopping Cart Empty");
            }
            //for each item in the cart
            while (Index < Count)
            {
                clsVMMovie AnMovie = new clsVMMovie();
                //find the listing 
                AnMovie.Find((MyCart.Products[Index].ProductID));
                //add the item to the list box 
                Moviename = AnMovie.VMmovieTitle;
                string lstitem = Moviename;
                lstShoppingCart.Items.Add(lstitem);
                Index++;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //take the customer back to the homepage
            Session["VMCustomerID"] = VMCustomerID;
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //take the customer to the shopping cart page
            Session["VMCustomerID"] = VMCustomerID;
            Response.Redirect("VMViewCart.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
            //take the customer back to the homepage
            Session["VMCustomerID"] = VMCustomerID;

            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnVMovieCheckout_Click(object sender, EventArgs e)
        {
            if (lstShoppingCart.Items.Count != 0)
            {
                //store data in session object so we can pass it to next page
                Session["VMCustomerID"] = VMCustomerID;
                Response.Redirect("VMCheckout.aspx");
            }
            else
            {
                lblError.Text = "Please add items to cart first in order to checkout!";
            }
        }

        protected void lstShoppingCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}