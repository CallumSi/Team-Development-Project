using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMAdminCheckPin : System.Web.UI.Page
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