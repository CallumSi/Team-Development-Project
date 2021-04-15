using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMStaffList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplayVMStaff();
            }
        }

        void DisplayVMStaff()
        {
            //create an instance of the use collection
            clsVMStaffCollection AllStaff = new clsVMStaffCollection();
            lstVMStaff.DataSource = AllStaff.StaffList;
            //set name of primary key
            lstVMStaff.DataValueField = "VMStaffID";
            //bind data
            lstVMStaff.DataTextField = "VMStaffFirstName";
            lstVMStaff.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["VMStaffID"] = -1;
            //redirect to user data entry page
            Response.Redirect("AnVMStaff.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 VMStaffID;
            //if a record has been selected from the list
            if (lstVMStaff.SelectedIndex != -1)
            {
                //get the primary key of the record to edit
                VMStaffID = Convert.ToInt32(lstVMStaff.SelectedValue);
                //store the data in the session object
                Session["VMStaffID"] = VMStaffID;
                //redirect to the edit page
                Response.Redirect("AnVMStaff.aspx");
            }
            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 VMStaffID;
            //if a record has been selected from the list
            if (lstVMStaff.SelectedIndex != -1)
            {
                //get the primary key of the record to delete
                VMStaffID = Convert.ToInt32(lstVMStaff.SelectedValue);
                //store the data in the session object
                Session["VMStaffID"] = VMStaffID;
                //redirect to the delete page
                Response.Redirect("VMStaffDelete.aspx");
            }
            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display all Customer
            DisplayFirstName("");
        }

        Int32 DisplayFirstName(string VMStaffFilter)
        {
            Int32 VMStaffID;
            string VMStaffFirstName;
            //create an instance of the staff Collection class
            clsVMStaffCollection staffFirstName = new clsVMStaffCollection();
            //invoke the staff firstname filter
            staffFirstName.FilterByFirstName(VMStaffFilter);
            //var to store the count of records
            Int32 RecordCount;
            //var to store the index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = staffFirstName.Count;
            //clear the list box
            lstVMStaff.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the primary key
                VMStaffID = staffFirstName.StaffList[Index].VMstaffID;
                //get the username
                VMStaffFirstName = staffFirstName.StaffList[Index].VMstaffFirstName;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(VMStaffFirstName + " ", VMStaffID.ToString());
                //add the shoes to the list
                lstVMStaff.Items.Add(NewEntry);
                //move the index to the next record
                Index++;
            }
            return RecordCount;
        }

        protected void btnApplyFilter_Click(object sender, EventArgs e)
        {
            //display all Customer usernames
            DisplayFirstName(txtFilterStaffUsername.Text);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }

        protected void btnStaffMovie_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnVMStaffAddMovie.aspx");
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMCustomerList.aspx");
        }
    }
}