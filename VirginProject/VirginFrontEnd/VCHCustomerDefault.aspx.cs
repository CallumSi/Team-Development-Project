using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHCustomerHome : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 CustomerID;
        Int32 UserID;

        protected void Page_Load(object sender, EventArgs e)
        {
            UserID = Convert.ToInt32(Session["UserID"]);
            //check if user exisits
            //create an instance of the customer collection class
            clsVCHCustomerCollection SomeCustomer = new clsVCHCustomerCollection();
            //find the record to update
            if (SomeCustomer.ThisCustomer.FindByUserID(UserID) == false)
            {
                //change button text to create account and ididcate new yser
                btnFirstTime.Text = "Create Account";
                btnReturningCustomer.Visible = false;
                CustomerID = -1;
            }
            else
            {
                //button changed for edit account details
                btnFirstTime.Text = "Edit Account Details";
                SomeCustomer.ThisCustomer.FindByUserID(UserID);
                CustomerID = SomeCustomer.ThisCustomer.CustomerID;
            }
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the CustomerID & UserID when a page unload event happens
            Session["CustomerID"] = CustomerID;
            Session["UserID"] = UserID;
        }

        //event handler for the btnFirstTime
        protected void btnFirstTime_Click(object sender, EventArgs e)
        {
            //store data in session object to pass it onto the next page
            Session["CustomerID"] = CustomerID;
            Session["UserID"] = UserID;
            //direct the customer to the customer details page so they can supply additional info
            Response.Redirect("VCHACustomerCE.aspx");
        }

        //event handler for the btnReturningCustomer
        protected void btnReturningCustomer_Click(object sender, EventArgs e)
        {
            //store data in session object to pass it onto the next page
            Session["CustomerID"] = CustomerID;
            //direct the customer to the customer home page
            Response.Redirect("VCHCustomerHomeCE.aspx");
        }
    }
}