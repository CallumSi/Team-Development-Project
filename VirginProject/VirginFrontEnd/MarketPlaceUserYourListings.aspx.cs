using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketPlaceUserYourListings : System.Web.UI.Page
    {
        //variable to store the users id 
        Int32 UserID;
        //create an instance of the shopping cart
        clsMarketplaceCart MyCart = new clsMarketplaceCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            MyCart = (clsMarketplaceCart)Session["MyCart"];
            //get the User Id
            UserID = Convert.ToInt32(Session["UserID"]);
            if (IsPostBack == false)
            {
                //update the list box
                DisplayListing();
                DisplayUserData();

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

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to edit
            Int32 ListingID = Convert.ToInt32(lstYourListings.SelectedValue);
            Session["UserID"] = UserID;
            //check if a record has been selected from the list
            if (lstYourListings.SelectedIndex != -1)
            {


                if (CheckForBid(ListingID) ==false && CheckForOffer(ListingID) == false)
                {
                    //get primary key from selected
                   
                    //store data in session object so we can pass it to next page
                    Session["ListingID"] = ListingID;
                    //redirect to edit user details page
                    Response.Redirect("AnMarketplaceListing.aspx");
                }
                else
                {
                    lblError.Text = "Please select a record with no  bids or offers ";
                }
              

            }
            //if a record hasnt been selected from the listbox 
            else
            {
                //display a error 
                lblError.Text = "Please select a record to edit from the list ";
            }
        }

        bool CheckForBid(Int32 ListingID)
        {

            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@ListingID", ListingID);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceUserBids_FilterByListingID");
            //populate the array with the found data;
            //variables to loop through list
            Int32 RecordCount;
           
            //get count of filtered list
            RecordCount = DB.Count;
            if (RecordCount == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }
        bool CheckForOffer(int ListingID)
        {

            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@ListingID", ListingID);
            //execute the spoc
            DB.Execute("sproc_tblMarketplaceUseroffers_FilterByListingID");
            //populate the array with the found data;
            //variables to loop through list
            Int32 RecordCount;
           
            //get count of filtered list
            RecordCount = DB.Count;
            if (RecordCount == 0)
            {

                return false;
            }
            else
            {
                return true;
            }
        }

    
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to delete
            Int32 ListingID;
            string ListingName;
            Session["UserID"] = UserID;
            //check if a record has been selected from the list
            if (lstYourListings.SelectedIndex != -1)
            {
                //get primary key from selected
                ListingID = Convert.ToInt32(lstYourListings.SelectedValue);
                ListingName = lstYourListings.SelectedItem.ToString();
                //store data in session object so we can pass it to next page
                Session["ListingID"] = ListingID;
                Session["ListingName"] = ListingName;  
                //redirect to delete page
                Response.Redirect("MarketplaceListingDelete.aspx");

            }
            //if a record hasnt been selected from the listbox 
            else
            {
                //display a error 
                lblError.Text = "Please select a record to delete from the list ";
            }
        }

        void DisplayListing()
        {
            //create an instance of the use collection
            clsMarketplaceListingCollection Listings = new clsMarketplaceListingCollection();
            lstYourListings.DataSource = Listings.ListingList;
            //set name of primary key
            lstYourListings.DataValueField = "ListingID";
            //bind data
            lstYourListings.DataTextField = "ListingName";
            lstYourListings.DataBind();
            FilterListing(UserID.ToString());
        }

        Int32 FilterListing(string UserIDFilter)
        {
            //declare variables
            Int32 ListingID;
            string ListingName;
            //create instance of collection class
            clsMarketplaceListingCollection ListOfListings = new clsMarketplaceListingCollection();
            ListOfListings.FilterByUserID(UserIDFilter);
            //variables to loop through list
            Int32 RecordCount;
            Int32 Index = 0;
            //get count of filtered list
            RecordCount = ListOfListings.Count;
            //clear the list box
            lstYourListings.Items.Clear();
            //loop through the list adding them to the list box
            while (Index < RecordCount)
            {
                ListingID = ListOfListings.ListingList[Index].ListingID;
                ListingName = ListOfListings.ListingList[Index].ListingName;
                ListItem NewListing = new ListItem(ListingName + "", ListingID.ToString());
                lstYourListings.Items.Add(NewListing);
                Index++;
            }
            return RecordCount;

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

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("MarketplaceHome2.aspx");
        }

        protected void ViewBidOffer_Click(object sender, EventArgs e)
        {
          
                //variable to store primary key of field you want to edit
                Int32 ListingID;
                Session["UserID"] = UserID;
                //check if a record has been selected from the list
                if (lstYourListings.SelectedIndex != -1)
                {
                    //get primary key from selected
                    ListingID = Convert.ToInt32(lstYourListings.SelectedValue);
                    //store data in session object so we can pass it to next page
                    Session["ListingID"] = ListingID;
                    //redirect to edit user details page
                    Response.Redirect("MarketplaceBidOfferViewer.aspx");

                }
                //if a record hasnt been selected from the listbox 
                else
                {
                    //display a error 
                    lblError.Text = "Please select a record to edit from the list ";
                }
            }
        
    }
}

