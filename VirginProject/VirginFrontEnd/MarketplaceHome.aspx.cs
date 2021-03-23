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
        Int32 UserID;
     

        protected void Page_Load(object sender, EventArgs e)
        {
           
            //get the User Id
            UserID = Convert.ToInt32(Session["UserID"]);

           
            if (IsPostBack == false)
            {
                {
                    
                    //display the User data
                    DisplayUserData();
                    //display the Listings
                    //DisplayListings();
                
                }
            }
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

       public void DisplayListings()
        {
            //create an instance of the user collection class
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
           


        }

        Int32 FilterListing(string ListingNameFilter)
        {
            //declare variables
            Int32 ListingID;
            string ListingName;
            string ListingImg;
            string ListingPrice;
            //create instance of collection class
            clsMarketplaceListingCollection ListOfListings = new clsMarketplaceListingCollection();
            ListOfListings.FilterByListingName(ListingNameFilter);
            //variables to loop through list
            Int32 RecordCount;
            Int32 Index = 0;
            //get count of filtered list
            RecordCount = ListOfListings.Count;
   
           
            //loop through the list adding them to the list boxes
            while (Index < RecordCount )
            {
                ListingID = ListOfListings.ListingList[Index].ListingID;
                ListingName = ListOfListings.ListingList[Index].ListingName;
                ListingPrice = ListOfListings.ListingList[Index].Price.ToString();
                ListingImg = ListOfListings.ListingList[Index].Img;
                Index++;
             
              
            }
            return RecordCount;

        }

      

        protected void btnClickHere_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["ListingID"] = -1;
            Session["UserID"] = UserID;
            //redirect to user data entry page
            Response.Redirect("AnMarketplaceListing.aspx"); 
        }

       



        protected void Redirect_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["ListingID"] = 2;
            //redirect to edit user details page
            Response.Redirect("MarketplaceListingViewer.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            FilterListing(txtSearch.Text);
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
            Response.Redirect("MarketplaceHome.aspx");
        }
    }
}