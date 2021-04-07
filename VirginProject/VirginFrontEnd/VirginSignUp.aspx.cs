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
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            //create an instance of the security class
            clsSecurity Sec = new clsSecurity();
            //get the new users details
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;
            string PasswordConfirm = txtPasswordConfirm.Text;
            string SecretMessage = txtSecret.Text;


            //try to sign up the new user
            lblError.Text = Sec.SignUp(Username, Password, PasswordConfirm, SecretMessage);
            if (lblError.Text == "")
            {
                Response.Redirect("VirginSignUpSuccess.aspx");

            }
        }
    }
}