using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceListingDelete : System.Web.UI.Page
    {
        //var for ListingId of record to be deleted
        Int32 ListingID;
        Int32 UserID;
        string ListingName;
        clsMarketplaceCart MyCart = new clsMarketplaceCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            MyCart = (clsMarketplaceCart)Session["MyCart"];
            UserID = Convert.ToInt32(Session["UserID"]);
            //retrieve the id from session object
            ListingID = Convert.ToInt32(Session["ListingID"]);
            ListingName = Convert.ToString(Session["ListingName"]);
            
            lblLoad.Text = "Are you sure you want to delete : " + ListingName;

            if (IsPostBack == false)
            {
                {
                    //display the requeted record
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
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //call the funciton to delete the recrod
            DeleteListing();
            //then go back to main page
            Response.Redirect("MarketplaceUserYourListings.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //go back to main page
            Response.Redirect("MarketplaceUserYourListings.aspx");
        }


        void DeleteListing()
        {
            //function for deleting records
            //create  instance of  user colleciton
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
            //find the record to delete
            SomeListing.ThisListing.Find(ListingID);
            //delete the record
            SomeListing.DeleteListing();

        }

        protected void btnMyAccount_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceUserProfile.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
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

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("Marketplacehome2.aspx");
        }
    }
}