using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAdminForgotPassword : System.Web.UI.Page
    {
        private clsForumAdminSecurity mSec;
        public clsForumAdminSecurity Sec
        {
            get
            {
                return mSec;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            //change the password and record the outcome
            string Outcome = mSec.ChangePassword(txtUsername.Text, txtPassword.Text, txtPasswordConfirm.Text, txtSecret.Text);
            //display the outcome
            lblError.Text = Outcome;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumAdminLogIn.aspx");
        }
    }
}