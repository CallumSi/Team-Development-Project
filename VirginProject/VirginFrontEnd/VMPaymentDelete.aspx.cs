using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMPaymentDelete : System.Web.UI.Page
    {
        //var for VMPaymentID of record to be deleted
        Int32 VMPaymentID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the payment to be deleted from the session object
            VMPaymentID = Convert.ToInt32(Session["VMPaymentID"]);
        }

        //function to delete the selected payment record 
        void DeletePayment()
        {
            //create a new instance of the payment collection class
            clsVMPaymentCollection allPayments = new clsVMPaymentCollection();
            //find the record to delete
            allPayments.ThisPayment.Find(VMPaymentID);
            //delete the record
            allPayments.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeletePayment();
            //redirect to the main page
            Response.Redirect("VMPaymentList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VMPaymentList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMCustomerList.aspx");
        }

        protected void btnStaffMovie_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffMovie.aspx");
        }

        protected void btnVMStaffList_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnVMPaymentList_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMPaymentList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }
    }
}