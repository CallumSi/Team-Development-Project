﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceListingList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplayListing();
            }
        }

        protected void btnApplyFilter_Click(object sender, EventArgs e)
        {
            FilterListing(txtListingName.Text);
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            FilterListing("");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["ListingID"] = -1;
            //redirect to user data entry page
            Response.Redirect("AnMarketplaceListing.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to edit
            Int32 ListingID;
            //check if a record has been selected from the list
            if (lstMarketplaceListing.SelectedIndex != -1)
            {
                //get primary key from selected
                ListingID = Convert.ToInt32(lstMarketplaceListing.SelectedValue);
                //store data in session object so we can pass it to next page
                Session["ListingID"] = ListingID;
                //redirect to edit user details page
                Response.Redirect("AnMarketplaceListing.aspx");

            }
            //if a record hasnt been selected from the listbox 
            else
            {
                //display a error 
                lblError.Text = "Please select a record to edit from the list ";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to delete
            Int32 ListingID;
            //check if a record has been selected from the list
            if (lstMarketplaceListing.SelectedIndex != -1)
            {
                //get primary key from selected
                ListingID = Convert.ToInt32(lstMarketplaceListing.SelectedValue);
                //store data in session object so we can pass it to next page
                Session["ListingID"] = ListingID;
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
            lstMarketplaceListing.DataSource = Listings.ListingList;
            //set name of primary key
            lstMarketplaceListing.DataValueField = "ListingID";
            //bind data
            lstMarketplaceListing.DataTextField = "ListingName";
            lstMarketplaceListing.DataBind();
        }


        Int32 FilterListing(string ListingNameFilter)
        {
            //declare variables
            Int32 ListingID;
            string ListingName;
            //create instance of collection class
            clsMarketplaceListingCollection ListOfListings = new clsMarketplaceListingCollection();
            ListOfListings.FilterByListingName(ListingNameFilter);
            //variables to loop through list
            Int32 RecordCount;
            Int32 Index = 0;
            //get count of filtered list
            RecordCount = ListOfListings.Count;
            //clear the list box
            lstMarketplaceListing.Items.Clear();
            //loop through the list adding them to the list box
            while (Index < RecordCount)
            {
                ListingID = ListOfListings.ListingList[Index].ListingID;
                ListingName = ListOfListings.ListingList[Index].ListingName;
                ListItem NewListing = new ListItem(ListingName + "", ListingID.ToString());
                lstMarketplaceListing.Items.Add(NewListing);
                Index++;
            }
            return RecordCount;

        }

      
    }
}