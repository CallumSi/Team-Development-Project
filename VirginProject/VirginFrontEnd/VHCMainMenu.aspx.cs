using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VHCMainMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Staff Button
        protected void btnStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCStaff.aspx");
        }

        //Patient Button
        protected void btnPatient_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCAppointmentList.aspx");

        }
    }
}