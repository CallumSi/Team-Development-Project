using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHAHireBooking : System.Web.UI.Page
    {
        //variable to store the primary keywith page level scope
        Int32 StaffID;
        Int32 HireID;
        Int32 HireBookingID;

        //function to handle this pages load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff/admin to be processed
            StaffID = Convert.ToInt32(Session["StaffID"]);
            HireID = Convert.ToInt32(Session["HireID"]);
            HireBookingID = Convert.ToInt32(Session["HireBookingID"]);

            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //if this is not a new record
                if (HireBookingID != -1)
                {
                    //display the current data for the record
                    DisplayBooking();
                }
            }
        }

        void DisplayBooking()
        {
            //create an instance of the car hire collection class
            clsVCHHireBookingCollection HireBookingCollection = new clsVCHHireBookingCollection();
            //find the HireID for the record to be updated
            HireBookingCollection.ThisHireBooking.Find(HireBookingID);
            //display the data for this record
            txtHireID.Text = HireBookingCollection.ThisHireBooking.HireID.ToString();
            txtHireDate.Text = HireBookingCollection.ThisHireBooking.HireDate.ToString();
            txtHireTime.Text = HireBookingCollection.ThisHireBooking.HireTime.ToString();
            txtHireDescription.Text= HireBookingCollection.ThisHireBooking.HireDescription;
        }

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID when a page unload event happens
            Session["StaffID"] = StaffID;
            Session["HireID"] = HireID;
            Session["HireBookingID"] = HireBookingID;
        }

        //function to add new car hire booking records
        void Add()
        {
            //create an instance of the car hire collection class
            clsVCHHireBookingCollection HireBookingCollection = new clsVCHHireBookingCollection();
            //validate the data on the web front
            String Error = HireBookingCollection.ThisHireBooking.Valid(txtHireDate.Text, txtHireTime.Text, txtHireDescription.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //get the data entered by the user
                HireBookingCollection.ThisHireBooking.HireID = Convert.ToInt32(txtHireID.Text);
                HireBookingCollection.ThisHireBooking.HireDate = Convert.ToDateTime(txtHireDate.Text);
                HireBookingCollection.ThisHireBooking.HireTime = Convert.ToInt32(txtHireTime.Text);
                HireBookingCollection.ThisHireBooking.HireDescription = txtHireDescription.Text;
                //add the new car hire record
                HireBookingCollection.Add();

                //Add the StaffID to session object 
                Session["StaffID"] = StaffID;
                //once complete redirect the user to the car hire booking list page
                Response.Redirect("VCHHireBookingList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
        }

        //function to update existing car hire booking records
        void Update()
        {
            //create an instance of the car hire collection class
            clsVCHHireBookingCollection HireBookingCollection = new clsVCHHireBookingCollection();
            //validate the data on the web front
            String Error = HireBookingCollection.ThisHireBooking.Valid(txtHireDate.Text, txtHireTime.Text, txtHireDescription.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //find the record to update/edit
                HireBookingCollection.ThisHireBooking.Find(HireBookingID);
                //get the data entered by the user
                HireBookingCollection.ThisHireBooking.HireID = Convert.ToInt32(txtHireID.Text);
                HireBookingCollection.ThisHireBooking.HireDate = Convert.ToDateTime(txtHireDate.Text);
                HireBookingCollection.ThisHireBooking.HireTime = Convert.ToInt32(txtHireTime.Text);
                HireBookingCollection.ThisHireBooking.HireDescription = txtHireDescription.Text;
                //add the new car hire record
                HireBookingCollection.Add();

                //Add the StaffID to session object 
                Session["StaffID"] = StaffID;
                //once complete redirect the user to the car hire booking list page
                Response.Redirect("VCHHireBookingList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (HireBookingID == -1)
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
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the booking list page
            Response.Redirect("VCHHireBookingList.aspx");
        }

        protected void btnStaff_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the staff list page
            Response.Redirect("VCHStaffList.aspx");
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the customer list page
            Response.Redirect("VCHCustomerList.aspx");
        }

        protected void btnCar_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the car list page
            Response.Redirect("VCHCarList.aspx");
        }

        protected void btnHire_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the car hire list page
            Response.Redirect("VCHHireList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the staff home page
            Response.Redirect("VCHStaffDefault.aspx");
        }
    }
}