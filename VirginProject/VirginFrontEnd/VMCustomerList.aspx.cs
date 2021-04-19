using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMAnCustomer : System.Web.UI.Page
    {
        Int32 VMCustomerID;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (IsPostBack == false)
                {
                    //update the list box
                    DisplayVMCustomer();
                }
        }

        void DisplayVMCustomer()
        {
            //create an instance of the use collection
            clsVMCustomerCollection AllCustomers = new clsVMCustomerCollection();
            lstVMCustomers.DataSource = AllCustomers.CustomerList;
            //set name of primary key
            lstVMCustomers.DataValueField = "VMCustomerID";
            //bind data
            lstVMCustomers.DataTextField = "VMCustomerUsername";
            lstVMCustomers.DataBind();
            lstVMCustomers.Items.Clear();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["VMCustomerID"] = -1;
            //redirect to user data entry page
            Response.Redirect("AnVMCustomer.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 VMCustomerID;
            //if a record has been selected from the list
            if (lstVMCustomers.SelectedIndex != -1)
            {
                //get the primary key of the record to edit
                VMCustomerID = Convert.ToInt32(lstVMCustomers.SelectedValue);
                //store the data in the session object
                Session["VMCustomerID"] = VMCustomerID;
                //redirect to the edit page
                Response.Redirect("AnVMCustomer.aspx");
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
            Int32 VMCustomerID;
            //if a record has been selected from the list
            if (lstVMCustomers.SelectedIndex != -1)
            {
                //get the primary key of the record to delete
                VMCustomerID = Convert.ToInt32(lstVMCustomers.SelectedValue);
                //store the data in the session object
                Session["VMCustomerID"] = VMCustomerID;
                //redirect to the delete page
                Response.Redirect("VMCustomerDelete.aspx");
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
            //display all Customer
            DisplayUsername("");
        }

        Int32 DisplayUsername(string VMUsernameFilter)
        {
            Int32 VMCustomerID;
            string VMCustomerUsername;
            //create an instance of the customer Collection class
            clsVMCustomerCollection customerUsername = new clsVMCustomerCollection();
            //invoke the customer username filter
            customerUsername.FilterByUsername(VMUsernameFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = customerUsername.Count;
            //clear the list box
            lstVMCustomers.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                VMCustomerID = customerUsername.CustomerList[Index].VMCustomerID;
                //get the username
                VMCustomerUsername = customerUsername.CustomerList[Index].VMcustomerUsername;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(VMCustomerUsername + " ", VMCustomerID.ToString());
                //add the shoes to the list
                lstVMCustomers.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            return RecordCount;
        }

        protected void btnApplyFilter_Click(object sender, EventArgs e)
        {
            //display all Customer usernames
            DisplayUsername(txtFilterUsername.Text);
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