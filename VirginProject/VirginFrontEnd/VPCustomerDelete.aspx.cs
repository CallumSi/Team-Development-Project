using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    ///This page uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    public partial class VPCustomerDelete : System.Web.UI.Page
    {

        //var to store the primary key of the record to be deleted
        Int32 Customer_ID;


        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of customer id to be deleted from the session object
            Customer_ID = Convert.ToInt32(Session["Customer_ID"]);
        }

        void DeleteCustomer()
        {
            //function to delete the selected record
            //create an instance of the customer
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            AllCustomer.ThisCustomer.Find(Customer_ID);
            //delete the record
            AllCustomer.Delete();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteCustomer();
            //redirect back to the main page
            Response.Redirect("VPCustomerList.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to customer page
            Response.Redirect("VPCustomerList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect back to customer page
            Response.Redirect("VPCustomerList.aspx");
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            //redirect back to customer page
            Response.Redirect("VPCustomerList.aspx");
        }

        protected void btnStaffList_Click(object sender, EventArgs e)
        {
            //redirect back to customer page
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnPhoneList_Click(object sender, EventArgs e)
        {
            //redirect back to customer page
            Response.Redirect("VPPhoneList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect to the login page 
            Response.Redirect("VirginLogin.aspx");
        }
    }
}