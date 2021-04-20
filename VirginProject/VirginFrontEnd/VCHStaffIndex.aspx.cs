using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHStaffIndex : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 StaffID;
        Int32 AdminID;

        protected void Page_Load(object sender, EventArgs e)
        {
            AdminID = Convert.ToInt32(Session["AdminID"]);
            //check if user exisits
            //create an instance of the staff collection class
            clsVCHStaffCollection SomeStaff = new clsVCHStaffCollection();
            //find the record to update
            if (SomeStaff.ThisStaff.FindByAdminID(AdminID) == false)
            {
                //change button text to create account and ididcate new yser
                btnNewStaff.Text = "Create Account";
                btnReturningStaff.Visible = false;
                StaffID = -1;
            }
            else
            {
                //button changed for edit account details
                btnNewStaff.Text = "Edit Account Details";
                SomeStaff.ThisStaff.FindByAdminID(AdminID);
                StaffID = SomeStaff.ThisStaff.StaffID;
            }
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Save the StaffID & AdminID when a page unload event happens
            Session["StaffID "] = StaffID;
            Session["AdminID"] = AdminID;
        }

        //event handler for the btnNewStaff
        protected void btnNewStaff_Click(object sender, EventArgs e)
        {
            //store data in session object to pass it onto the next page
            Session["StaffID"] = StaffID;
            Session["AdminID"] = AdminID;
            //direct the staff to the staff details page so they can supply additional info
            Response.Redirect("VCHAStaff.aspx");
        }

        //event handler for the btnReturningStaff
        protected void btnReturningStaff_Click(object sender, EventArgs e)
        {
            //store data in session object to pass it onto the next page
            Session["StaffID"] = StaffID;
            //direct the staff to the staff home page
            Response.Redirect("VCHStaffDefault.aspx");
        }
    }
}