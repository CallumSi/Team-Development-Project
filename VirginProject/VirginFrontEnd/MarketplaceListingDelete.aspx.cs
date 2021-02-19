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
        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieve the id from session object
            ListingID = Convert.ToInt32(Session["ListingID"]);
            lblLoad.Text = "Are you sure you want to delete usewr with the ID:" + ListingID;
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //call the funciton to delete the recrod
            DeleteListing();
            //then go back to main page
            Response.Redirect("MarketplaceListingList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //go back to main page
            Response.Redirect("MarketplaceListingList.aspx");
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
    }
}