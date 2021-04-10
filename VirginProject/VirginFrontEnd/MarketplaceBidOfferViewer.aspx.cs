using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceOfferViewer : System.Web.UI.Page
    {
        //variables to store session object 
        Int32 UserID;
        Int32 ListingID;
        //create an instance of the cart 
        clsMarketplaceCart MyCart = new clsMarketplaceCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the User Id, cart ,listing id 

            UserID = Convert.ToInt32(Session["UserID"]);
            MyCart = (clsMarketplaceCart)Session["MyCart"];
            ListingID = Convert.ToInt32(Session["ListingID"]);


            if (IsPostBack == false)
            {
                //update the list box
                 //check if the listing is bids or offer
                Int32 ListingType = BidOrOffer(ListingID);
                //if offer listing 
                if (ListingType== 3) {
                    Int32 RecordCount = DisplayOffers();
                    if (RecordCount == 0)
                    {
                        lstBidOffers.Visible = false;
                        lblTitle.Text = "No Offers yet";
                    }
                    else
                    {
                        lblTitle.Text = "Offers:";
                        btnAccept.Visible = true;
                        btnDeclineOffer.Visible = true;
                    }    
                }

                // if listing for bids
                if(ListingType == 2)
                {
                    Int32 RecordCount = DisplayBids();
                    if(RecordCount== 0)
                    {
                        lstBidOffers.Visible = false;
                        lblTitle.Text = "No Bids yet";
                    }
                  
                    else
                    {
                        lblTitle.Text = "Bid History:";

                    }


                }
                // if buy it now
                if (ListingType != 3 && ListingType != 2)
                {
                    lstBidOffers.Visible = false;
                    lblError.Text = "No bids or offers available for this listing type";
                }
               //display the users data 
                DisplayUserData();
               
            }
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        private void DisplayUserData()
        { 
            //create an instance of the user collection class
            clsMarketplaceUserCollection SomeUser = new clsMarketplaceUserCollection();
            //find the record to update
            SomeUser.ThisUser.Find(UserID);
            //display the data for this record
            lblEmail.Text = SomeUser.ThisUser.Email;
        }
        private Int32 DisplayBids()
        {


            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sproc
            DB.AddParameter("@ListingID", ListingID);
            //execute the stored procedure
            DB.Execute("sproc_tblMarketplaceUserBids_FilterByListingID");

            //variables to loop through list
            Int32 RecordCount;
            Int32 Index = 0;
            Int32 tempBidID;
            decimal tempBidAmount;
            //get count of filtered list
            RecordCount = DB.Count;
            //clear the list box
            lstBidOffers.Items.Clear();
            //loop through the list adding them to the list box
            while (Index < RecordCount)
            {
                tempBidID = Convert.ToInt32(DB.DataTable.Rows[Index]["BidID"]); 
                tempBidAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["BidAmount"]);
                ListItem NewListing = new ListItem("£" +tempBidAmount , tempBidID.ToString());
                lstBidOffers.Items.Add(NewListing);
                Index++;
            }
            return RecordCount;
           
        }
        private Int32 DisplayOffers()
        {
            //first establish connection
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sproc
            DB.AddParameter("@ListingID", ListingID);
            //execute the stored procedure
            DB.Execute("sproc_tblMarketplaceUseroffers_FilterByListingID");

            //variables to loop through list
            Int32 RecordCount;
            Int32 Index = 0;
            Int32 tempOfferID;
            decimal tempOfferAmount;
            Int32 tempStatus;
            //get count of filtered list
            RecordCount = DB.Count;
            //clear the list box
            lstBidOffers.Items.Clear();
            //loop through the list adding them to the list box
            while (Index < RecordCount)
            {
                tempOfferID = Convert.ToInt32(DB.DataTable.Rows[Index]["OfferID"]);
                tempOfferAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["OfferAmount"]);
                tempStatus = Convert.ToInt32(DB.DataTable.Rows[Index]["Status"]);
                ListItem NewListing = new ListItem("£" + tempOfferAmount, tempOfferID.ToString());
                //check if offer already accepted   
                if (tempStatus == 1)
                {
                    lstBidOffers.Items.Add(NewListing);
                }
                if(tempStatus == 2)
                {
                    btnAccept.Visible = false;
                    btnDeclineOffer.Visible = false;
                    lstBidOffers.Visible = false;
                    lblTitle.Visible = false;
                    lblError.Text = "A previous offer has already been accepted";
                }       
                Index++;
            }
            return RecordCount;
        }

        public Int32 BidOrOffer(Int32 ListingID)
        {
         
            //create an instance of the user collection class
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
            //find the record to update
            SomeListing.ThisListing.Find(ListingID);
            Int32 listingtype = SomeListing.ThisListing.ListingType;
            return listingtype;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceUserProfile.aspx");
        }

        protected void btnDeclineOffer_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to delete
            Int32 OfferID;
            bool Accepted = false;
            //check if a record has been selected from the list
            if (lstBidOffers.SelectedIndex != -1)
            {
                //get primary key from selected
                OfferID = Convert.ToInt32(lstBidOffers.SelectedValue);
                //store data in session object so we can pass it to next page
                Session["OfferID"] = OfferID;
                Session["Accepted"] = Accepted;
                //then go to listing page
                Response.Redirect("MarketplaceOfferReply.aspx");
            }
            //if a record hasnt been selected from the listbox 
            else
            {
                //display a error .
                lblError.Text = "Please select a record  from the list ";
            }
        }



        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceHome2.aspx");
        }

        protected void btnMyAccount_Click(object sender, EventArgs e)
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

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to delete
            Int32 OfferID;
            bool Accepted = true;
            //check if a record has been selected from the list
            if (lstBidOffers.SelectedIndex != -1)
            {
                //get primary key from selected
                OfferID = Convert.ToInt32(lstBidOffers.SelectedValue);
                //store data in session object so we can pass it to next page
                Session["OfferID"] = OfferID;
                Session["Accepted"] = Accepted;
                //then go to listing page
                Response.Redirect("MarketplaceOfferReply.aspx");


            }
            //if a record hasnt been selected from the listbox 
            else
            {
                //display a error .
                lblError.Text = "Please select a record  from the list ";
            }
        }
    }
  
    
}

