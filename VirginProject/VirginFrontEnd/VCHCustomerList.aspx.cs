using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHCustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayCustomers();
            }
        }

        void DisplayCustomers()
        {
            //create an instance of the Customer 
            clsVCHCustomerCollection Customers = new clsVCHCustomerCollection();
            //set the data source to the list of customers in the collection
            lstCustomer.DataSource = Customers.CustomerList;
            //set the name of the primary key
            lstCustomer.DataValueField = "CustomerID";
            //set the data field to display
            lstCustomer.DataTextField = "FirstName";
            //bind the data to the list
            lstCustomer.DataBind();
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["CustomerID"] = -1;
            //once complete redirect the user back to the main page
            Response.Redirect("VCHACustomer.aspx");
        }
    }
}