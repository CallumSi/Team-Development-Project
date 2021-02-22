using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMCustomerDelete : System.Web.UI.Page
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
            Response.Redirect("VMCustomerList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VMCustomerList.aspx");
        }
    }
}