﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;


namespace VirginFrontEnd
{
    public partial class VPStaffCheckPin : System.Web.UI.Page
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

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            //try to sign in a record any errors
            bool Error = mSec.Pin(txtStaffPin.Text);
            //if there were no errors
            if (Error == true)
            {
                Response.Redirect("VPStaffList.aspx");
            }
            else
            {
                //else show any errors
                lblPinError.Text = "Incorrect pin, please try again";
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("VPStafforCustomerSelection.aspx");
        }
    }
}