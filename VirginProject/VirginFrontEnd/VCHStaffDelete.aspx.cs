using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHStaffDelete : System.Web.UI.Page
    {
        //var to store primary key for record to be deleted
        Int32 StaffID;

        //event handler for load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the primary key of the Staff that will be deleted from the session object
            StaffID = Convert.ToInt32(Session["StaffID"]);
        }

        //function to delete a single customer
        void DeleteStaff()
        {
            //create an instance of the customer collection class
            clsVCHStaffCollection StaffCollection = new clsVCHStaffCollection();
            //find the customer record to be deleted 
            StaffCollection.ThisStaff.Find(StaffID);
            //delete the record
            StaffCollection.Delete();
        }

        //event handle to confirm customer record delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteStaff();
            //redirect the user to the customer list page
            Response.Redirect("VCHStaffList.aspx");
        }

        //event handle to cancel staff record delete button
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect the user to the staff list page, without having deleted a staff record
            Response.Redirect("VCHStaffList.aspx");
        }
    }
}