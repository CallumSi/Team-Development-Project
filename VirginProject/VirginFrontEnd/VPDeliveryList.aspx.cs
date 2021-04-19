using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPDeliveryList : System.Web.UI.Page
    {
        Int32 DeliveryID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of deliveries to be processed
            DeliveryID = Convert.ToInt32(Session["DeliveryID"]);
            if (IsPostBack == false)
            {
                //populate the list of deliveries
                DisplayDelivery();
                //if this is not a new record
                if (DeliveryID !=-1)
                {
                    //display the current data for the record
                    DisplayDelivery();
                }
            }
        }

        //function for displaying customers

        void DisplayDelivery()
        {
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //find the record to update
            AllDelivery.ThisDelivery.Find(DeliveryID);
            //display the data for this record
            txtTitle.Text = AllDelivery.ThisDelivery.Title;
            txtFirstName.Text = AllDelivery.ThisDelivery.FirstName;
            txtLastName.Text = AllDelivery.ThisDelivery.LastName;
            txtHouseNo.Text = AllDelivery.ThisDelivery.House_No.ToString();
            txtAddress.Text = AllDelivery.ThisDelivery.Delivery_Address;
            //txtDeliveryDate = AllDelivery.ThisDelivery.Delivery_Date.Date
        }

        //function for adding a new delivery
        void Add()
        {
            //create an instance of the delivery list
            clsVPDeliveryCollection AllDelivery = new clsVPDeliveryCollection();
            //validate the data on the web form
            string Error = AllDelivery.ThisDelivery.Valid(txtTitle.Text, txtFirstName.Text, txtLastName.Text, txtHouseNo.Text, txtAddress.Text, txtPostcode.Text, txtDeliveryDate.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {

            }
        }

        protected void btnContinueToPayment_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPPayment.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to cart
            Response.Redirect("VPViewCart.aspx");
        }
    }
}