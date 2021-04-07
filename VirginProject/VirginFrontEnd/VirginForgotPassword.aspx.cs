using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VirginForgotPassword : System.Web.UI.Page
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

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            //change the password and record the outcome
            string Outcome = mSec.ChangePassword(txtUsername.Text, txtPassword.Text, txtPasswordConfirm.Text, txtSecret.Text);
            //display the outcome
            lblError.Text = Outcome;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }
    }
}