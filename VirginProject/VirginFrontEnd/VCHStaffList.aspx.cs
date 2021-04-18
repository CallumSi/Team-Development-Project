using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHStaffList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
            /*//create an instance of the Staff 
            clsVCHStaffCollection Staff = new clsVCHStaffCollection();
            //set the data source to the list of staff in the collection
            lstStaff.DataSource = Staff.StaffList;
            //set the name of the primary key
            lstStaff.DataValueField = "StaffID";
            //set the data field to display
            lstStaff.DataTextField = "StaffFirstName";
            //bind the data to the list
            lstStaff.DataBind();*/
            //int to store the primary key
            Int32 StaffID;
            //Staff Username property
            string StaffUsername;
            //Staff First Name property
            string StaffFirstName;
            //Staff Last Name property
            string StaffLastName;

            //create an instance of the user collection class
            clsVCHStaffCollection StaffCollection = new clsVCHStaffCollection();
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = StaffCollection.Count;
            //clear the list box
            lstStaff.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve StaffID
                StaffID = StaffCollection.StaffList[Index].StaffID;
                //retrieve Username
                StaffUsername = StaffCollection.StaffList[Index].StaffUsername;
                //retrieve FirstName
                StaffFirstName = StaffCollection.StaffList[Index].StaffFirstName;
                //retrieve LastName
                StaffLastName = StaffCollection.StaffList[Index].StaffLastName;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Username - " + StaffUsername + " | First Name - " + StaffFirstName + " | Last Name - " + StaffLastName, StaffID.ToString());
                //add the user to the list
                lstStaff.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display the staff list
            DisplayStaff();
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            //display only staff usernames
            DisplayFilterStaffUsername(txtBxSearch.Text);
        }

        Int32 DisplayFilterStaffUsername(string StaffUsernameFilter)
        {
            //int to store the primary key
            Int32 StaffID;
            //Staff Username property
            string StaffUsername;
            //Staff First Name property
            string StaffFirstName;
            //Staff Last Name property
            string StaffLastName;

            //create an instance of the user collection class
            clsVCHStaffCollection StaffCollection = new clsVCHStaffCollection();
            StaffCollection.ReportByStaffUsername(StaffUsernameFilter);
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = StaffCollection.Count;
            //clear the list box
            lstStaff.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve StaffID
                StaffID = StaffCollection.StaffList[Index].StaffID;
                //retrieve Username
                StaffUsername = StaffCollection.StaffList[Index].StaffUsername;
                //retrieve FirstName
                StaffFirstName = StaffCollection.StaffList[Index].StaffFirstName;
                //retrieve LastName
                StaffLastName = StaffCollection.StaffList[Index].StaffLastName;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Username - " + StaffUsername + " | First Name - " + StaffFirstName + " | Last Name - " + StaffLastName, StaffID.ToString());
                //add the user to the list
                lstStaff.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["StaffID"] = -1;
            //redirect the user back to the staff add page
            Response.Redirect("VCHAStaff.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 StaffID;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //retrieve intended delete records primary key
                StaffID = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["StaffID"] = StaffID;
                //redirect the delete page
                Response.Redirect("VCHAStaff.aspx");
            }
            else //if a user has not selected a staff record to edit
            {
                //display an error
                lblError.Text = "Please select a Staff to edit from the list";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 StaffID;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //retrieve intended delete records primary key
                StaffID = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["StaffID"] = StaffID;
                //redirect the delete page
                Response.Redirect("VCHStaffDelete.aspx");
            }
            else //if a user has not selected a staff record to delete
            {
                //display an error
                lblError.Text = "Please select a Staff member to delete from the list";
            }
        }
    }
}