using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;
namespace VirginFrontEnd
{
    public partial class MarketplaceOfferReply : System.Web.UI.Page
    {

        //create some variables to store offer id and user id 
        Int32 UserID;
        Int32 OfferID;

        //create an instance of the cart 
        clsMarketplaceCart MyCart = new clsMarketplaceCart();


        protected void Page_Load(object sender, EventArgs e)
        {

            //see if the offer was accepted or not 
            bool Accepted = Convert.ToBoolean(Session["Accepted"]);
            //get the cart 
            MyCart = (clsMarketplaceCart)Session["MyCart"];
            //get the User Id
            UserID = Convert.ToInt32(Session["UserID"]);
            //get the offer ID
            OfferID = Convert.ToInt32(Session["OfferID"]);

            //based on if the offer is accepted call the correct methods
            if (Accepted == true)
            {
                lblAccepted.Text = "Accepted";
                AcceptOffer(OfferID);
            }
            else
            {
                lblAccepted.Text = "Offer Declined";
                DeclineOffer(OfferID);
            }



        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
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

        protected void btnhome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceHome2.aspx");
        }


        public void AcceptOffer(int OfferID)
        {
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@OfferID", OfferID);
            DB.AddParameter("@Status", 2);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceUserOffers_Update");

        }

        public void DeclineOffer(int OfferID)
        {

            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@OfferID", OfferID);
            DB.AddParameter("@Status", 3);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceUserOffers_Update");
        }
    }
}