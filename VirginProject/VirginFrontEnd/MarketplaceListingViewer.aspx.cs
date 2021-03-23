﻿using System;
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
            CheckForFavorite();
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
}
}