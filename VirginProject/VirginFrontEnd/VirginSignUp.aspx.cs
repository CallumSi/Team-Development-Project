using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VirginSignUp : System.Web.UI.Page
    {
        Int32 UserID;
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
            lblErrorMessage.Text = Sec.SignUp(Username, Password, PasswordConfirm, SecretMessage);
            if (lblErrorMessage.Text == "")
            {
                Session["UserID"] = GetUserID();
                Response.Redirect("VirginSignUpSuccess.aspx");

            }
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

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }
    }
}