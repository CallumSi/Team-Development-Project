using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumUserDelete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the user to be deleted from teh session object
            UserID = Convert.ToInt32(Session["UserID"]);
        }
        void DeleteUser()
        {
            //function to delete the selected record
            //create a new instance of teh User book
            clsForumUserCollection UserBook = new clsForumUserCollection();
            //find the record the delete
            UserBook.ThisUser.Find(UserID);
            //delete the record
            UserBook.Delete();
        }
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteUser();
            //redirrect back to the main page
            Response.Redirect("ForumUserList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirrect back to the main page
            Response.Redirect("ForumUserList.aspx");
        }
    }
}