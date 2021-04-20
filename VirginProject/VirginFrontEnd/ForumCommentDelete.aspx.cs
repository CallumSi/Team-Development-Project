using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumCommentDelete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 CommentID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the post to be deleted from the session object
            CommentID = Convert.ToInt32(Session["CommentID"]);
        }
        //function to delete the selected record
        void DeleteComment()
        {
            //create a new instance of the post book
            clsForumCommentCollection CommentBook = new clsForumCommentCollection();
            //find the record the delete
            CommentBook.ThisComment.Find(CommentID);
            //delete the record
            CommentBook.Delete();
        }
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteComment();
            //redirrect back to the main page
            Response.Redirect("ForumCommentList.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //redirrect back to the main page
            Response.Redirect("ForumCommentList.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");
        }
    }
}