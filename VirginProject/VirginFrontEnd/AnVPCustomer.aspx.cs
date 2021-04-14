using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class AVPCustomer : System.Web.UI.Page
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
                if (Customer_ID !=-1)
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

            }
        }
      
    }
}