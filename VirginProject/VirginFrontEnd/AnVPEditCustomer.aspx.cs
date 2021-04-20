using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class AnVPEditCustomer : System.Web.UI.Page
    {
        Int32 Customer_ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of customers to be processed
            Customer_ID = Convert.ToInt32(Session["Customer_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of customers
                DisplayCustomer();
                //if this is not a new record
                if (Customer_ID != -1)
                {
                    //display the current data for the record
                    DisplayCustomer();
                }

            }

        }

        //function for displaying customers 
        void DisplayCustomer()
        {
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //find the record to update
            AllCustomer.ThisCustomer.Find(Customer_ID);
            //display the data for this record
            txtCustomerFirstName.Text = AllCustomer.ThisCustomer.Customer_FirstName;
            txtCustomerLastName.Text = AllCustomer.ThisCustomer.Customer_LastName;
            txtCustomerStreet.Text = AllCustomer.ThisCustomer.Customer_Street;
            txtCustomerAddress.Text = AllCustomer.ThisCustomer.Customer_Address;
            txtCustomerPostcode.Text = AllCustomer.ThisCustomer.Customer_Postcode;
            txtCustomerEmail.Text = AllCustomer.ThisCustomer.Customer_Email;
            txtCustomerTelephone.Text = AllCustomer.ThisCustomer.Customer_Telephone;
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the customer list
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //validate the data on the web form 
            string Error = AllCustomer.ThisCustomer.Valid(txtCustomerFirstName.Text, txtCustomerLastName.Text, txtCustomerStreet.Text, txtCustomerAddress.Text, txtCustomerPostcode.Text, txtCustomerEmail.Text, txtCustomerTelephone.Text);
            if (Error == "")
            {
                //get the data entered by the user
                AllCustomer.ThisCustomer.Customer_FirstName = txtCustomerFirstName.Text;
                AllCustomer.ThisCustomer.Customer_LastName = txtCustomerLastName.Text;
                AllCustomer.ThisCustomer.Customer_Street = txtCustomerStreet.Text;
                AllCustomer.ThisCustomer.Customer_Address = txtCustomerAddress.Text;
                AllCustomer.ThisCustomer.Customer_Postcode = txtCustomerPostcode.Text;
                AllCustomer.ThisCustomer.Customer_Email = txtCustomerEmail.Text;
                AllCustomer.ThisCustomer.Customer_Telephone = txtCustomerTelephone.Text;
                //add the record
                AllCustomer.Add();
                //redirect back to the main page
                Response.Redirect("VPCustomerPhoneList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered, please try again" + Error;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (Customer_ID == -1)
            {
                //add a new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
            Response.Redirect("VPCustomerPhoneList.aspx");
        }

        void Update()
        {
            //create an instance of the staff 
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //validate the data on the web form 
            String Error = AllCustomer.ThisCustomer.Valid(txtCustomerFirstName.Text, txtCustomerLastName.Text, txtCustomerStreet.Text, txtCustomerAddress.Text, txtCustomerPostcode.Text, txtCustomerEmail.Text, txtCustomerTelephone.Text);
            //if the data is ok then add it to the object
            if (Error == "")
            {
                //find the record to update 
                AllCustomer.ThisCustomer.Find(Customer_ID);
                //get the data entered by the user
                AllCustomer.ThisCustomer.Customer_FirstName = txtCustomerFirstName.Text;
                AllCustomer.ThisCustomer.Customer_LastName = txtCustomerLastName.Text;
                AllCustomer.ThisCustomer.Customer_Street = txtCustomerStreet.Text;
                AllCustomer.ThisCustomer.Customer_Address = txtCustomerAddress.Text;
                AllCustomer.ThisCustomer.Customer_Postcode = txtCustomerPostcode.Text;
                AllCustomer.ThisCustomer.Customer_Email = txtCustomerEmail.Text;
                AllCustomer.ThisCustomer.Customer_Telephone = txtCustomerTelephone.Text;
                //update the record 
                AllCustomer.Update();
                //all done so redirect back to the main page
                Response.Redirect("VPCustomerPhoneList.aspx");
            }
            else
            {
                //report an error 
                lblError.Text = "There were problems with data entered" + Error;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //all done so redirect back to the main page
            Response.Redirect("VPCustomerPhoneList.aspx");
        }

        protected void btnViewCart_Click(object sender, EventArgs e)
        {
            //all done so redirect back to the main page
            Response.Redirect("VPViewCart.aspx");
        }

        protected void btnEditAccount_Click(object sender, EventArgs e)
        {
            //all done so redirect back to the main page
            Response.Redirect("AnVPEditCustomer.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to the customer page
            Response.Redirect("VPCustomerPhoneList.aspx");
        }
    }
}