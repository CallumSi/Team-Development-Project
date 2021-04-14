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

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospital.aspx");
        }

        protected void btnAddHospital_Click(object sender, EventArgs e)
        {
            Session["Hospital_ID"] = -1;
            Response.Redirect("VHCHospitalAdd.aspx");
        }
        
        protected void btnListHospital_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalList.aspx");

        }
    }
}