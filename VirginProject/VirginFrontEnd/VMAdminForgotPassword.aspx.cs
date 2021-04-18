using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{

    public partial class VMAdminForgotPassword : System.Web.UI.Page
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

        protected void btnSignUp_Click(object sender, EventArgs e)
        {            
            //change the password and record the outcome
            string Outcome = mSec.ChangePassword(txtUsername.Text, txtPassword.Text, txtPasswordConfirm.Text, txtSecret.Text);
            //display the outcome
            lblError.Text = Outcome;

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMAdminLogIn.aspx");
        }
    }
}