using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

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
            clsVMAdminSecurity Sec = new clsVMAdminSecurity();
            //get the new users details
            string VMAdminUsername = txtUsername.Text;
            string VMAdminPassword = txtPassword.Text;
            string VMPasswordConfirm = txtPasswordConfirm.Text;
            string SecretMessage = txtSecret.Text;

            //try to sign up the new user
            lblError.Text = Sec.AdminSignUp(VMAdminUsername, VMAdminPassword, VMPasswordConfirm, SecretMessage);
            if (lblError.Text == "")
            {
                Response.Redirect("VMAdminLogIn.aspx");

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