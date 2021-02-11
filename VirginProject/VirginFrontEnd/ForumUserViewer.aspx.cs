using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumUserViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new isntance of the clsForumUser
            clsForumUser AnUser = new clsForumUser();
            //get the data from the session object
            AnUser = (clsForumUser)Session["AnUser"];
            //display the First name for this entry
            Response.Write(AnUser.UserFirstName);
            Response.Write(AnUser.UserLastName);
            Response.Write(AnUser.UserPhoneNumber);
            Response.Write(AnUser.UserEmail);
            Response.Write(AnUser.UserPassword);
        }
    }
}