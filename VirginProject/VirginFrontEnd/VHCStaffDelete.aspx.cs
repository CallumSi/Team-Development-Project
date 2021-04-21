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
    
    public partial class VHCStaffDelete : System.Web.UI.Page
    {
        Int32 Staff_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the staff to be deleted from the session object
            Staff_ID = Convert.ToInt32(Session["Staff_ID"]);

        }

        //function to delete the selected staff record 
        void DeleteStaff()
        {
            //create a new instance of the staff collection class
            clsVHCStaffCollection AllStaffs = new clsVHCStaffCollection();
            //find the record to delete
            AllStaffs.ThisStaff.Find(Staff_ID);
            //delete the record
            AllStaffs.Delete();
        }

        //Yes Button
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteStaff();
            Response.Redirect("VHCStaffList.aspx");

        }

        //No Button
        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCStaffList.aspx");
        }
    }
}