using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace VirginFrontEnd
{///This page uses code originated by Matthew Dean.
 ///it is free for use by anybody so long as you give credit to the original author.
 ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    public partial class VPStafforCustomerSelection : System.Web.UI.Page
    {
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserID = Convert.ToInt32(Session["UserID"]);
        }

        protected void btnVPAStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPStaffCheckPin.aspx");
        }

        protected void btnVPACustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPCustomerFirstTime.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }
    }
}