using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VHCHospital : System.Web.UI.Page
    {
        Int32 Patient_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        //Add Hospital Button
        protected void btnAddHospital_Click(object sender, EventArgs e)
        {
            Session["Hospital_ID"] = -1;
            Response.Redirect("VHCHospitalAdd.aspx");
        }
        
        //List Hospital Button
        protected void btnListHospital_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalList.aspx");
        }

        //Log Out Button
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCMainMenu.aspx");

        }

        protected void btnAddPatient_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["Patient_ID"] = -1;
            Response.Redirect("VHCPatientAdd.aspx");
        }

        protected void btnListPatients_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCPatientList.aspx");

        }
    }
}