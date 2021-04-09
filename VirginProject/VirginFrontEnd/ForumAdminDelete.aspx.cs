using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class ForumAdminDelete : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 AdminId;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the user to be deleted from teh session object
            AdminId = Convert.ToInt32(Session["AdminId"]);
        }
        void DeleteAdmin()
        {
            //function to delete the selected record
            //create a new instance of teh User book
            clsForumAdminCollection AdminBook = new clsForumAdminCollection();
            //find the record the delete
            AdminBook.ThisAdmin.Find(AdminId);
            //delete the record
            AdminBook.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteAdmin();
            //redirrect back to the main page
            Response.Redirect("ForumAdminList.aspx");
        }
    }
}