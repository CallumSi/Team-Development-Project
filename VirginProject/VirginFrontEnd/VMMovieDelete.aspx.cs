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
    public partial class VMMovieDelete : System.Web.UI.Page
    {
        Int32 VMMovieID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the customer to be deleted from the session object
            VMMovieID = Convert.ToInt32(Session["VMMovieID"]);
        }

        //function to delete the selected movie record 
        void DeleteMovie()
        {
            //create a new instance of the movie collection class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //find the record to delete
            allMovies.ThisMovie.Find(VMMovieID);
            //delete the record
            allMovies.Delete();
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect to the main page
            Response.Redirect("VMStaffMovie.aspx");
        }

        protected void btnDeleteHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffMovie.aspx");
        }

        protected void btnYES_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteMovie();
            //redirect to the main page
            Response.Redirect("VMStaffMovie.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            //redirect to the staff list
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            //redirect to the customer list
            Response.Redirect("VMCustomerList.aspx");
        }

        protected void btnStaffMovie_Click(object sender, EventArgs e)
        {
            //redirect to the staff movie list
            Response.Redirect("VMStaffMovie.aspx");
        }

        protected void btnVMStaffList_Click(object sender, EventArgs e)
        {
            //redirect to the staff list
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //redirect to the login page
            Response.Redirect("VirginLogin.aspx");
        }
    }
}