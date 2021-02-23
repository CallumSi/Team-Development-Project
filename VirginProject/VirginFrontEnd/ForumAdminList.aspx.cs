using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAdminList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayAdmin();
            }
            void DisplayAdmin()
            {
                //create an instance of the County Collection
                clsForumAdminCollection Admins = new clsForumAdminCollection();
                //set the data source to the list of countries in the collection
                lstForumAdmin.DataSource = Admins.AdminList;
                //set the name of the primary key
                lstForumAdmin.DataValueField = "AdminID";
                //set the data field to display
                lstForumAdmin.DataTextField = "AdminUserName";
                //bind the data to the list
                lstForumAdmin.DataBind();
            }
        }

        protected void lstForumAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}