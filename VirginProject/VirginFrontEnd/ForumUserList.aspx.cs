using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumUserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayUser();
            }
            void DisplayUser()
            {
                //create an instance of the County Collection
                clsForumUserCollection Users = new clsForumUserCollection();
                //set the data source to the list of countries in the collection
                lstUserListBox.DataSource = Users.UserList;
                //set the name of the primary key
                lstUserListBox.DataValueField = "UserID";
                //set the data field to display
                lstUserListBox.DataTextField = "UserFirstName";
                //bind the data to the list
                lstUserListBox.DataBind();
            }
        }
    }
}