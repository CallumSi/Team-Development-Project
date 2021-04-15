using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHACustomer : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 CustomerID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer to be processed
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
            if (IsPostBack == false)
            {
                //populate the list of customers
                DisplayCustomers();
                //if this is not a new record
                if (CustomerID != -1)
                {
                    //display the current data for the record
                    DisplayCustomers();
                }
            }
        }

        //function to add new customer records
        void Add()
        {
            //create an instance of the Customer 
            clsVCHCustomerCollection CustomerCollection = new clsVCHCustomerCollection();
            //validate the data on the web front
            String Error = CustomerCollection.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPostcode.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, txtPhonenumber.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //get the data entered by the user
                CustomerCollection.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerCollection.ThisCustomer.LastName = txtLastName.Text;
                CustomerCollection.ThisCustomer.Address = txtAddress.Text;
                CustomerCollection.ThisCustomer.PostCode = txtPostcode.Text;
                CustomerCollection.ThisCustomer.Username = txtUsername.Text;
                CustomerCollection.ThisCustomer.Email = txtEmail.Text;
                CustomerCollection.ThisCustomer.Password = txtPassword.Text;
                CustomerCollection.ThisCustomer.PhoneNumber = txtPhonenumber.Text;
                //add the new customer record
                CustomerCollection.Add();

                //once complete redirect the user back to the main page
                Response.Redirect("VCHCustomerList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
        }

        //function to update existing customer records
        void Update()
        {
            //create an instance of the Customer 
            clsVCHCustomerCollection CustomerCollection = new clsVCHCustomerCollection();
            //validate the data on the web front
            String Error = CustomerCollection.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPostcode.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, txtPhonenumber.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //find the CustomerID for the record to be updated
                CustomerCollection.ThisCustomer.Find(CustomerID);
                //get the data entered by the user
                CustomerCollection.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerCollection.ThisCustomer.LastName = txtLastName.Text;
                CustomerCollection.ThisCustomer.Address = txtAddress.Text;
                CustomerCollection.ThisCustomer.PostCode = txtPostcode.Text;
                CustomerCollection.ThisCustomer.Username = txtUsername.Text;
                CustomerCollection.ThisCustomer.Email = txtEmail.Text;
                CustomerCollection.ThisCustomer.Password = txtPassword.Text;
                CustomerCollection.ThisCustomer.PhoneNumber = txtPhonenumber.Text;
                //update the customer record
                CustomerCollection.Update();

                //once complete redirect the user back to the main page
                Response.Redirect("VCHCustomerList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
            
        }

        void DisplayCustomers()
        {
            //create an instance of the Customer 
            clsVCHCustomerCollection CustomerCollection = new clsVCHCustomerCollection();
            //find the record to update
            CustomerCollection.ThisCustomer.Find(CustomerID);
            //display the data for this record
            txtFirstName.Text = CustomerCollection.ThisCustomer.FirstName;
            txtLastName.Text = CustomerCollection.ThisCustomer.LastName;
            txtAddress.Text = CustomerCollection.ThisCustomer.Address;
            txtPostcode.Text = CustomerCollection.ThisCustomer.PostCode;
            txtUsername.Text = CustomerCollection.ThisCustomer.Username;
            txtEmail.Text = CustomerCollection.ThisCustomer.Email;
            txtPassword.Text = CustomerCollection.ThisCustomer.Password;
            txtPhonenumber.Text = CustomerCollection.ThisCustomer.PhoneNumber;
        }

        //event handler for the OK button
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (CustomerID == -1)
            {
                //add a new customer record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect the user to the customer list page, without having added or edited a customer record
            Response.Redirect("VCHCustomerList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect me to the home page, this offers links to all system pages
            Response.Redirect("VCHCustomerOrStaffSelection.aspx");
        }
    }
}