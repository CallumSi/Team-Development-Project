using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

///This page uses code originated by Matthew Dean.
///it is free for use by anybody so long as you give credit to the original author.
///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019

namespace VirginFrontEnd
{
    public partial class VMAdminCheckPin : System.Web.UI.Page
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

        protected void btnConfirmPin_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            bool Error = mSec.Pin(txtAdminPin.Text);
            //if there were no errors
            if (Error == true)
            {
                Response.Redirect("VMAdminLogIn.aspx");
            }
            else

            {
                //otherwise show any errors
                lblAdminPinError.Text = "Incorrect Pin. Please try again.";
            }
        }

        protected void btnBackHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStafforCustomer.aspx");
        }
    }
}