﻿using System;
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
        //variable to store the primary key & UserID (FK) with page level scope
        Int32 CustomerID;
        Int32 UserID;
        Int32 StaffID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer/user to be processed
            StaffID = Convert.ToInt32(Session["StaffID"]);
            CustomerID = Convert.ToInt32(Session["CustomerID"]);
            UserID = Convert.ToInt32(Session["UserID"]);
            lblUserID.Text = "New User Details";
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

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID when a page unload event happens
            Session["StaffID"] = StaffID;
        }

        //function to add new customer records
        void Add()
        {
            //create an instance of the Customer 
            clsVCHCustomerCollection CustomerCollection = new clsVCHCustomerCollection();
            //validate the data on the web front
            String Error = CustomerCollection.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtAge.Text, txtDriverLicenseNumber.Text, txtAddress.Text, txtPostcode.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, txtPhonenumber.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //get the data entered by the user
                CustomerCollection.ThisCustomer.UserID = UserID;
                CustomerCollection.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerCollection.ThisCustomer.LastName = txtLastName.Text;
                CustomerCollection.ThisCustomer.Age = Convert.ToInt32(txtAge.Text);
                CustomerCollection.ThisCustomer.DriverLicenseNumber = txtDriverLicenseNumber.Text;
                CustomerCollection.ThisCustomer.Address = txtAddress.Text;
                CustomerCollection.ThisCustomer.PostCode = txtPostcode.Text;
                CustomerCollection.ThisCustomer.Username = txtUsername.Text;
                CustomerCollection.ThisCustomer.Email = txtEmail.Text;
                CustomerCollection.ThisCustomer.Password = txtPassword.Text;
                CustomerCollection.ThisCustomer.PhoneNumber = txtPhonenumber.Text;
                //add the new customer record
                CustomerCollection.Add();

                //Add the StaffID to session object 
                Session["StaffID"] = StaffID;
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
            String Error = CustomerCollection.ThisCustomer.Valid(txtFirstName.Text, txtLastName.Text, txtAge.Text, txtDriverLicenseNumber.Text, txtAddress.Text, txtPostcode.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, txtPhonenumber.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //find the CustomerID for the record to be updated
                CustomerCollection.ThisCustomer.Find(CustomerID);
                //get the data entered by the user
                CustomerCollection.ThisCustomer.UserID = UserID;
                CustomerCollection.ThisCustomer.FirstName = txtFirstName.Text;
                CustomerCollection.ThisCustomer.LastName = txtLastName.Text;
                CustomerCollection.ThisCustomer.Age = Convert.ToInt32(txtAge.Text);
                CustomerCollection.ThisCustomer.DriverLicenseNumber = txtDriverLicenseNumber.Text;
                CustomerCollection.ThisCustomer.Address = txtAddress.Text;
                CustomerCollection.ThisCustomer.PostCode = txtPostcode.Text;
                CustomerCollection.ThisCustomer.Username = txtUsername.Text;
                CustomerCollection.ThisCustomer.Email = txtEmail.Text;
                CustomerCollection.ThisCustomer.Password = txtPassword.Text;
                CustomerCollection.ThisCustomer.PhoneNumber = txtPhonenumber.Text;
                //update the customer record
                CustomerCollection.Update();

                //Add the StaffID to session object 
                Session["StaffID"] = StaffID;
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
            txtAge.Text = CustomerCollection.ThisCustomer.Age.ToString();
            txtDriverLicenseNumber.Text = CustomerCollection.ThisCustomer.DriverLicenseNumber;
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
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //redirect the user to the customer list page, without having added or edited a customer record
            Response.Redirect("VCHCustomerList.aspx");
        }

        protected void btnStaff_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the staff list page
            Response.Redirect("VCHStaffList.aspx");
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the customer list page
            Response.Redirect("VCHCustomerList.aspx");
        }

        protected void btnCar_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the car list page
            Response.Redirect("VCHCarList.aspx");
        }

        protected void btnHire_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the car hire list page
            Response.Redirect("VCHHireList.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the staff home page
            Response.Redirect("VCHStaffDefault.aspx");
        }

        protected void btnBooking_Click(object sender, EventArgs e)
        {
            //Add the StaffID to session object 
            Session["StaffID"] = StaffID;
            //direct me to the staff home page
            Response.Redirect("VCHHireBookingList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //direct me to the log in page
            Response.Redirect("VirginLogIn.aspx");
        }
    }
}