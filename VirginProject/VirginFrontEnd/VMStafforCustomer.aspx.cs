using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VMStafforCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVMAStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMAdminCheckPin.aspx");
        }

        protected void btnVMACustomer_Click(object sender, EventArgs e)
        {

            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }
    }
}