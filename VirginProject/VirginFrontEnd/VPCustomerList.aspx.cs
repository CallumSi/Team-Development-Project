using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    ///This page uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    public partial class VPCustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //the first time the page is displayed 
            if (IsPostBack == false)
            {
                //update the list box
                DisplayVPCustomer();
            }
        }

        void DisplayVPCustomer()
        {
            //create an instance of the staff collection 
            clsVPCustomerCollection AllCustomer = new clsVPCustomerCollection();
            //set the data source to the customer in customer collection 
            lstCustomer.DataSource = AllCustomer.CustomerList;
            //set the same of the primary key
            lstCustomer.DataValueField = "Customer_ID";
            //set the data field to display
            lstCustomer.DataTextField = "Customer_FirstName";
            //bind the data to the list
            lstCustomer.DataBind();
            lstCustomer.Items.Clear();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["Customer_ID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnVPCustomer.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 Customer_ID;
            //if the record has been selected from the list 
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Customer_ID = Convert.ToInt32(lstCustomer.SelectedValue);
                //store the data in the session object 
                Session["Customer_ID"] = Customer_ID;
                //redirect to the delete page 
                Response.Redirect("VPCustomerDelete.aspx");
            }
            else
            {
                //if no record has been selected 
                //display an error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 Customer_ID;
            //if the record has been selected from the list 
            if (lstCustomer.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Customer_ID = Convert.ToInt32(lstCustomer.SelectedValue);
                //store the data in the session object 
                Session["Customer_ID"] = Customer_ID;
                //redirect to the delete page 
                Response.Redirect("AnVPCustomer.aspx");
            }
            else
            {
                //if no record has been selected 
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            DisplayFirstName(txtSearchFirstName.Text);
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display all the customers first name
            DisplayFirstName("");
        }

        Int32 DisplayFirstName(string VPCustomerFilter)
        {
            Int32 Customer_ID;
            string Customer_FirstName; //this one is declared in the collections and tests
            //create an instance of the staff collection
            clsVPCustomerCollection CustomerFirstName = new clsVPCustomerCollection();
            //invoke the customer first name filter
            CustomerFirstName.FilterByCustomerFirstName(VPCustomerFilter);
            //var to store the count of record
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count record
            RecordCount = CustomerFirstName.Count;
            //clear the list box
            lstCustomer.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key 
                Customer_ID = CustomerFirstName.CustomerList[Index].Customer_ID;
                //get the first name
                Customer_FirstName = CustomerFirstName.CustomerList[Index].Customer_FirstName;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(Customer_FirstName + "", Customer_ID.ToString());
                //add the staff to the list
                lstCustomer.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            return RecordCount;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect the customer list 
            Response.Redirect("VPStaffList.aspx");

        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            //redirect the customer list 
            Response.Redirect("VPCustomerList.aspx");
        }

        protected void btnStaffList_Click(object sender, EventArgs e)
        {
            //redirect the staff list 
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnPhoneList_Click(object sender, EventArgs e)
        {
            //redirect the phone list 
            Response.Redirect("VPPhoneList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect to login page
            Response.Redirect("VirginLogin.aspx");
        }
    }
}