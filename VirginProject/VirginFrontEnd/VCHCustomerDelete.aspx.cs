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

        //event handler for load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the primary key of the Customer that will be deleted from the session object
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
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
            //delete the record
            DeleteCustomer();
            //redirect the user to the customer list page
            Response.Redirect("VCHCustomerList.aspx");
        }

        //event handle to cancel customer record delete button
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect the user to the customer list page, without having deleted a customer record
            Response.Redirect("VCHCustomerList.aspx");
        }
    }
}