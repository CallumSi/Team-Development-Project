using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAnPost : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 PostID;
        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the user to be processed 
            PostID = Convert.ToInt32(Session["PostID"]);
            if (IsPostBack == false)
            {
                //populate the list of posts
                DisplayPost();
                //if this is not a new record
                if (PostID != -1)
                {
                    //display the current data for the record
                    DisplayPost();
                }
            }
        }
        void DisplayPost()
        {
            //create an instance of the Post book
            clsForumPostCollection PostBook = new clsForumPostCollection();
            //find the record to update
            PostBook.ThisPost.Find(PostID);
            //display the data for this record
            txtTitle.Text = PostBook.ThisPost.PostTitle;
            txtMessage.Text = PostBook.ThisPost.PostMessage;

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (PostID == -1)
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
        //function for adding new records
        void Add()
        {
            //create an instance of the Post book
            clsForumPostCollection PostBook = new clsForumPostCollection();
            //validate the data on the web form
            String Error = PostBook.ThisPost.Valid(txtTitle.Text, txtMessage.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //get the data entered by the post
                PostBook.ThisPost.PostTitle = txtTitle.Text;
                PostBook.ThisPost.PostMessage = txtMessage.Text;
                //add the record
                PostBook.Add();
                //Redirect back to the main page
                Response.Redirect("ForumPostList.aspx");
            }
            else
            {
                //report an error
                lblPostError.Text = "There has been a problem with the information that's been entered. Please try again." + Error;
            }

        }
        //function for updating records
        void Update()
        {
            //create an instance of the Post book
            clsForumPostCollection PostBook = new clsForumPostCollection();
            //validate the data on the web form
            String Error = PostBook.ThisPost.Valid(txtTitle.Text, txtMessage.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                PostBook.ThisPost.Find(PostID);
                //get the data entered by the Post
                PostBook.ThisPost.PostTitle = txtTitle.Text;
                PostBook.ThisPost.PostMessage = txtMessage.Text;
                //update the record 
                PostBook.Update();
                //Redirect back to the Post list page
                Response.Redirect("ForumPostList.aspx");
            }
            else
            {
                //report an error
                lblPostError.Text = "There has been a problem with the information that's been entered. Please try again." + Error;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //Redirect back to the Post list page
            Response.Redirect("ForumPostList.aspx");
        }
    }
}