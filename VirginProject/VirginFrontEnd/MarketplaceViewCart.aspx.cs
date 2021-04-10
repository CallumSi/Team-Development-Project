using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
   
    public partial class MarketplaceViewCart : System.Web.UI.Page
    {
        //variable to store the users id 
        Int32 UserID;
        //create an instance of the shopping cart
        clsMarketplaceCart MyCart = new clsMarketplaceCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the User Id
            UserID = Convert.ToInt32(Session["UserID"]);
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsMarketplaceCart)Session["MyCart"];
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
            string itemname;

            //display the id and qquantity    
            Response.Write("Product Id");
            Response.Write("Quantity");
            //if the car is empty tell the user
            if(Count == 0)
            {
               lblError.Text = ("Shopping Cart Empty");
            }
            //for each item in the cart
            while (Index < Count)
            {
                clsMarketplaceListing AnListing = new clsMarketplaceListing();
                //find the listing 
                AnListing.Find((MyCart.Products[Index].ProductID));
                //add the item to the list box 
                itemname = AnListing.ListingName;
                string lstitem = itemname + " x" + (MyCart.Products[Index].QTY).ToString();
                lstShoppingCart.Items.Add(lstitem);
                Index++;
            }
        
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
            //take the uer back to the homepage
            Session["UserID"] = UserID;
            Response.Redirect("MarketplaceHome2.aspx");
        }

        protected void btnMarketplaceCheckout_Click(object sender, EventArgs e)
        {
            if(lstShoppingCart.Items.Count != 0)
            {
                //store data in session object so we can pass it to next page
                Session["UserID"] = UserID;
                Response.Redirect("MarketplaceCheckout.aspx");
            }
            else
            {
                lblError.Text = " Please add items to cart first!";
            }
           
        }

        protected void btnhome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceHome2.aspx");
        }

        protected void btnMyAccount_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceUserProfile.aspx");
        }

        protected void btnClickHere_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["ListingID"] = -1;
            Session["UserID"] = UserID;
            //redirect to user data entry page
            Response.Redirect("MarketplaceListingType.aspx");
        }
    }
}