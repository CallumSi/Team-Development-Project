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

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["AdminID"] = -1;
            //redirect to the data entry page
            Response.Redirect("ForumAnAdmin.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 AdminID;
            if (lstForumAdmin.SelectedIndex != -1)
            {
                AdminID = Convert.ToInt32(lstForumAdmin.SelectedValue);
                Session["AdminID"] = AdminID;
                Response.Redirect("ForumAdminDelete.aspx");
            }
            else
            {
                lblError.Text = "Please select a record to delete.";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be editied
            Int32 AdminID;
            //if a record has been selected from the list
            if (lstForumAdmin.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                AdminID = Convert.ToInt32(lstForumAdmin.SelectedValue);
                //store the data in the session object
                Session["AdminID"] = AdminID;
                //redirect to the edit page
                Response.Redirect("ForumAnAdmin.aspx");
            }
            //if no recod has been selected
            else
            {
                //display an error
                lblError.Text = "Please make you select a record from the list";

            }
        }
    }
}