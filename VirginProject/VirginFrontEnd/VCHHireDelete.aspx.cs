using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHHireDelete : System.Web.UI.Page
    {
        //var to store primary key for record to be deleted
        Int32 HireID;

        //event handler for load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the primary key of the car hire that will be deleted from the session object
            HireID = Convert.ToInt32(Session["HireID"]);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteHire();
            //redirect the user to the car hire list page
            Response.Redirect("VCHHireList.aspx");
        }

        //function to delete a car hire 
        void DeleteHire()
        {
            //create an instance of the car 
            clsVCHHireCollection HireCollection = new clsVCHHireCollection();
            //find the car record to be deleted 
            HireCollection.ThisHire.Find(HireID);
            //delete the record
            HireCollection.Delete();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect the user to the car hire list page, without having deleted a car hire record
            Response.Redirect("VCHHireList.aspx");
        }
    }
}