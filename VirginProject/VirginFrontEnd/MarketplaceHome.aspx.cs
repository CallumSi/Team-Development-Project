using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceHome : System.Web.UI.Page
    {
        int UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            //get the User Id
            UserID = Convert.ToInt32(Session["UserID"]);
            //display the User data
            DisplayUserData();
            //display the Listings
            DisplayListings();
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

        void DisplayListings()
        {
            //create an instance of the user collection class
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
            for (int i = 0; i < 7; i++)
            {

                //SomeListing.ThisListing.Find(ListingID);
                ////display the data for this record
                //lblEmail.Text = SomeUser.ThisUser.Email;

            }
                

                


        }

    }
}