using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class ForumAdminHomePage : System.Web.UI.Page
    {
        Int32 AdminID;
        protected void Page_Load(object sender, EventArgs e)
        {
            AdminID = Convert.ToInt32(Session["AdminID"]);
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumUserList.aspx");
        }

        protected void btnAdminAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumAdminList.aspx");
        }

        protected void btnPosts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumPostList.aspx");
        }

        protected void btnComments_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumCommentList.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumAdminLogIn.aspx");
        }
    }
}