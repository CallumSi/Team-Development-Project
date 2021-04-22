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
        Int32 HireBookingID;

        //function to handle this pages load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff/admin to be processed
            StaffID = Convert.ToInt32(Session["StaffID"]);
            HireBookingID = Convert.ToInt32(Session["HireBookingID"]);

            //vars to store the date and time
            string HireBookingDate;
            string HireBookingTime;
            //get the date and time from the query string
            HireBookingDate = Request.QueryString["HireBookingDate"];
            HireBookingTime = Request.QueryString["HireBookingTime"];
            //display hire booking date
            txtHireDate.Text = HireBookingDate;
            //display hire booking time 
            txtHireTime.Text = HireBookingTime.Remove(0, 1);
        }

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID when a page unload event happens
            Session["StaffID"] = StaffID;
            Session["HireBookingID"] = HireBookingID;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //retrieve Hire Booking Time
            int HireID= Convert.ToInt32(txtHireID.Text);
            //retrieve Hire Booking Time
            int HireTime = Convert.ToInt32(txtHireTime.Text);
            //retrieve Hire Date
            DateTime HireDate = Convert.ToDateTime(txtHireDate.Text);
            //retrieve Hire Description
            string HireDescription = Convert.ToString(txtHireDescription.Text);

            //create an instance of the hire booking collection class
            clsVCHHireBookingCollection HireBooking = new clsVCHHireBookingCollection(HireDate);
            //add new hire booking record
            HireBooking.AddBooking(HireID, HireTime, HireDescription);
            //redirect to the main page
            //store data in session object so we can pass it to next page
            Session["StaffID"] = StaffID;
            Response.Redirect("VCHHireBookingList.aspx");
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