using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)

                DisplayVMUser();
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
