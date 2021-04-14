using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPStaffList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //the first time the page is displayed 
            if (IsPostBack == false)
            {
                //update the list box
                DisplayVPStaff();
            }
        }

        void DisplayVPStaff()
        {
            //create an instance of the staff collection 
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            //set the data source to the staff in staff collection 
            lstStaff.DataSource = AllStaff.StaffList;
            //set the same of the primary key
            lstStaff.DataValueField = "Staff_ID";
            //set the data field to display
            lstStaff.DataTextField = "Staff_FirstName";
            //bind the data to the list
            lstStaff.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["Staff_ID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnVPStaff.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 Staff_ID;
            //if the record has been selected from the list 
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Staff_ID = Convert.ToInt32(lstStaff.SelectedIndex);
                //store the data in the session object 
                Session["Staff_ID"] = Staff_ID;
                //redirect to the delete page 
                Response.Redirect("VPStaffDelete.aspx");
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
            Int32 Staff_ID;
            //if the record has been selected from the list 
            if (lstStaff.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                Staff_ID = Convert.ToInt32(lstStaff.SelectedIndex);
                //store the data in the session object 
                Session["Staff_ID"] = Staff_ID;
                //redirect to the delete page 
                Response.Redirect("AnVPStaff.aspx");
            }
            else
            {
                //if no record has been selected 
                //display an error
                lblError.Text = "Please select a record to edit from the list";
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            ////display all staff 
            //DisplayFirstName("");
        }

        //Int32 DisplayFirstName(string VPStaffFilter)
        //{
        //    Int32 Staff_ID;
        //    string Staff_FirstName;
        //    //create an instance of the staff collection
        //    clsVPStaffCollection Staff_FirstName = new clsVPStaffCollection();
        //    //invoke the staff first name filter
        //    Staff_FirstName.fi
        //}

        
    }
}