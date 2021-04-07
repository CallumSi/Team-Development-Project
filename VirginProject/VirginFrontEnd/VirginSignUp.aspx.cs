using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VirginSignUp : System.Web.UI.Page
    {
        private clsSecurity mSec;


        public clsSecurity Sec
        {
            get
            {
                return mSec;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            mSec = new clsSecurity();
        }

      

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            bool Error = mSec.Login(txtUsername.Text, txtPassword.Text);
            //if there were no errors
            if (Error == true)
            {
                Response.Redirect("VirginHomePage.aspx");
            }
            else

            {
                //otherwise show any errors
                lblError.Text = "Failed Login";
            }
        }

        protected void btnSignUp_Click1(object sender, EventArgs e)
        {
            Response.Redirect("VirginSignUp.aspx");
        }

        protected void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginForgotPassword.aspx");
        }
    }
}