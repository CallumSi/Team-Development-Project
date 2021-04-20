using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHAHireCE : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 CustomerID;
        //variable to store the primary key with page level scope
        Int32 CarID;
        Int32 HireID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer/user to be processed
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
            CarID = Convert.ToInt32(Session["CarID"]);
            //get the number of the car hire to be processed
            HireID = Convert.ToInt32(Session["HireID"]);
            if (IsPostBack == false)
            {
                //populate the list of car hire
                DisplayHire();
                //if this is not a new record
                if (HireID != -1)
                {
                    //display the current data for the record
                    DisplayHire();
                }
            }
        }

        //event handler for the page unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the CustomerID & UserID when a page unload event happens
            Session["CustomerID"] = CustomerID;
            Session["CarID"] = CarID;
        }

        void DisplayHire()
        {
            //create an instance of the car hire collection class
            clsVCHHireCollection HireCollection = new clsVCHHireCollection();
            //find the HireID for the record to be updated
            HireCollection.ThisHire.Find(HireID);
            //display the data for this record
            lblCarIDDisplay.Text = HireCollection.ThisHire.CarID.ToString();
            lblCustomerIDDisplay.Text = HireCollection.ThisHire.CustomerID.ToString();
            txtHireCollectionDate.Text = HireCollection.ThisHire.HireCollectionDate.ToString();
            txtHireReturnDate.Text = HireCollection.ThisHire.HireReturnDate.ToString();
            ddlHireLocation.SelectedValue = HireCollection.ThisHire.HireLocation;
            lblHireStatus.Text = HireCollection.ThisHire.HireStatus;

        }

        protected void btnHire_Click(object sender, EventArgs e)
        {
            if (HireID == -1)
            {
                //add the new hire record
                Add();
            }
        }

        //function to add new car hire records
        void Add()
        {
            //Save the CustomerID & UserID when a page unload event happens
            Session["CustomerID"] = CustomerID;
            Session["CarID"] = CarID;

            //create an instance of the car hire collection class
            clsVCHHireCollection HireCollection = new clsVCHHireCollection();
            //validate the data on the web front
            String Error = HireCollection.ThisHire.Valid(txtHireCollectionDate.Text, txtHireReturnDate.Text, ddlHireLocation.SelectedValue.ToString(), lblHireStatusDisplay.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //get the data entered by the user
                //HireCollection.ThisHire.HireID = HireID;
                HireCollection.ThisHire.CarID = CarID;
                HireCollection.ThisHire.CustomerID = CustomerID;
                HireCollection.ThisHire.HireCollectionDate = Convert.ToDateTime(txtHireCollectionDate.Text);
                HireCollection.ThisHire.HireReturnDate = Convert.ToDateTime(txtHireReturnDate.Text);
                HireCollection.ThisHire.HireLocation = Convert.ToString(ddlHireLocation.SelectedValue.ToString());
                HireCollection.ThisHire.HireStatus = "Pending Confirmation";
                //add the new car hire record
                HireCollection.Add();

                //once complete redirect the user to the customer home page
                Response.Redirect("VCHCustomerHomeCE.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect the user to the customer default page, without having hired a car
            Response.Redirect("VCHCustomerHomeCE.aspx");
            Session["CustomerID"] = CustomerID;
        }
    }
}