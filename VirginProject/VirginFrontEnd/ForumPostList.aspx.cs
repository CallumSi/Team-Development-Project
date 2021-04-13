using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumPostList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayPosts();
            }
        }
        void DisplayPosts()
        {
            //create an instance of the County Collection
            clsForumPostCollection posts = new clsForumPostCollection();
            //set the data source to the list of countries in the collection
            lstPostlistbox.DataSource = posts.PostList;
            //set the name of the primary key
            lstPostlistbox.DataValueField = "PostID";
            //set the data field to display
            lstPostlistbox.DataTextField = "PostTitle";
            //bind the data to the list
            lstPostlistbox.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["PostID"] = -1;
            //redirect to the data entry page
            Response.Redirect("ForumAnPost.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be editied
            Int32 PostID;
            //if a record has been selected from the list
            if (lstPostlistbox.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                PostID = Convert.ToInt32(lstPostlistbox.SelectedValue);
                //store the data in the session object
                Session["PostID"] = PostID;
                //redirect to the edit page
                Response.Redirect("ForumAnPost.aspx");
            }
            //if no recod has been selected
            else
            {
                //display an error
                lblPostError.Text = "Please make you select a record from the list";

            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 PostID;
            //if a record has been selected from the list
            if (lstPostlistbox.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                PostID = Convert.ToInt32(lstPostlistbox.SelectedValue);
                //store the data in the session object
                Session["PostID"] = PostID;
                //redirect to the delete page
                Response.Redirect("ForumPostDelete.aspx");
            }
            //if no recod has been selected
            else
            {
                //display an error
                lblPostError.Text = "Please make you select a record from the list";

            }
        }

        protected void btnComment_Click(object sender, EventArgs e)
        {
            //var to store the post title
            string PostTitle;
            Int32 PostID;
            //var to store the comment message
            //string CommentMessage;
            //clear any previous errors
            lblPostError.Text = "";
            //check to see that an entry has been selected
            if (lstPostlistbox.SelectedIndex != -1)
            {
                PostTitle = lstPostlistbox.SelectedItem.Text;
                //get the post title
                PostID = Convert.ToInt32(lstPostlistbox.SelectedIndex);
                Session["PostID"] = PostID;
                Session["PostTitle"] = PostTitle;
                Session["CommentID"] = -1;
                Response.Redirect("ForumAnComment.aspx");


            }
            else
            {
                lblPostError.Text = "Please select a post title.";
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            DisplayPosts();
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            //display only post title
            DisplayFilterPostTitle(txtFilterByPostTitle.Text);
        }
        Int32 DisplayFilterPostTitle(string PostTitleFilter)
        {
            //int to store the primary key
            Int32 PostID;
            //string post title 
            string PostTitle;
            //string post message
            string PostMessage;
            //create an instance of the post collection class
            clsForumPostCollection PostBook = new clsForumPostCollection();
            PostBook.ReportByPostTitle(PostTitleFilter);
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = PostBook.Count;
            //clear the list box
            lstPostlistbox.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //get the Post id
                PostID = PostBook.PostList[Index].PostID;
                //get the post title
                PostTitle = PostBook.PostList[Index].PostTitle;
                //get the post message
                PostMessage = PostBook.PostList[Index].PostMessage;
                //create a new entry for the list box
                ListItem NewEntry = new ListItem(PostTitle + "" + PostMessage, PostID.ToString());
                //add the user to the list
                lstPostlistbox.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        }
    }

}