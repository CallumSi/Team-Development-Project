using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumCommentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayComments();
            }

        }
        void DisplayComments()
        {
            //create an instance of the County Collection
            clsForumCommentCollection Comment = new clsForumCommentCollection();
            //set the data source to the list of countries in the collection
            lstComment.DataSource = Comment.CommentList;
            //set the name of the primary key
            lstComment.DataValueField = "CommentID";
            //set the data field to display
            lstComment.DataTextField = "CommentMessage";
            //bind the data to the list
            lstComment.DataBind();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be editied
            Int32 CommentID;
            //if a record has been selected from the list
            if (lstComment.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                CommentID = Convert.ToInt32(lstComment.SelectedValue);
                //store the data in the session object
                Session["CommentID"] = CommentID;
                //redirect to the edit page
                Response.Redirect("ForumAnComment.aspx");
            }
            //if no recod has been selected
            else
            {
                //display an error
                lblError.Text = "Please make you select a comment from the list";

            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 CommentID;
            //if a record has been selected from the list
            if (lstComment.SelectedIndex != -1)
            {
                //get the primary key value of the record to delete
                CommentID = Convert.ToInt32(lstComment.SelectedValue);
                //store the data in the session object
                Session["CommentID"] = CommentID;
                //redirect to the delete page
                Response.Redirect("ForumCommentDelete.aspx");
            }
            //if no recod has been selected
            else
            {
                //display an error
                lblError.Text = "Please select a record to delete from the list";

            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForumPostList.aspx");
        }
    }
}