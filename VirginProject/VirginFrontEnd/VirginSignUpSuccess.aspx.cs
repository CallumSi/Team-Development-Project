using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VirginSignUpSuccess : System.Web.UI.Page
    {
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {

            UserID = Convert.ToInt32(Session["UserID"]);
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {

            Session["UserID"] = UserID;
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginHomePage.aspx");

        }
    }
}