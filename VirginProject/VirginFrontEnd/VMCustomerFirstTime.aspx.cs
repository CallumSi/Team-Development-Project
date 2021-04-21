using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMCustomerFirstTime : System.Web.UI.Page
    {
        //variable to store the VMCustomerID and OrginialID
        Int32 VMCustomerID;
        Int32 OriginalID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the originalID to be processed 
            OriginalID = Convert.ToInt32(Session["UserID"]);

            //create an instance of the user book
            clsVMCustomerCollection VMCustomerBook = new clsVMCustomerCollection();
            //find the user record
            if (VMCustomerBook.ThisCustomer.FindOriginal(OriginalID) == false)
            {
                //change button text to create account
                btnVMNewComer.Text = "Please Create An Account. ";
                btnContinueVM.Visible = false;
                VMCustomerID = -1;
            }
            else
            {
                //change button for edit user details
                btnVMNewComer.Text = "Edit User Account";
                VMCustomerBook.ThisCustomer.FindOriginal(OriginalID);
                VMCustomerID = VMCustomerBook.ThisCustomer.VMCustomerID;
            }
        }

        protected void btnContinueVM_Click(object sender, EventArgs e)
        {
            //store VMCustomerID in session object 
            Session["VMCustomer"] = VMCustomerID;
            Response.Redirect("VirginCustomerMovieList.aspx");
        }

        protected void btnVMNewComer_Click(object sender, EventArgs e)
        {
            //store VMCustomerID and OrginialID in session object 
            Session["VMCustomerID"] = VMCustomerID;
            Session["OriginalID"] = OriginalID;
            //redirect to edit user details page
            Response.Redirect("AnNewVMCustomer.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }
    }
}