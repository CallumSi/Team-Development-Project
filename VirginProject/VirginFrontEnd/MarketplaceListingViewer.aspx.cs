using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceListingViewer : System.Web.UI.Page
    {
        //variable to store the ListingID and UserID from session obect
        Int32 ListingID;
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of  the listing to be procvessed
            try
            {
                ListingID = Convert.ToInt32(Request.QueryString["ListingID"]);
            }
            catch
            {
                ListingID = Convert.ToInt32(Session["ListingID"]);
            }
           
            UserID = Convert.ToInt32(Session["UserID"]);
            if (IsPostBack == false)
            {
                {
                    //display the requeted record
                    DisplayData();
                }
            }
        }

        void DisplayData()
        {
            //create an instance of the lisint collection class
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
            //find the record to update
            SomeListing.ThisListing.Find(ListingID);
            //display the data for this record
            lblListingName.Text = SomeListing.ThisListing.ListingName;
            lblCategory.Text = SomeListing.ThisListing.Category;
            if (SomeListing.ThisListing.New == true)
            {
                lblCondition.Text = "New";
            }
            else
            {
                lblCondition.Text = "Used";

            }
            DateTime todaydatetime =  DateTime.Now;
            DateTime enddate = SomeListing.ThisListing.CloseDate;
            TimeSpan difference = enddate.Subtract(todaydatetime);
            lblTimeLeft.Text = difference.ToString();
            lblPrice.Text = SomeListing.ThisListing.Price.ToString();
            lblQuantity.Text = SomeListing.ThisListing.Quantity.ToString();
            lblDeliveryType.Text = SomeListing.ThisListing.DeliveryType;
            lblDescription.Text = SomeListing.ThisListing.Description;
            imgListing.ImageUrl = SomeListing.ThisListing.Img;


            // create an instance of the user collection class
             clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
            //find the record to update
            SomeUser.ThisUser.Find(SomeListing.ThisListing.OwnerID);
            //display the data for this record
            lblSellerEmail.Text = SomeUser.ThisUser.Email;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceHome.aspx");
        }

        protected void btnClickHere_Click(object sender, EventArgs e)
        {

        }

        protected void btnMyAccount_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuyNow_Click(object sender, EventArgs e)
        {

        }

        protected void btnFavorite_Click(object sender, EventArgs e)
        {

        }
    }
}