using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class MarketplaceWelcome : System.Web.UI.Page
    {
        int UserID = 4;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFirstTime_Click(object sender, EventArgs e)
        {
            //store data in session object so we can pass it to next page
            Session["UserID"] = UserID;
            //redirect to edit user details page
            Response.Redirect("AnMarketplaceUser.aspx");
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            Session["UserID"] = UserID;
            Response.Redirect("MarketplaceHome2.aspx");
        }
    }
}