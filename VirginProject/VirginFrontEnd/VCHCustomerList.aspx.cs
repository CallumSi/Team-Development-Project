using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHCustomerList : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 CustomerID;
        Int32 StaffID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayCustomers();
            }
        }

        void DisplayCustomers()
        {
            //int to store the primary key
            Int32 CustomerID;
            //customer Username property
            string Username;
            //customer First Name property
            string FirstName;
            //customer Last Name property
            string LastName;

            //create an instance of the user collection class
            clsVCHCustomerCollection CustomerCollection = new clsVCHCustomerCollection();
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = CustomerCollection.Count;
            //clear the list box
            lstCustomer.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve CustomerID
                CustomerID = CustomerCollection.CustomerList[Index].CustomerID;
                //retrieve Username
                Username = CustomerCollection.CustomerList[Index].Username;
                //retrieve FirstName
                FirstName = CustomerCollection.CustomerList[Index].FirstName;
                //retrieve LastName
                LastName = CustomerCollection.CustomerList[Index].LastName;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Username - " + Username + " | First Name - " + FirstName + " | Last Name - " + LastName, CustomerID.ToString());
                //add the user to the list
                lstCustomer.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display the customers list
            DisplayCustomers();
        }

        //protected void btnAdd_Click(object sender, EventArgs e)
        //{
        //    //store -1 into the session object to indicate this is a new record
        //    Session["CustomerID"] = -1;
        //    //redirect the user back to the customer add page
        //    Response.Redirect("VCHACustomer.aspx");
        //}

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 CustomerID;
            //if a record has been selected from the list
            if (lstCustomer.SelectedIndex != -1)
            {
                //retrieve intended delete records primary key
                CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
                //store the data in the session object
                Session["CustomerID"] = CustomerID;
                //redirect the delete page
                Response.Redirect("VCHCustomerDelete.aspx");
            }
            else //if a user has not selected a customer record to delete
            {
                //display an error
                lblError.Text = "Please select a Customer to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 CustomerID;
            //if a record has been selected from the list
            if (lstCustomer.SelectedIndex != -1)
            {
                //retrieve intended edit records primary key
                CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
                //store the data in the session object
                Session["CustomerID"] = CustomerID;
                //redirect the edit page
                Response.Redirect("VCHACustomer.aspx");
            }
            else //if a user has not selected a customer record to delete
            {
                //display an error
                lblError.Text = "Please select a Customer to edit from the list";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            //display only usernames
            DisplayFilterUsername(txtBxSearch.Text);
        }

        Int32 DisplayFilterUsername(string UsernameFilter)
        {
            //int to store the primary key
            Int32 CustomerID;
            //customer Username property
            string Username;
            //customer First Name property
            string FirstName;
            //customer Last Name property
            string LastName;
            
            //create an instance of the user collection class
            clsVCHCustomerCollection CustomerCollection = new clsVCHCustomerCollection();
            CustomerCollection.ReportByUsername(UsernameFilter);
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = CustomerCollection.Count;
            //clear the list box
            lstCustomer.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve CustomerID
                CustomerID = CustomerCollection.CustomerList[Index].CustomerID;
                //retrieve Username
                Username = CustomerCollection.CustomerList[Index].Username;
                //retrieve FirstName
                FirstName = CustomerCollection.CustomerList[Index].FirstName;
                //retrieve LastName
                LastName = CustomerCollection.CustomerList[Index].LastName;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Username - " + Username + " | First Name - " + FirstName + " | Last Name - " + LastName, CustomerID.ToString());
                //add the user to the list
                lstCustomer.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        }

        protected void btnAccess_Click(object sender, EventArgs e)
        {
            //once selected, I will be directed to the StaffList page
            //this button is currently in place to avoid an error of null customers
            Response.Redirect("VCHStaffList.aspx");
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