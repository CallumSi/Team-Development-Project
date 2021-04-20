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
    
    public partial class VHCStaffList : System.Web.UI.Page
    {
        Int32 Staff_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of staff to be processed
            Staff_ID = Convert.ToInt32(Session["Staff_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of staff
                DisplayStaff();
            }
        }

        private void DisplayStaff()
        {
            //create an instance of the staff class
            clsVHCStaffCollection AllStaff = new clsVHCStaffCollection();
            //set the data source to the list of staff in the collection 
            lstStaff.DataSource = AllStaff.StaffList;
            //set the name of the primary key 
            lstStaff.DataValueField = "Staff_ID";
            //set the data field to display 
            lstStaff.DataTextField = "Staff_Firstname";
            //bind the data to the list 
            lstStaff.DataBind();
        }

        //AFTER FILTER SETTINGS
        Int32 DisplayStaff(string StaffFilter)
        {
            Int32 Staff_ID; //Var to store the primary key  
            String Staff_Title; //Var to store the Staff Title
            String Staff_Firstname; //Var to store the Staff Firstname
            String Staff_Lastname; //Var to store the Staff Lastname
            String Staff_Email; //Var to store the Staff Email
            String Staff_Username; //Var to store the Staff Username
            String Staff_Password; //Var to store the Staff Password
            String Staff_Role; //Var to store the Staff Role
            Boolean Staff_Status; //Var to store the Staff Status
            //create an instance of the staff class
            clsVHCStaffCollection StaffSearch = new clsVHCStaffCollection();
            //invoke the staff firstname filter
            StaffSearch.ReportByStaff(StaffFilter);
            Int32 RecordCount; //Var to store the count of records 
            Int32 Index = 0; //Var to store the index for the loop
            RecordCount = StaffSearch.Count; //get the count of records 
            lstStaff.Items.Clear(); //clear the list box
            while (Index < RecordCount) //While there are records to process
            {
                Staff_ID = StaffSearch.StaffList[Index].Staff_ID; //get primary key 
                Staff_Title = StaffSearch.StaffList[Index].Staff_Title; //get Staff Title 
                Staff_Firstname = StaffSearch.StaffList[Index].Staff_Firstname; //get Staff Firstname 
                Staff_Lastname = StaffSearch.StaffList[Index].Staff_Lastname; //get Staff Lastname 
                Staff_Email = StaffSearch.StaffList[Index].Staff_Email; //get Staff Email
                Staff_Username = StaffSearch.StaffList[Index].Staff_Username; //get Staff Username
                Staff_Password = StaffSearch.StaffList[Index].Staff_Password; //get Staff Password
                Staff_Role = StaffSearch.StaffList[Index].Staff_Role; //get Staff Role
                Staff_Status = StaffSearch.StaffList[Index].Staff_Status; //get Staff Status
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(" [" + Staff_ID + "] " + " " + Staff_Title + " " + Staff_Firstname + " " + Staff_Lastname, Staff_ID.ToString());
                lstStaff.Items.Add(NewEntry);
                Index++;
            }

            return RecordCount; //return the count of records found
        }

        //Close Button
        protected void btnListClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCStaff.aspx");
        }

        protected void btnDisplayAllStaffs_Click(object sender, EventArgs e)
        {

            //display all staff
            Int32 RecordCount;
            RecordCount = DisplayStaff("");
            lblError.Text = RecordCount + " RECORDS FOUND ";
        }

        protected void btnStaffApplyFilter_Click(object sender, EventArgs e)
        {
            if (txtStaffSearch.Text.Length == 0)
            {
                lblError.Text = "⚠️ SYSTEM ERROR:" + " " + "PLEASE ENTER A VALID STAFF FIRSTNAME";
            }

            else
            {
                Int32 RecordCount;
                RecordCount = DisplayStaff(txtStaffSearch.Text);
                lblError.Text = RecordCount + " RECORDS FOUND ";
            }
        }

        protected void btnEditStaff_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 Staff_ID;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key of the record to edit
                Staff_ID = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["Staff_ID"] = Staff_ID;
                //redirect to the edit page
                Response.Redirect("VHCStaffAdd.aspx");
            }

            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "⚠️ SYSTEM ERROR:" + " " + "PLEASE SELECT A RECORD TO UPDATE FROM THE LIST!";
            }
        }

        protected void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 Staff_ID;
            //if a record has been selected from the list
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key of the record to delete
                Staff_ID = Convert.ToInt32(lstStaff.SelectedValue);
                //store the data in the session object
                Session["Staff_ID"] = Staff_ID;
                //redirect to the delete page
                Response.Redirect("VHCStaffDelete.aspx");
            }

            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "⚠️ SYSTEM ERROR:" + " " + "PLEASE SELECT A RECORD TO BE REMOVED FROM THE LIST!";
            }
        }
    }
}