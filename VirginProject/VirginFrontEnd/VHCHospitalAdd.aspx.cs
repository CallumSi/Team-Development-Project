using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VHCHospitalAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Home_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospital.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void btnClose_Click1(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospital.aspx");
        }
    }
}