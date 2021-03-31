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
        decimal highestbid;
        protected void Page_Load(object sender, EventArgs e)
        {
            //check for favorite
            UserID = Convert.ToInt32(Session["UserID"]);
            
            //get the number of  the listing to be procvessed
            try
            {
                ListingID = Convert.ToInt32(Request.QueryString["ListingID"]);
            }
            catch
            {
                ListingID = Convert.ToInt32(Session["ListingID"]);
            }
           
           
            if (IsPostBack == false)
            {
                {
                    //display the requeted record
                    DisplayUserData();
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
          
                lblTimeLeft.Text = string.Format("{0} days, {1} hours, {2} minutes, {3} seconds", difference.Days, difference.Hours, difference.Minutes, difference.Seconds);
                lblPrice.Text = SomeListing.ThisListing.Price.ToString();
                lblQuantity.Text = SomeListing.ThisListing.Quantity.ToString();
                lblDeliveryType.Text = SomeListing.ThisListing.DeliveryType;
                lblDescription.Text = SomeListing.ThisListing.Description;
                imgListing.ImageUrl = SomeListing.ThisListing.Img;
                if (SomeListing.ThisListing.ListingType == 1)
                {


                    btnAddToCart.Visible = true;
                    btnBuyNow.Visible = true;
                    lblListingType.Text = "Listing Type: Instant Purchace";
                }
                if (SomeListing.ThisListing.ListingType == 2)
                {
                    lblCurrentBidTitle.Visible = true;
                    lblBidText.Visible = true;
                    txtBid.Visible = true;
                    lblBidTitle.Visible = true;
                    btnBid.Visible = true;
                    lblListingType.Text = "Listing Type: Auction";
                    DisplayBids();
                }
                if (SomeListing.ThisListing.ListingType == 3)
                {

                    txtBid.Visible = true;
                    btnOffer.Visible = true;
                    lblListingType.Text = "Listing Type: Offers";
                }


                // create an instance of the user collection class
                clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
                //find the record to update
                SomeUser.ThisUser.Find(SomeListing.ThisListing.OwnerID);
                //display the data for this record
                lblSellerEmail.Text = SomeUser.ThisUser.Email;
                CheckForFavorite();
            if (enddate < todaydatetime)
            {
                lblTimeLeft.Text = "Listing Ended";
                btnFavorite.Visible = false;
                btnUnFavorite.Visible = false;
            }

            //lblSellerEmailTitle.Visible = false;
            //lblCategoryTitle.Visible = false;
            //lblConditionTitle.Visible = false;
            //lblTimeLeftTitle.Visible = false;
            //lblDeliveryTypeTitle.Visible = false;
            //lblStartPriceTitle.Visible = false;
            //lblQuantityTitle.Visible = false;
            //lblDeliveryTypeTitle.Visible = false;
            //lblDescriptionTitle.Visible = false;
            //lblCondition.Visible = false;
            //lblListingName.Text = "Listing Ended";
            //imgListing.Visible = false;
            //lblCategory.Visible = false;


            //}

        }


        decimal DisplayBids()
        {

            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@ListingID", ListingID);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceUserBids_FilterByListingID");
            //populate the array with the found data;
            //variables to loop through list
            Int32 RecordCount;
            Int32 Index = 0;
            //get count of filtered list
            RecordCount = DB.Count;
            if (RecordCount == 0)
            {

                lblBidTitle.Text = "No Bids Yet";
            }
            else
            {
                //loop through the list adding them to the list box
               
                while (Index < RecordCount)
                {

                    decimal tempbid = Convert.ToDecimal(DB.DataTable.Rows[Index]["BidAmount"]);
                    if (tempbid > highestbid)
                    {
                        highestbid = tempbid;
                    }


                    Index++;
                }
                lblBidTitle.Text = highestbid.ToString();
            }
            return highestbid;
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
        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceHome2.aspx");
        }

        protected void btnClickHere_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["ListingID"] = -1;
            Session["UserID"] = UserID;
            //redirect to user data entry page
            Response.Redirect("AnMarketplaceListing.aspx");
        }

        protected void btnMyAccount_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceUserProfile.aspx");
        }



        protected void btnBuyNow_Click(object sender, EventArgs e)
        {

        }

        protected void btnFavorite_Click(object sender, EventArgs e)
        {
            AddFavorite();
            
        }

        public int AddFavorite()
        {
            lblFavorite.Text = "Favorited!";
            //used to add a new record into the database
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@FavoritedBy", UserID);
            DB.AddParameter("@ListingID",ListingID);
            //execute the insert sproc
            return DB.Execute("sproc_tblMarketplaceUserFavorites_Insert");
            

        }

        void CheckForFavorite()
        {

            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@UserID", UserID);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceUserFavorites_FilterByUserID");
            //populate the array with the found data;
            //variables to loop through list
            Int32 RecordCount;
            Int32 Index = 0;
            //get count of filtered list
            RecordCount = DB.Count;
            if (RecordCount == 0)
            {

                lblFavorite.Text = "Not Yet Favorited!";
            }
            else
            {
                //loop through the list adding them to the list box
                while (Index < RecordCount)
                {
                    int tempListingID = Convert.ToInt32(DB.DataTable.Rows[Index]["ListingID"]);
                    if (ListingID == tempListingID)
                    {
                        lblFavorite.Text = "Watching!";
                    }
       
                    Index++;
                }
            }
            

        }



        protected void btnUnFavorite_Click(object sender, EventArgs e)
        {
                if(lblFavorite.Text!= "No longer Watching")
            {
                //call the funciton to delete the recrod
                DeleteFavorite(ListingID);


                lblFavorite.Text = "No longer Watching";

            }

              

        }

            private void DeleteFavorite(int ListingID)
            {
                //function for deleting records

                //first establish connection
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the sproc
                DB.AddParameter("@ListingID", ListingID);
                DB.AddParameter("@UserID", UserID);
                //execute the stored procedure
                DB.Execute("sproc_tblMarketplaceListingFavorite_Delete");
            }

        protected void btnBid_Click(object sender, EventArgs e)
        {
            //used to add a new record into the database
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
         
            try
            {
                decimal temphighestbid = 0;
                decimal tempbid = Convert.ToDecimal(txtBid.Text);
                if(lblBidTitle.Text != "No Bids Yet")
                {
                    temphighestbid = Convert.ToDecimal(lblBidTitle.Text);
                }
                if (tempbid > Convert.ToDecimal(temphighestbid))
                {
                    DB.AddParameter("@BidAmount", txtBid.Text);
                    DB.AddParameter("@UserID", UserID);
                    DB.AddParameter("@ListingID", ListingID);
                    DB.AddParameter("@TimePlaced", DateTime.Now);
                    //execute the insert sproc
                    DB.Execute("sproc_tblMarketplaceUserBids_Insert");
                    lblBidPlaced.Text = "Bid Placed!";
                }
                else
                {
                    lblError.Text = "Please enter a bid higher than :" + lblBidTitle.Text ;
                }
             
               
            }
            catch
            {
                lblError.Text = "Please enter a decimal"; 
            }
            DisplayBids();
            
        }

        protected void btnOffer_Click(object sender, EventArgs e)
        {
            //used to add a new record into the database
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc

            try
            {
                decimal tempoffer = Convert.ToDecimal(txtBid.Text);
               
                    DB.AddParameter("@OfferAmount", txtBid.Text);
                    DB.AddParameter("@UserID", UserID);
                    DB.AddParameter("@ListingID", ListingID);
                    DB.AddParameter("@Status", 1);
                    DB.AddParameter("@TimePlaced", DateTime.Now);
                //execute the insert sproc
                DB.Execute("sproc_tblMarketplaceUserOffers_Insert");

                 lblOfferPlaced.Text = "Offer Placed !";
            }
            catch
            {
                lblError.Text = "Please enter a decimal";
            }
            DisplayBids();
           
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}