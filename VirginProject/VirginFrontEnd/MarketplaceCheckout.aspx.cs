using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;
namespace VirginFrontEnd
{
    public partial class MarketplaceCheckout : System.Web.UI.Page
    {
        Int32 UserID;
        clsMarketplaceCart MyCart = new clsMarketplaceCart();

        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsMarketplaceCart)Session["MyCart"];
            //get the User Id
            UserID = Convert.ToInt32(Session["UserID"]);

        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            //test to see that card details are entered
            if (txtCardNo.Text != "")
            {
                //save the card no
                MyCart.CardNo = txtCardNo.Text;
                //call checkout function 
                MyCart.Checkout();
                //redirect to thankyou page
                Response.Redirect("MarketplaceThanks.aspx");
            }
            else
            {
                lblError.Text = "Payment details not valid";
            }
        }

        protected void btnClickHere_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["ListingID"] = -1;
            Session["UserID"] = UserID;
            //redirect to user data entry page
            Response.Redirect("MarketplaceListingType.aspx");
        }

        protected void btnMyAccount_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceUserProfile.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceHome2.aspx");
        }
    }
}