using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    ///This page uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    
    public partial class VHCStaffCheckPin : System.Web.UI.Page
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
                lblError.Text = "⚠️ ERROR: CANNOT BE BLANK! PLEASE ENTER THE CORRECT PIN TO PROCEED!";

            }

            else

            {
                //otherwise show any errors
                lblError.Text = "⚠️ ERROR: INCORRECT PIN! PLEASE TRY AGAIN.";
            }
        }
    }
}