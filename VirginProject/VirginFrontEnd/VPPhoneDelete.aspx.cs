﻿using System;
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
    public partial class VPPhoneDelete : System.Web.UI.Page
    {
        //var to store the primary key of the record to be deleted
        Int32 PhoneID;

        //event handler for the load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of staff id to be deleted from the session object
            PhoneID = Convert.ToInt32(Session["PhoneID"]);
        }

        void DeletePhone()
        {
            //function to delete the selected record
            //create an instance of the phone
            clsVPPhoneCollection AllPhone = new clsVPPhoneCollection();
            AllPhone.ThisPhone.Find(PhoneID);
            //delete the record
            AllPhone.Delete();
        }
        
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the record
            DeletePhone();
            //redirect back to main page
            Response.Redirect("VPPhoneList.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VPPhoneList.aspx");
        }

        protected void btnPhoneHome_Click(object sender, EventArgs e)
        {
            //redirect back to phone home
            Response.Redirect("VPPhoneList.aspx");
        }

        protected void btnViewStaffList_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VPStaffList.aspx");
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VPCustomerList.aspx");
        }

        protected void btnViewPhoneList_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VPPhoneList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect back to the main page
            Response.Redirect("VirginLogin.aspx");
        }
    }
}