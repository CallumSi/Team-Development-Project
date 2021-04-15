using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHAHire : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 HireID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
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

        void DisplayHire()
        {
            //create an instance of the car hire collection class
            clsVCHHireCollection HireCollection = new clsVCHHireCollection();
            //find the HireID for the record to be updated
            HireCollection.ThisHire.Find(HireID);
            //display the data for this record
            txtCarID.Text = HireCollection.ThisHire.CarID.ToString();
            txtCustomerID.Text = HireCollection.ThisHire.CustomerID.ToString();
            txtHireCollectionDate.Text = HireCollection.ThisHire.HireCollectionDate.ToString();
            txtHireReturnDate.Text = HireCollection.ThisHire.HireReturnDate.ToString();
            ddlHireLocation.SelectedValue = HireCollection.ThisHire.HireLocation;
            txtDriverAge.Text = HireCollection.ThisHire.DriverAge.ToString();
            txtDriverLicenseNumber.Text = HireCollection.ThisHire.DriverLicenseNumber;
        }

        //function to add new car hire records
        void Add()
        {
            //create an instance of the car hire collection class
            clsVCHHireCollection HireCollection = new clsVCHHireCollection();
            //validate the data on the web front
            String Error = HireCollection.ThisHire.Valid(txtHireCollectionDate.Text, txtHireReturnDate.Text, ddlHireLocation.SelectedValue.ToString(), txtDriverAge.Text, txtDriverLicenseNumber.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //get the data entered by the user
                HireCollection.ThisHire.CarID = Convert.ToInt32(txtCarID.Text);
                HireCollection.ThisHire.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                HireCollection.ThisHire.HireCollectionDate = Convert.ToDateTime(txtHireCollectionDate.Text);
                HireCollection.ThisHire.HireReturnDate = Convert.ToDateTime(txtHireReturnDate.Text);
                HireCollection.ThisHire.HireLocation = Convert.ToString(ddlHireLocation.SelectedValue.ToString());
                HireCollection.ThisHire.DriverAge = Convert.ToInt32(txtDriverAge.Text);
                HireCollection.ThisHire.DriverLicenseNumber = txtDriverLicenseNumber.Text;
                //add the new car hire record
                HireCollection.Add();

                //once complete redirect the user to the car hire list page
                Response.Redirect("VCHHireList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
        }

        //function to update existing car hire records
        void Update()
        {
            //create an instance of the car hire collection class
            clsVCHHireCollection HireCollection = new clsVCHHireCollection();
            //validate the data on the web front
            String Error = HireCollection.ThisHire.Valid(txtHireCollectionDate.Text, txtHireReturnDate.Text, ddlHireLocation.SelectedValue.ToString(), txtDriverAge.Text, txtDriverLicenseNumber.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //find the record to update/edit
                HireCollection.ThisHire.Find(HireID);
                //get the data entered by the user
                HireCollection.ThisHire.CarID = Convert.ToInt32(txtCarID.Text);
                HireCollection.ThisHire.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                HireCollection.ThisHire.HireCollectionDate = Convert.ToDateTime(txtHireCollectionDate.Text);
                HireCollection.ThisHire.HireReturnDate = Convert.ToDateTime(txtHireReturnDate.Text);
                HireCollection.ThisHire.HireLocation = Convert.ToString(ddlHireLocation.SelectedValue.ToString());
                HireCollection.ThisHire.DriverAge = Convert.ToInt32(txtDriverAge.Text);
                HireCollection.ThisHire.DriverLicenseNumber = txtDriverLicenseNumber.Text;
                //update the existing car hire record
                HireCollection.Update();

                //once complete redirect the user to the car hire list page
                Response.Redirect("VCHHireList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (HireID == -1)
            {
                //add the new car record
                Add();
            }
            else
            {
                //update the car record
                Update();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect the user to the car list page, without having added or edited a car hire record
            Response.Redirect("VCHHireList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect me to the home page, this offers links to all system pages
            Response.Redirect("VCHCustomerOrStaffSelection.aspx");
        }
    }
}