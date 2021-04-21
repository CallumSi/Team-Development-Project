using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMStafforCustomer : System.Web.UI.Page
    {
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserID = Convert.ToInt32(Session["UserID"]);
        }

        protected void btnVMAStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMAdminCheckPin.aspx");
        }

        protected void btnVMACustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMCustomerFirstTime.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }
    }
}