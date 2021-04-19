using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAdminLogIn : System.Web.UI.Page
    {
        private clsForumAdminSecurity mSec;
        Int32 AdminID;

        public clsForumAdminSecurity Sec
        {
            get
            {
                return mSec;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            mSec = new clsForumAdminSecurity();
        }
        public Int32 GetAdminID()
        {
            //instantiate the data connection
            clsDataConnection DB = new clsDataConnection();
            //ad the parameter we use to search
            DB.AddParameter("Username", txtUsername.Text);
            //execute the sproc
            DB.Execute("sproc_tblForumAdminSecurity_FilterbyUsername");
            //if record found 
            if (DB.Count == 1)
            {

                AdminID = Convert.ToInt32(DB.DataTable.Rows[0]["AdminID"]);



            }
            else
            {
                //return false if no record ofund
                AdminID = -2;
            }

            return AdminID;
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            bool Error = mSec.Login(txtUsername.Text, txtPassword.Text);
            //if there were no errors
            if (Error == true)
            {
                Response.Redirect("ForumAdminHome.aspx");
            }
            else

            {
                //otherwise show any errors
                lblError.Text = "Failed Login";
            }
        }

        protected void btnSignUp_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ForumAdminSignUp.aspx");
        }

        protected void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumAdminForgotPassword.aspx");
        }
    }
}