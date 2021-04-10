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
        //var to store the highest buidder
        decimal highestbid;
        clsMarketplaceCart MyCart = new clsMarketplaceCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the users id  and listing id  and cart from session object 
            UserID = Convert.ToInt32(Session["UserID"]);
            ListingID = Convert.ToInt32(Request.QueryString["ListingID"]);
            MyCart = (clsMarketplaceCart)Session["MyCart"];
           

            if (IsPostBack == false)
            {
                {
                    //display the requeted record and user 
                    DisplayUserData();
                    DisplayData();
                }
            }

            
        }
     
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        void DisplayData()
        {
            //create an instance of the lisint collection class
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
            //find the record to display
            SomeListing.ThisListing.Find(ListingID);
            //display the data for this record
            lblListingName.Text = SomeListing.ThisListing.ListingName;
            lblCategory.Text = SomeListing.ThisListing.Category;
            //check if the lising is new
            if (SomeListing.ThisListing.New == true)
            {
                lblCondition.Text = "New";
            }
            else
            {
                lblCondition.Text = "Used";

            }

                //find the time difference 
                DateTime todaydatetime =  DateTime.Now;
                DateTime enddate = SomeListing.ThisListing.CloseDate;
                TimeSpan difference = enddate.Subtract(todaydatetime);
                //display the listings details 
                lblTimeLeft.Text = string.Format("{0} days, {1} hours, {2} minutes, {3} seconds", difference.Days, difference.Hours, difference.Minutes, difference.Seconds);
                lblPrice.Text = SomeListing.ThisListing.Price.ToString();
                lblQuantity.Text = SomeListing.ThisListing.Quantity.ToString();
                lblDeliveryType.Text = SomeListing.ThisListing.DeliveryType;
                lblDescription.Text = SomeListing.ThisListing.Description;
                imgListing.ImageUrl = SomeListing.ThisListing.Img;

                //displayes that are based on listing types 
                if (SomeListing.ThisListing.ListingType == 1)
                {
                    btnAddToCart.Visible = true;
                    lblQuant.Visible = true;
                    txtQTY.Visible = true;
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

                //indicate who created the listing 
                // create an instance of the user collection class
                clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
                //find the record to update
                SomeUser.ThisUser.Find(SomeListing.ThisListing.OwnerID);
                //display the data for this record
                lblSellerEmail.Text = SomeUser.ThisUser.Email;

                //check to see if the logged in user has favorited the listing 
                CheckForFavorite();
                //if need be indicate the listing has ended 
                if (enddate < todaydatetime)
                {
                    lblTimeLeft.Text = "Listing Ended";
                    btnFavorite.Visible = false;
                    btnUnFavorite.Visible = false;
                }
        }

        //display highest bid for the listing 
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
                //loop through the list to find highest bid
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
            //add to users list of favourites 
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
            //used to add a bid if the bid amount is higer that the existing bid
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
         
            try
            {
                decimal temphighestbid = 0;
                decimal tempbid = Convert.ToDecimal(txtBid.Text);
                //check if too many decimal places
                if(Decimal.Round(tempbid, 2) == tempbid)
                {
                    if (lblBidTitle.Text != "No Bids Yet")
                    {
                        temphighestbid = Convert.ToDecimal(lblBidTitle.Text);
                    }

                    //if the bid enteered is higer than existing bid add it to the database
                    if (tempbid > Convert.ToDecimal(temphighestbid))
                    {
                        DB.AddParameter("@BidAmount", tempbid);
                        DB.AddParameter("@UserID", UserID);
                        DB.AddParameter("@ListingID", ListingID);
                        DB.AddParameter("@TimePlaced", DateTime.Now);
                        //execute the insert sproc
                        DB.Execute("sproc_tblMarketplaceUserBids_Insert");
                        lblBidPlaced.Text = "Bid Placed!";
                        lblError.Text = "";
                    }
                    else
                    {
                        //error message
                        lblError.Text = "Please enter a bid higher than :" + lblBidTitle.Text;
                    }
                }
                else
                {
                    //error message
                    lblError.Text = "Please enter a bid with 2 decimal places";
                }               
               
            }
           
            catch
            {
                //error message
                lblError.Text = "Please enter a decimal"; 
            }

            //display the new bid
            DisplayBids();
            
        }

        protected void btnOffer_Click(object sender, EventArgs e)
        {
            //used to add a new record into the database
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            //make sure offer is in correct format 
            try
            {

                decimal tempoffer = Convert.ToDecimal(txtBid.Text);
                //check if too many decimal places
                if (Decimal.Round(tempoffer, 2) == tempoffer)
                {
                    DB.AddParameter("@OfferAmount", txtBid.Text);
                    DB.AddParameter("@UserID", UserID);
                    DB.AddParameter("@ListingID", ListingID);
                    DB.AddParameter("@Status", 1);
                    DB.AddParameter("@TimePlaced", DateTime.Now);
                    //execute the insert sproc
                    DB.Execute("sproc_tblMarketplaceUserOffers_Insert");
                    //inidicate offer placed
                    lblOfferPlaced.Text = "Offer Placed !";
                }
                else
                {
                    //error message
                    lblError.Text = "Please enter a offer with 2 decimal places;";
                }
            }
            catch
            {
                //error message
                lblError.Text = "Please enter a decimal";
            }
            DisplayBids();
           
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            //create a new instance of clsCartItem
            clsMarketplaceCartItem AnItem = new clsMarketplaceCartItem();
            //set the product id
            AnItem.ProductID = ListingID;
            //set the quantity
            try
            {
                Int32 listingquantity = Convert.ToInt32(lblQuantity.Text);
                Int32 yourquantity = Convert.ToInt32(txtQTY.Text);

                if ( yourquantity <= listingquantity && yourquantity > 0)
                {
                    AnItem.QTY = Convert.ToInt32(txtQTY.Text);
                    //add the item to the cart's products collection
                    MyCart.Products.Add(AnItem);
                    //go back to shopping
                    Response.Redirect("MarketplaceHome2.aspx");
                }
                else
                {
                    //error message
                    lblError.Text = "Please enter a valid quantity";
                }
                
            }
            catch
            {
                //error message
                lblError.Text = "Please enter a integer";
            }
            
        }
    }
}