using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHCustomerDelete : System.Web.UI.Page
    {
        //var to store primary key for record to be deleted
        Int32 CustomerID;
        Int32 StaffID;

        //event handler for load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the primary key of the Customer that will be deleted from the session object
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
            StaffID = Convert.ToInt32(Session["StaffID"]);
        }

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID when a page unload event happens
            Session["StaffID"] = StaffID;
        }

        //function to delete a single customer
        void DeleteCustomer()
        {
            //create an instance of the customer collection class
            clsVCHCustomerCollection CustomerCollection = new clsVCHCustomerCollection();
            //find the customer record to be deleted 
            CustomerCollection.ThisCustomer.Find(CustomerID);
            //delete the record
            CustomerCollection.Delete();
        }

        //event handle to confirm customer record delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //delete the record
            DeleteCustomer();
            //redirect the user to the customer list page
            Response.Redirect("VCHCustomerList.aspx");
        }

        //event handle to cancel customer record delete button
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //redirect the user to the customer list page, without having deleted a customer record
            Response.Redirect("VCHCustomerList.aspx");
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

        protected void btnBooking_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the staff home page
            Response.Redirect("VCHHireBookingList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //direct me to the log in page
            Response.Redirect("VirginLogIn.aspx");
        }
    }
}