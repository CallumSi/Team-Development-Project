using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;
namespace VirginFrontEnd
{
    public partial class VirginLogIn : System.Web.UI.Page
    {
        private clsSecurity mSec;
        Int32 UserID;

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

        protected void btnForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginForgotPassword.aspx");
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            bool Error = mSec.Login(txtUsername.Text, txtPassword.Text);
            //if there were no errors
            if (Error == true)
            {
                Session["UserID"] = GetUserID();
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

        protected void btnForumAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckAdmin.aspx");
        }


        public Int32 GetUserID()
        {
            //instantiate the data connection
            clsDataConnection DB = new clsDataConnection();
            //ad the parameter we use to search
            DB.AddParameter("Username", txtUsername.Text);
            //execute the sproc
            DB.Execute("sproc_tblVMUser_FilterByUserName");
            //if record found 
            if (DB.Count == 1)
            {

                UserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);



            }
            else
            {
                //return false if no record ofund
                UserID = -2;
            }

            return UserID;
        }
    }
}