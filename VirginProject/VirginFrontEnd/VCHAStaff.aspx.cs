using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHAStaff : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 StaffID;
        Int32 AdminID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff to be processed
            StaffID = Convert.ToInt32(Session["StaffID"]);
            AdminID = Convert.ToInt32(Session["AdminID"]);
            if (IsPostBack == false)
            {
                //populate the list of staff
                DisplayStaff();
                //if this is not a new record
                if (StaffID != -1)
                {
                    //display the current data for the record
                    DisplayStaff();
                }
            }
        }

        //event handler for unload event
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID & AdminID when a page unload event happens
            Session["StaffID"] = StaffID;
            Session["AdminID"] = AdminID;
        }

        //function to add new staff records
        void Add()
        {
            //create an instance of the staff 
            clsVCHStaffCollection StaffCollection = new clsVCHStaffCollection();
            //validate the data on the web front
            String Error = StaffCollection.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPostcode.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, txtPhonenumber.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //get the data entered by the user
                StaffCollection.ThisStaff.AdminID = AdminID;
                StaffCollection.ThisStaff.StaffFirstName = txtFirstName.Text;
                StaffCollection.ThisStaff.StaffLastName = txtLastName.Text;
                StaffCollection.ThisStaff.StaffAddress = txtAddress.Text;
                StaffCollection.ThisStaff.StaffPostCode = txtPostcode.Text;
                StaffCollection.ThisStaff.StaffUsername = txtUsername.Text;
                StaffCollection.ThisStaff.StaffEmail = txtEmail.Text;
                StaffCollection.ThisStaff.StaffPassword = txtPassword.Text;
                StaffCollection.ThisStaff.StaffPhoneNumber = txtPhonenumber.Text;
                //add the new staff record
                StaffCollection.Add();

                StaffCollection.ThisStaff.FindByAdminID(AdminID);
                //Add the StaffID to session object 
                Session["StaffID"] = StaffID;
                //once complete redirect the user back to the main page
                Response.Redirect("VCHStaffList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
        }

        //function to update existing staff records
        void Update()
        {
            //create an instance of the staff 
            clsVCHStaffCollection StaffCollection = new clsVCHStaffCollection();
            //validate the data on the web front
            String Error = StaffCollection.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPostcode.Text, txtUsername.Text, txtEmail.Text, txtPassword.Text, txtPhonenumber.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //find the StaffID for the record to be updated
                StaffCollection.ThisStaff.Find(StaffID);
                //get the data entered by the user
                //StaffCollection.ThisStaff.AdminID = AdminID;
                StaffCollection.ThisStaff.StaffFirstName = txtFirstName.Text;
                StaffCollection.ThisStaff.StaffLastName = txtLastName.Text;
                StaffCollection.ThisStaff.StaffAddress = txtAddress.Text;
                StaffCollection.ThisStaff.StaffPostCode = txtPostcode.Text;
                StaffCollection.ThisStaff.StaffUsername = txtUsername.Text;
                StaffCollection.ThisStaff.StaffEmail = txtEmail.Text;
                StaffCollection.ThisStaff.StaffPassword = txtPassword.Text;
                StaffCollection.ThisStaff.StaffPhoneNumber = txtPhonenumber.Text;
                //update the staff record
                StaffCollection.Update();

                //Add the StaffID to session object 
                Session["StaffID"] = StaffID;
                //once complete redirect the user back to the main page
                Response.Redirect("VCHStaffList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }

        }

        void DisplayStaff()
        {
            //create an instance of the staff 
            clsVCHStaffCollection StaffCollection = new clsVCHStaffCollection();
            //find the StaffID for the record to be updated
            StaffCollection.ThisStaff.Find(StaffID);
            //display the data for this record
            txtFirstName.Text = StaffCollection.ThisStaff.StaffFirstName;
            txtLastName.Text = StaffCollection.ThisStaff.StaffLastName;
            txtAddress.Text = StaffCollection.ThisStaff.StaffAddress;
            txtPostcode.Text = StaffCollection.ThisStaff.StaffPostCode;
            txtUsername.Text = StaffCollection.ThisStaff.StaffUsername;
            txtEmail.Text = StaffCollection.ThisStaff.StaffEmail;
            txtPassword.Text = StaffCollection.ThisStaff.StaffPassword;
            txtPhonenumber.Text = StaffCollection.ThisStaff.StaffPhoneNumber;
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (StaffID == -1)
            {
                //add a new staff record
                Add();
            }
            else
            {
                //update the staff record
                Update();
            }
            //Add the StaffID & AdminID to session object 
            Session["StaffID"] = StaffID;
            Session["AdminID"] = AdminID;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect the user to the staff list page, without having added or edited a staff record
            Response.Redirect("VCHStaffList.aspx");
            Session["AdminID"] = AdminID;
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
    }
}