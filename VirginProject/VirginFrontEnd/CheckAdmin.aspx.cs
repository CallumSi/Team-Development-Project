using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
  
    public partial class CheckAdmin : System.Web.UI.Page
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
            mSec = new clsForumAdminSecurity();
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            bool Error = mSec.Pin(txtPin.Text);
            //if there were no errors
            if (Error == true)
            {
                Response.Redirect("ForumAdminLogIn.aspx");
            }
            else

            {
                //otherwise show any errors
                lblError.Text = "Incorrect Pin";
            }
        }
    }
}