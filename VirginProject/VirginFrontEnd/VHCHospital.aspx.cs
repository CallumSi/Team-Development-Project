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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalAdd.aspx");
        }

        protected void Home_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospital.aspx");
        }

        protected void btnEditHospital_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalEdit.aspx");

        }

        protected void btnHospitalList_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalList.aspx");
        }
    }
}