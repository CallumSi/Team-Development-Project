using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VirginUserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)

                DisplayVMUser();
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //use session object to indicate new record
            Session["UserID"] = -1;
            //redirect to user data entry page
            Response.Redirect("AnVirginUser.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to edit
            Int32 UserID;
            //check if a record has been selected from the list
            if (lstUser.SelectedIndex != -1)
            {
                //get primary key from selected
                UserID = Convert.ToInt32(lstUser.SelectedValue);
                //store data in session object so we can pass it to next page
                Session["UserID"] = UserID;
                //redirect to edit user details page
                Response.Redirect("AnVirginUser.aspx");

            }
            //if a record hasnt been selected from the listbox 
            else
            {
                //display a error 
                lblError.Text = "Please select a record to edit from the list ";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //variable to store primary key of field you want to delete
            Int32 UserID;
            //check if a record has been selected from the list
            if (lstUser.SelectedIndex != -1)
            {
                //get primary key from selected
                UserID = Convert.ToInt32(lstUser.SelectedValue);
                //store data in session object so we can pass it to next page
                Session["UserID"] = UserID;
                //redirect to delete page
                Response.Redirect("VirginUserDelete.aspx");

            }
            //if a record hasnt been selected from the listbox 
            else
            {
                //display a error 
                lblError.Text = "Please select a record to delete from the list ";
            }
        }


        void DisplayVMUser()
        {
            clsUserCollection AUser = new clsUserCollection();
            lstUser.DataSource = AUser.UserList;
            lstUser.DataValueField = "UserID";
            lstUser.DataTextField = "UserName";
            lstUser.DataBind();

        }
    }
}