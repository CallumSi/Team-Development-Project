using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    ///This page uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    
    public partial class VHCStaffCheckPin : System.Web.UI.Page
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
            bool Error = mSec.Pin(txtStaffPin.Text);
            //if there were no errors
            if (Error == true)
            {
                Response.Redirect("VHCStaff.aspx");
            }

            if (txtStaffPin.Text.Length == 0)
            {
                //otherwise show any errors
                lblError.Text = "⚠️ CANNOT BE BLANK! PLEASE ENTER THE CORRECT PIN TO PROCEED!";

            }

            else

            {
                //otherwise show any errors
                lblError.Text = "⚠️ INCORRECT PIN! PLEASE TRY AGAIN.";
            }
        }
    }
}