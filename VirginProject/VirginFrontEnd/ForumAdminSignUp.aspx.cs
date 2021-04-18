using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAdminSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            //create an instance of the security class
            clsForumAdminSecurity Sec = new clsForumAdminSecurity();
            //get the new users details
            string AdminUserName = txtUsername.Text;
            string AdminPassword = txtPassword.Text;
            string PasswordConfirm = txtPasswordConfirm.Text;
            string SecretMessage = txtSecret.Text;


            //try to sign up the new user
            lblError.Text = Sec.AdminSignUp(AdminUserName, AdminPassword, PasswordConfirm, SecretMessage);
            if (lblError.Text == "")
            {
                Response.Redirect("ForumAdminLogIn.aspx");

            }
            else
            {
                lblError.Text = lblError.Text;
            }
        }
    }
}