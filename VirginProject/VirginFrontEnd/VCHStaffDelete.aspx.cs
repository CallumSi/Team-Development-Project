using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHStaffDelete : System.Web.UI.Page
    {
        //var to store primary key for record to be deleted
        Int32 StaffID;

        //event handler for load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the primary key of the Staff that will be deleted from the session object
            StaffID = Convert.ToInt32(Session["StaffID"]);
        }

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID when a page unload event happens
            Session["StaffID"] = StaffID;
        }

        //function to delete a single customer
        void DeleteStaff()
        {
            //create an instance of the customer collection class
            clsVCHStaffCollection StaffCollection = new clsVCHStaffCollection();
            //find the customer record to be deleted 
            StaffCollection.ThisStaff.Find(StaffID);
            //delete the record
            StaffCollection.Delete();
        }

        //event handle to confirm customer record delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //delete the record
            DeleteStaff();
            //redirect the user to the customer list page
            Response.Redirect("VCHStaffList.aspx");
        }

        //event handle to cancel staff record delete button
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //redirect the user to the staff list page, without having deleted a staff record
            Response.Redirect("VCHStaffList.aspx");
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