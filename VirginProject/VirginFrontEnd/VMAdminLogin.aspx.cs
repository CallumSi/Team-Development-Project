using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;


namespace VirginFrontEnd
{
    public partial class VMAdminLogin : System.Web.UI.Page
    {
        private clsVMAdminSecurity mSec;
        public clsVMAdminSecurity Sec
        {
            get
            {
                return mSec;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            mSec = new clsVMAdminSecurity();
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            bool Error = mSec.Login(txtUsername.Text, txtPassword.Text);
            //if there were no errors
            if (Error == true)
            {
                Response.Redirect("VMStaffList.aspx");
            }
            else

            {
                //otherwise show any errors
                lblError.Text = "Failed Login";
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMAdminSignUp.aspx");
        }

        protected void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMAdminForgotPassword.aspx");
        }
    }
}