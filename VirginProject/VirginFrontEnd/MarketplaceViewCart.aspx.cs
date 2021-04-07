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
        Int32 UserID;
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
            Int32 Index = 0;
            Int32 Count = MyCart.Products.Count;
            string itemname;

   
            Response.Write("Product Id");
 
            Response.Write("Quantity");
       
            if(Count == 0)
            {
               lblError.Text = ("Shopping Cart Empty");
            }
            while (Index < Count)
            {
                clsMarketplaceListing AnListing = new clsMarketplaceListing();
                AnListing.Find((MyCart.Products[Index].ProductID));
                itemname = AnListing.ListingName;
                string lstitem = itemname + " x" + (MyCart.Products[Index].QTY).ToString();
                lstShoppingCart.Items.Add(lstitem);
                Index++;
            }
        
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
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