using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class MarketplaceUserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //update the list box
                DisplayUser();
            }
        }

        void DisplayUser()
        {
            //create an instance of the use collection
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            lstMarketplaceUser.DataSource = Users.UserList;
            //set name of primary key
           
        }
    }
}