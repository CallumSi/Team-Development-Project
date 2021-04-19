using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VPStafforCustomerSelection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVPAStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnVPACustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPCustomerPhoneList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }
    }
}