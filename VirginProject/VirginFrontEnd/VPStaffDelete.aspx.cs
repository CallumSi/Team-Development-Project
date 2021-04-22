using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPStaffDelete : System.Web.UI.Page
    {
        ///This page uses code originated by Matthew Dean.
        ///it is free for use by anybody so long as you give credit to the original author.
        ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019

        //var to store the primary ket of the record to be deleted
        Int32 Staff_ID;


        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of staff id to be deleted from the session object
            Staff_ID = Convert.ToInt32(Session["Staff_ID"]);
        }

        void DeleteStaff()
        {
            //function to delete the selected record
            //create an instance of the staff
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            AllStaff.ThisStaff.Find(Staff_ID);
            //delete the record
            AllStaff.Delete();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the recird
            DeleteStaff();
            //redirect back to the main page
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnViewStaffList_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnViewCustomer_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VPCustomerList.aspx");
        }

        protected void btnViewPhoneList_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VPPhoneList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VirginLogin.aspx");
        }
    }
}