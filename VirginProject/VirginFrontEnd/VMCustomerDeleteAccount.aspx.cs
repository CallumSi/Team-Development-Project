using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

///This page uses code originated by Matthew Dean.
///it is free for use by anybody so long as you give credit to the original author.
///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019

namespace VirginFrontEnd
{
    public partial class VMCustomerDeleteAccount : System.Web.UI.Page
    {
        Int32 VMCustomerID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer to be deleted from the session object
            VMCustomerID = Convert.ToInt32(Session["VMCustomerID"]);
        }

        //function to delete the selected customer record 
        void DeleteCustomer()
        {
            //create a new instance of the customer collection class
            clsVMCustomerCollection AllCustomers = new clsVMCustomerCollection();
            //find the record to delete
            AllCustomers.ThisCustomer.Find(VMCustomerID);
            //delete the record
            AllCustomers.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteCustomer();
            //redirect to the main page
            Response.Redirect("VirginLogin.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomerID"] = VMCustomerID;
            Response.Redirect("VMViewCart.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["VMCustomerID"] = VMCustomerID;
            Response.Redirect("AnVMCustomerEdit.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }
    }
}