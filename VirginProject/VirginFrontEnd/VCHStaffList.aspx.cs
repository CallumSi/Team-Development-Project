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
        protected void Page_LoadStaff(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayStaff();
            }
        }

        void DisplayStaff()
        {
            //create an instance of the Customer 
            clsVCHStaffCollection Staff = new clsVCHStaffCollection();
            //set the data source to the list of customers in the collection
            lstCustomer.DataSource = Staff.StaffList;
            //set the name of the primary key
            lstCustomer.DataValueField = "StaffID";
            //set the data field to display
            lstCustomer.DataTextField = "StaffFirstName";

            /*//set the data field to display
            lstCustomer.DataTextField = "StaffUsername";
            //set the data field to display
            lstCustomer.DataTextField = "StaffFirstName" + "StaffUsername";*/

            //bind the data to the list
            lstCustomer.DataBind();
        }

        protected void btnDisplayAllStaff_Click(object sender, EventArgs e)
        {
            //display the customers list
            DisplayStaff();
        }

        //protected void btnAddStaff_Click(object sender, EventArgs e)
        //{
        //    //store -1 into the session object to indicate this is a new record
        //    Session["CustomerID"] = -1;
        //    //once complete redirect the user back to the main page
        //    Response.Redirect("VCHACustomer.aspx");
        //}

        //protected void btnDeleteStaff_Click(object sender, EventArgs e)
        //{
        //    //var to store the primary key value
        //    Int32 CustomerID;
        //    //if a record has been selected from the list
        //    if (lstCustomer.SelectedIndex != -1)
        //    {
        //        //retrieve intended delete records primary key
        //        CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
        //        //store the data in the session object
        //        Session["CustomerID"] = CustomerID;
        //        //redirect the delete page
        //        Response.Redirect("VCHCustomerDelete.aspx");
        //    }
        //    else //if a user has not selected a customer record to delete
        //    {
        //        //display an error
        //        lblErrorStaff.Text = "Please select a Customer to delete from the list";
        //    }
        //}

        //protected void btnEditStaff_Click(object sender, EventArgs e)
        //{
        //    //var to store the primary key value
        //    Int32 CustomerID;
        //    //if a record has been selected from the list
        //    if (lstCustomer.SelectedIndex != -1)
        //    {
        //        //retrieve intended delete records primary key
        //        CustomerID = Convert.ToInt32(lstCustomer.SelectedValue);
        //        //store the data in the session object
        //        Session["CustomerID"] = CustomerID;
        //        //redirect the delete page
        //        Response.Redirect("VCHACustomer.aspx");
        //    }
        //    else //if a user has not selected a customer record to delete
        //    {
        //        //display an error
        //        lblError.Text = "Please select a Customer to edit from the list";
        //    }
        //}

        //protected void btnApplyStaff_Click(object sender, EventArgs e)
        //{
        //    //display only usernames
        //    DisplayFilterUsername(txtBxSearch.Text);
        //}

        //Int32 DisplayFilterUsername(string UsernameFilter)
        //{
        //    //int to store the primary key
        //    Int32 CustomerID;
        //    //customer Username property
        //    string Username;
        //    //customer First Name property
        //    string FirstName;
        //    //customer Last Name property
        //    string LastName;
            
        //    //create an instance of the user collection class
        //    clsVCHCustomerCollection CustomerCollection = new clsVCHCustomerCollection();
        //    CustomerCollection.ReportByUsername(UsernameFilter);
        //    //count of records
        //    Int32 RecordCount;
        //    //index for the loop
        //    Int32 Index = 0;
        //    //get the count of records
        //    RecordCount = CustomerCollection.Count;
        //    //clear the list box
        //    lstCustomer.Items.Clear();
        //    //while there are records to process
        //    while (Index < RecordCount)
        //    {
        //        //retrieve CustomerID
        //        CustomerID = CustomerCollection.CustomerList[Index].CustomerID;
        //        //retrieve Username
        //        Username = CustomerCollection.CustomerList[Index].Username;
        //        //retrieve FirstName
        //        FirstName = CustomerCollection.CustomerList[Index].FirstName;
        //        //retrieve LastName
        //        LastName = CustomerCollection.CustomerList[Index].LastName;
        //        //create new lstBx (list box) entry 
        //        ListItem NewEntry = new ListItem("Username - " + Username + " | First Name - " + FirstName + " | Last Name - " + LastName, CustomerID.ToString());
        //        //add the user to the list
        //        lstCustomer.Items.Add(NewEntry);
        //        //move the indext to the next record
        //        Index++;
        //    }
        //    //return the count of records
        //    return RecordCount;
        //}
    }
}