using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMStaffDelete : System.Web.UI.Page
    {
        Int32 VMStaffID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff to be deleted from the session object
            VMStaffID = Convert.ToInt32(Session["VMStaffID"]);
        }

        //function to delete the selected staff record 
        void DeleteStaff()
        {
            //create a new instance of the staff collection class
            clsVMStaffCollection AllStaff = new clsVMStaffCollection();
            //find the record to delete
            AllStaff.ThisStaff.Find(VMStaffID);
            //delete the record
            AllStaff.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteStaff();
            //redirect to the main page
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnAddMovie_Click(object sender, EventArgs e)
        {
            //redirect back to the Staff list
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            //redirect back to the customer list 
            Response.Redirect("VMCustomerList.aspx");
        }

        protected void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            //redirect back to the movie list page
            Response.Redirect("VMStaffMovie.aspx");
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            //redirect back to the login page
            Response.Redirect("VirginLogin.aspx");
        }
    }
}