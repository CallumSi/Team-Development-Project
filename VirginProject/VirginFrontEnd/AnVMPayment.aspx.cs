using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class AnVMPayment : System.Web.UI.Page
    {
        Int32 VMPaymentID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of payments to be processed
            VMPaymentID = Convert.ToInt32(Session["VMPaymentID"]);
            if (IsPostBack == false)
            {
                //populate the list of payment
                DisplayVMPayments();
                //if this is not a new record
                if (VMPaymentID != -1)
                {
                    //display the current data for the record
                    DisplayVMPayments();
                }
            }

            void DisplayVMPayments()
            {
                //create an instance of the payment collection class
                clsVMPaymentCollection AllPayments = new clsVMPaymentCollection();
                //find the record to update
                AllPayments.ThisPayment.Find(VMPaymentID);
                //display the data for this record
                chkPaymentStatus.Checked = AllPayments.ThisPayment.VMPaymentStatus;
                txtPaymentType.Text = AllPayments.ThisPayment.VMPaymentType;
            }
        }

        protected void chkPaymentStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnOkay_Click(object sender, EventArgs e)
        {
            if (VMPaymentID == -1)
            {
                //add the new record
                Add();

            }
            else
            {
                //update the record
                Update();
            }
        }

        private void Add()
        {
            //create an instance of the payment collection class
            clsVMPaymentCollection AllPayments = new clsVMPaymentCollection();
            //validate the data on the web form
            String Error = AllPayments.ThisPayment.Valid(txtPaymentType.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                AllPayments.ThisPayment.VMPaymentStatus = chkPaymentStatus.Checked;
                AllPayments.ThisPayment.VMPaymentType = txtPaymentType.Text;

                //add the record
                AllPayments.Add();
                //redirect to the main page
                Response.Redirect("VMPaymentList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered: " + Error;
            }
        }

        private void Update()
        {
            //create an instance of the payment collection class
            clsVMPaymentCollection AllPayments = new clsVMPaymentCollection();
            //validate the data on the web form
            String Error = AllPayments.ThisPayment.Valid(txtPaymentType.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                AllPayments.ThisPayment.Find(VMPaymentID);
                //get the data entered by the user
                AllPayments.ThisPayment.VMPaymentStatus = chkPaymentStatus.Checked;
                AllPayments.ThisPayment.VMPaymentType = txtPaymentType.Text;
                //add the record
                AllPayments.Update();
                //redirect to the main page
                Response.Redirect("VMPaymentList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered: " + Error;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMPaymentList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect to the staff list
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            //redirect to the customer list
            Response.Redirect("VMCustomerList.aspx");
        }

        protected void btnStaffMovie_Click(object sender, EventArgs e)
        {
            //redirect to the staff movie list
            Response.Redirect("VMStaffMovie.aspx");
        }

        protected void btnVMStaffList_Click(object sender, EventArgs e)
        {
            //redirect to the staff list
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnVMPaymentList_Click(object sender, EventArgs e)
        {
            //redirect to the payment list page 
            Response.Redirect("VMPaymentList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect to the login page 
            Response.Redirect("VirginLogin.aspx");
        }
    }
}