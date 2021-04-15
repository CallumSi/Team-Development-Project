using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VPStaffDelete : System.Web.UI.Page
    {

        //var to store the primary ket of the record to be deleted
        Int32 Staff_ID;


        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of staff id to be deleted from the session object
            Staff_ID = Convert.ToInt32(Session["Staff_ID"]);
        }

        void DeleteStaff()
        {
            //function to delete the selected record
            //create an instance of the staff
            clsVPStaffCollection AllStaff = new clsVPStaffCollection();
            AllStaff.ThisStaff.Find(Staff_ID);
            //delete the record
            AllStaff.Delete();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the recird
            DeleteStaff();
            //redirect back to the main page
            Response.Redirect("VPStaffList.aspx");
        }
    }
}