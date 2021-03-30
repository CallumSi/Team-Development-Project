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
            //create an instance of the Staff 
            clsVCHStaffCollection Staff = new clsVCHStaffCollection();
            //set the data source to the list of staff in the collection
            lstStaff.DataSource = Staff.StaffList;
            //set the name of the primary key
            lstStaff.DataValueField = "StaffID";
            //set the data field to display
            lstStaff.DataTextField = "StaffFirstName";

            /*//set the data field to display
            lstStaff.DataTextField = "StaffUsername";
            //set the data field to display
            lstStaff.DataTextField = "StaffFirstName" + "StaffUsername";*/

            //bind the data to the list
            lstStaff.DataBind();
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display the staff list
            DisplayStaff();
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["StaffID"] = -1;
            //once complete redirect the user back to the main page
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
            else //if a user has not selected a staff record to delete
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