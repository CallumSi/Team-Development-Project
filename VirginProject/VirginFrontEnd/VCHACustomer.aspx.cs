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
        protected void Page_Load(object sender, EventArgs e)
        {
            
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

        //event handler for the OK button
        protected void btnOK_Click(object sender, EventArgs e)
        {
            //add a new customer record
            Add();
            //once complete redirect the user back to the main page
            Response.Redirect("VCHCustomerList.aspx");
        }
    }
}