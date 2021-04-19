using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMPaymentList : System.Web.UI.Page
    {
        Int32 VMPaymentID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplayVMPayment();
            }
        }

        void DisplayVMPayment()
        {
            //create an instance of the payment collection
            clsVMPaymentCollection allPayments = new clsVMPaymentCollection();
            lstVMPayment.DataSource = allPayments.PaymentList;
            //set name of primary key
            lstVMPayment.DataValueField = "VMPaymentID";
            //bind data
            lstVMPayment.DataTextField = "VMPaymentType";
            lstVMPayment.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["VMPaymentID"] = -1;
            //redirect to user data entry page
            Response.Redirect("AnVMPayment.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 VMPaymentID;
            //if a record has been selected from the list
            if (lstVMPayment.SelectedIndex != -1)
            {
                //get the primary key of the record to edit
                VMPaymentID = Convert.ToInt32(lstVMPayment.SelectedValue);
                //store the data in the session object
                Session["VMPaymentID"] = VMPaymentID;
                //redirect to the edit page
                Response.Redirect("AnVMPayment.aspx");
            }
            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 VMPaymentID;
            //if a record has been selected from the list
            if (lstVMPayment.SelectedIndex != -1)
            {
                //get the primary key of the record to delete
                VMPaymentID = Convert.ToInt32(lstVMPayment.SelectedValue);
                //store the data in the session object
                Session["VMPaymentID"] = VMPaymentID;
                //redirect to the delete page
                Response.Redirect("VMPaymentDelete.aspx");
            }
            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display all payments
            DisplayPayment("");
        }

        Int32 DisplayPayment(string VMPaymentFilter)
        {
            Int32 VMPaymentID;
            string VMPaymentType;
            //create an instance of the payment collection
            clsVMPaymentCollection allPayments = new clsVMPaymentCollection();
            //invoke the payment type filter
            allPayments.FilterByPaymentType(VMPaymentFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = allPayments.Count;
            //clear the list box
            lstVMPayment.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                VMPaymentID = allPayments.PaymentList[Index].VMPaymentID;
                //get the username
                VMPaymentType = allPayments.PaymentList[Index].VMPaymentType;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(VMPaymentType + " ", VMPaymentID.ToString());
                //add the shoes to the list
                lstVMPayment.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            return RecordCount;
        }

        protected void btnApplyFilter_Click(object sender, EventArgs e)
        {
            //display all Customer usernames
            DisplayPayment(txtFilterPaymentType.Text);
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

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect to the login page
            Response.Redirect("VirginLogin.aspx");
        }

        protected void btnVMPaymentList_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMPaymentList.aspx");
        }
    }
}