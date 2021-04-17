﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VirginHomePage : System.Web.UI.Page
    {
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {

           UserID = Convert.ToInt32(Session["UserID"]);
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {

            Session["UserID"] = UserID;
        }
        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnVirginMovies_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnMarketPlace_Click(object sender, EventArgs e)
        {
            Response.Redirect("MarketplaceWelcome.aspx");
        }
    }
}