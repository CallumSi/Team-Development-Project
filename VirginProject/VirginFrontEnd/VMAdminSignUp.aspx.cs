using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

///This page uses code originated by Matthew Dean.
///it is free for use by anybody so long as you give credit to the original author.
///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019

namespace VirginFrontEnd
{
    public partial class VMAdminSignUp : System.Web.UI.Page
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
                Response.Redirect("VMAdminLogin.aspx");

            }
            else
            {
                lblError.Text = lblError.Text;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMAdminLogin.aspx");
        }
    }
}