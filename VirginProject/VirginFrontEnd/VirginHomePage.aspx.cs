using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VirginFrontEnd
{
    public partial class VirginHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }

        protected void btnVirginMovies_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnCarHire_Click(object sender, EventArgs e)
        {
            Response.Redirect("VCHCustomerDefault.aspx"); 
        }
    }
}