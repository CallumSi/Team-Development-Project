using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAnAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //create a new instance of clsforumAdmin   
            clsForumAdmin AnAdmin = new clsForumAdmin();
            //capture the Admin ID
            AnAdmin.AdminFirstName = txtFirstName.Text;
            AnAdmin.AdminLastName = txtLastName.Text;
            AnAdmin.AdminEmail = txtEmailAddress.Text;
            AnAdmin.AdminPassword = txtPassword.Text;
            //store the address in the session object
            Session["AnAdmin"] = AnAdmin;
            //redirect to the viewer page
            Response.Redirect("ForumAdminList.aspx");

        }
    }
}