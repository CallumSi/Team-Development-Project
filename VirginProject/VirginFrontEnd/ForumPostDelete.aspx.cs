using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumPostDelete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 PostID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the post to be deleted from the session object
            PostID = Convert.ToInt32(Session["PostID"]);
        }
        void DeletePost()
        {
            //function to delete the selected record
            //create a new instance of the post book
            clsForumPostCollection PostBook = new clsForumPostCollection();
            //find the record the delete
            PostBook.ThisPost.Find(PostID);
            //delete the record
            PostBook.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeletePost();
            //redirrect back to the main page
            Response.Redirect("ForumPostList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirrect back to the main page
            Response.Redirect("ForumPostList.aspx");
        }
    }
}