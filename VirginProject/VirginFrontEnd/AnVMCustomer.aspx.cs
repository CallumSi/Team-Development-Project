using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class AnVMCustomer : System.Web.UI.Page
    {
        Int32 VMCustomerID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of Customers to be processed
            VMCustomerID = Convert.ToInt32(Session["VMCustomerID"]);
            if (IsPostBack == false)
            {
                //populate the list of Customers
                DisplayVMCustomers();
                //if this is not a new record
                if (VMCustomerID != -1)
                {
                    //display the current data for the record
                    DisplayVMCustomers();
                }
            }

            void DisplayVMCustomers()
            {
                //create an instance of the customer class
                clsVMCustomerCollection AllCustomers = new clsVMCustomerCollection();
                //find the record to update
                AllCustomers.ThisCustomer.Find(VMCustomerID);
                //display the data for this record
                txtVMcustomerFirstname.Text = AllCustomers.ThisCustomer.VMcustomerFirstName;
                txtVMcustomerLastname.Text = AllCustomers.ThisCustomer.VMcustomerLastName;
                txtVMcustomerEmail.Text = AllCustomers.ThisCustomer.VMcustomerEmail;
                txtVMcustomerUsername.Text = AllCustomers.ThisCustomer.VMcustomerUsername;
                txtVMcustomerPassword.Text = AllCustomers.ThisCustomer.VMcustomerPassword;
            }
        }

        protected void btnOkay_Click(object sender, EventArgs e)
        {
            if (VMCustomerID == -1)
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

        //function for adding new records
        void Add()
        {
            //create an instance of the customer class
            clsVMCustomerCollection AllCustomers = new clsVMCustomerCollection();
            //validate the data on the web form
            String Error = AllCustomers.ThisCustomer.Valid(txtVMcustomerFirstname.Text, txtVMcustomerLastname.Text, txtVMcustomerEmail.Text, txtVMcustomerUsername.Text, txtVMcustomerPassword.Text);
            //if the data is OK then add it to the object
             if (Error == "")
             {
                AllCustomers.ThisCustomer.VMcustomerFirstName = txtVMcustomerFirstname.Text;
                AllCustomers.ThisCustomer.VMcustomerLastName = txtVMcustomerLastname.Text;
                AllCustomers.ThisCustomer.VMcustomerEmail = txtVMcustomerEmail.Text;
                AllCustomers.ThisCustomer.VMcustomerUsername = txtVMcustomerUsername.Text;
                AllCustomers.ThisCustomer.VMcustomerPassword = txtVMcustomerPassword.Text;

                //add the record
                AllCustomers.Add();
                //redirect to the main page
                Response.Redirect("VMCustomerList.aspx");
             }
             else
             {
                //report an error
                lblError.Text = "There were problems with the data entered: " + Error;
             }
        }
        
        //function for Updating records
        void Update()
        {
            //create an instance of the customer class
            clsVMCustomerCollection AllCustomers = new clsVMCustomerCollection();
            //validate the data on the web form
            String Error = AllCustomers.ThisCustomer.Valid(txtVMcustomerFirstname.Text, txtVMcustomerLastname.Text, txtVMcustomerEmail.Text, txtVMcustomerUsername.Text, txtVMcustomerPassword.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                AllCustomers.ThisCustomer.Find(VMCustomerID);
                //get the data entered by the user
                AllCustomers.ThisCustomer.VMcustomerFirstName = txtVMcustomerFirstname.Text;
                AllCustomers.ThisCustomer.VMcustomerLastName = txtVMcustomerLastname.Text;
                AllCustomers.ThisCustomer.VMcustomerEmail = txtVMcustomerEmail.Text;
                AllCustomers.ThisCustomer.VMcustomerUsername = txtVMcustomerUsername.Text;
                AllCustomers.ThisCustomer.VMcustomerPassword = txtVMcustomerPassword.Text;

                //add the record
                AllCustomers.Update();
                //redirect to the main page
                Response.Redirect("VMCustomerList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered: " + Error;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMCustomerList.aspx");

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
    }
}