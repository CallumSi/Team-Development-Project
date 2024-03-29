﻿using System;
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

    public partial class VMAdminForgotPassword : System.Web.UI.Page
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

        protected void btnSignUp_Click(object sender, EventArgs e)
        {            
            //change the password and record the outcome
            string Outcome = mSec.ChangePassword(txtUsername.Text, txtPassword.Text, txtPasswordConfirm.Text, txtSecret.Text);
            //display the outcome
            lblError.Text = Outcome;

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMAdminLogin.aspx");
        }
    }
}