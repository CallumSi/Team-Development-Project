using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;
namespace VirginFrontEnd
{
    public partial class AnMarketplaceListing : System.Web.UI.Page
    {
        //variable to store the ListingID from session obect
        Int32 ListingID;
        Int32 OwnerID = 1;
        protected void Page_Load(object sender, EventArgs e)
        {

            //get the number of listings to be procvessed
            ListingID = Convert.ToInt32(Session["ListingID"]);
            if (IsPostBack == false)
            {
                //if not a new record 
                if (ListingID != -1)
                {
                    //display the requeted record
                    DisplayData();
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MarketplaceListingList.aspx");
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (ListingID == -1)
            {
                //add the new record
                AddListing();
            }
            else
            {
                UpdateListing();
            }
        }


        void DisplayData()
        {
            //create an instance of the user collection class
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
            //find the record to update
            SomeListing.ThisListing.Find(ListingID);
            //display the data for this record
            chkboxNew.Checked = SomeListing.ThisListing.New;
            txtDeliveryType.Text = SomeListing.ThisListing.DeliveryType;
            txtDescription.Text = SomeListing.ThisListing.Description;
            txtCategory.Text = SomeListing.ThisListing.Category;
            txtQuantity.Text = SomeListing.ThisListing.Quantity.ToString();
            txtPrice.Text = SomeListing.ThisListing.Price.ToString();
            txtImg.Text = SomeListing.ThisListing.Img;
            txtListingName.Text = SomeListing.ThisListing.ListingName;
        }

        public void UpdateListing()
        {
            //create a instance of the user collection class
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
            //ensure the data is valid by using the valid method
            string Error = "";
            Error = SomeListing.ThisListing.Valid(txtCategory.Text,txtDeliveryType.Text, txtDescription.Text, txtImg.Text, txtListingName.Text, txtPrice.Text, txtQuantity.Text);
            //if no error msg then add it to object
            if (Error == "")
            {
                //find the record to update

                SomeListing.ThisListing.Find(ListingID);

                //get the data from the form

                SomeListing.ThisListing.New = chkboxNew.Checked;
                SomeListing.ThisListing.DeliveryType = txtDeliveryType.Text;
                SomeListing.ThisListing.Description = txtDescription.Text;
                SomeListing.ThisListing.Category = txtCategory.Text;
                SomeListing.ThisListing.Quantity = Convert.ToInt32(txtQuantity.Text);
                SomeListing.ThisListing.Price = Convert.ToDecimal(txtPrice.Text);
                SomeListing.ThisListing.Img = txtImg.Text;
                SomeListing.ThisListing.ListingName = txtListingName.Text;
                SomeListing.ThisListing.OwnerID = OwnerID;
                //then update the record
                SomeListing.UpdateListing();
                //then go back to the list page
                Response.Redirect("MarketplaceListingList.aspx");

            }
            else
            {
                //report an error 
                lblError.Text += "There were problems with the data entered: " + Error;
            }
        }


        //function for adding records
        public void AddListing()
        {
            //create a instance of the user collection class
            clsMarketplaceListingCollection SomeListing = new clsMarketplaceListingCollection();
            //ensure the data is valid by using the valid method
            string Error = "";
            Error = SomeListing.ThisListing.Valid(txtCategory.Text, txtDeliveryType.Text, txtDescription.Text, txtImg.Text, txtListingName.Text, txtPrice.Text, txtQuantity.Text);
            //if no error msg then add it to object
            if (Error == "")
            {
                //get the data from the form
                SomeListing.ThisListing.New = chkboxNew.Checked;
                SomeListing.ThisListing.DeliveryType = txtDeliveryType.Text;
                SomeListing.ThisListing.Description = txtDescription.Text;
                SomeListing.ThisListing.Category = txtCategory.Text;
                SomeListing.ThisListing.Quantity = Convert.ToInt32(txtQuantity.Text);
                SomeListing.ThisListing.Price = Convert.ToDecimal(txtPrice.Text);
                SomeListing.ThisListing.Img = txtImg.Text;
                SomeListing.ThisListing.ListingName = txtListingName.Text;
                SomeListing.ThisListing.OwnerID = OwnerID;

                //then add the record
                SomeListing.AddListing();
                //then go back to the list page
                Response.Redirect("MarketplaceListingList.aspx");

            }
            else
            {
                //report an error 
                lblError.Text += "There were problems with the data entered: " + Error;
            }
        }
    }
}