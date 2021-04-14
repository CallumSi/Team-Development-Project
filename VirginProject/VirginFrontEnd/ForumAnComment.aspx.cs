using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAnComment : System.Web.UI.Page
    {
        //variable to store the postID
        Int32 PostID;
        //variable to store the PostTitle
        string PostTitle;
        //variable to store the CommentID
        Int32 CommentID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the post title
            lblTitle.Text = PostTitle;
            PostID = Convert.ToInt32(Session["PostID"]);
            PostTitle = Convert.ToString(Session["PostTitle"]);
            CommentID = Convert.ToInt32(Session["CommentID"]);
            if (IsPostBack == false)
            {
                //populate the list of post titles
                DisplayPostTitle();
                if (PostID != -1)
                {
                    //display the current data for the record
                    DisplayComment();
                }

            }
        }
        void DisplayPostTitle()
        {
            clsForumPostCollection CommentBook = new clsForumPostCollection();
            //find the record 
            CommentBook.ThisPost.Find(PostID);
            //display the data for this record
            lblTitle.Text = PostTitle;
        }
        void DisplayComment()
        {
            //create an instance of the user book
            clsForumCommentCollection CommentBook = new clsForumCommentCollection();
            //find the record to update
            CommentBook.ThisComment.Find(CommentID);
            //display the data for this record
            txtComment.Text = CommentBook.ThisComment.CommentMessage;
        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (CommentID == -1)
            {
                //add the new record
                Add();
            }
            else
            {
                //update the record
                Update();
            }
        }
        void Add()
        {
            //create an instance of the post collection
            clsForumCommentCollection Comment = new clsForumCommentCollection();
            //validate the data on the web form
            String Error = Comment.ThisComment.Valid(txtComment.Text);
            //if the data entered by the user
            if (Error == "")
            {
                //get the comment message
                string CommentMessage = Convert.ToString(txtComment.Text);
                //Add the new commentc
                Comment.AddComment(PostID, CommentMessage);
                //redirect to the post page
                Response.Redirect("ForumCommentList.aspx");
            }
            else
            {
                //report the error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }
        void Update()
        {
            //create an instance of the user book
            clsForumCommentCollection Comment = new clsForumCommentCollection();
            //validate the data on the web form
            String Error = Comment.ThisComment.Valid(txtComment.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                Comment.ThisComment.Find(CommentID);
                //get the data entered by the user
                Comment.ThisComment.CommentMessage = txtComment.Text;
                //update the record 
                Comment.Update();
                //Redirect back to the user list page
                Response.Redirect("ForumCommentList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There has been a problem with the information that's been entered. Please try again." + Error;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect back to post list
            Response.Redirect("ForumPostList.aspx");
        }
    }
}