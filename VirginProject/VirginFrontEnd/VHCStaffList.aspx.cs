﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VHCStaffList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Close Button
        protected void btnListClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCStaff.aspx");
        }
    }
}