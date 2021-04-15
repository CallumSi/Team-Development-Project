﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VHCHospital : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        //Home Button
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospital.aspx");
        }

        //Add Hospital Button
        protected void btnAddHospital_Click(object sender, EventArgs e)
        {
            Session["Hospital_ID"] = -1;
            Response.Redirect("VHCHospitalAdd.aspx");
        }
        
        //List Hospital Button
        protected void btnListHospital_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalList.aspx");
        }
    }
}