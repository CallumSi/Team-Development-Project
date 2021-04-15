using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
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

        }
    }
}