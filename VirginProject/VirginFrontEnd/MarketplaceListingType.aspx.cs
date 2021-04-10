using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceListingType : System.Web.UI.Page
    {
        //var for ListingId and User id
        Int32 ListingID;
        Int32 UserID;
        //create an isntance of the cart 
        clsMarketplaceCart MyCart = new clsMarketplaceCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieve the listingid, userid and cart from session object
            MyCart = (clsMarketplaceCart)Session["MyCart"];
            UserID = Convert.ToInt32(Session["UserID"]);
            ListingID = Convert.ToInt32(Session["ListingID"]);
            if (IsPostBack == false)
            {
                {
                    //display the users data 
                    DisplayUserData();

                }
            }
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        void DisplayUserData()
        {
            //create an instance of the user collection class
            clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
            //find the record to update
            SomeUser.ThisUser.Find(UserID);
            //display the data for this record
            lblEmail.Text = SomeUser.ThisUser.Email;


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


        protected void btnInstantSale_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["ListingID"] = -1;
            Session["UserID"] = UserID;
            Session["ListingType"] = 1;
            //redirect to user data entry page
            Response.Redirect("AnMarketplaceListing.aspx");
        }

        protected void btnAuction_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["ListingID"] = -1;
            Session["UserID"] = UserID;
            Session["ListingType"] = 2;
            //redirect to user data entry page
            Response.Redirect("AnMarketplaceListing.aspx");
        }

        protected void btnBestOffer_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["ListingID"] = -1;
            Session["UserID"] = UserID;
            Session["ListingType"] = 3;
            //redirect to user data entry page
            Response.Redirect("AnMarketplaceListing.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("Marketplacehome2.aspx");
        }
    }
}