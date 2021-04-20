using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class AdminHomePage : System.Web.UI.Page
    {
        Int32 AdminID;
        protected void Page_Load(object sender, EventArgs e)
        {

            AdminID = Convert.ToInt32(Session["AdminID"]);
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {

            Session["AdminID"] = AdminID;
        }

        protected void btnVirginMovies_Click(object sender, EventArgs e)
        {

        }

        protected void btnCarHire_Click(object sender, EventArgs e)
        {

        }

        protected void btnVirginPhone_Click(object sender, EventArgs e)
        {

        }

        protected void btnMarketPlace_Click(object sender, EventArgs e)
        {

        }

        protected void btnVirginGP_Click(object sender, EventArgs e)
        {

        }

        protected void btnVirginForum_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumAdminHome.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumAdminLogIn.aspx");
        }
    }
}