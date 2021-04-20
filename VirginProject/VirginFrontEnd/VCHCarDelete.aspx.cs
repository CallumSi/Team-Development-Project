using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHCarDelete : System.Web.UI.Page
    {
        //var to store primary key for record to be deleted
        Int32 CarID;
        Int32 StaffID;

        //event handler for load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the primary key of the car that will be deleted from the session object
            CarID = Convert.ToInt32(Session["CarID"]);
            StaffID = Convert.ToInt32(Session["StaffID"]);
        }

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID when a page unload event happens
            Session["StaffID"] = StaffID;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //delete the record
            DeleteCar();
            //redirect the user to the car list page
            Response.Redirect("VCHCarList.aspx");
        }

        //function to delete a car 
        void DeleteCar()
        {
            //create an instance of the car 
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            //find the car record to be deleted 
            CarCollection.ThisCar.Find(CarID);
            //delete the record
            CarCollection.Delete();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //redirect the user to the car list page, without having deleted a car record
            Response.Redirect("VCHCarList.aspx");
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