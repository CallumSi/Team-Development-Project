using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VHCHospitalDelete : System.Web.UI.Page
    {
        Int32 Hospital_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the hospital to be deleted from the session object
            Hospital_ID = Convert.ToInt32(Session["Hospital_ID"]);
        }

        //function to delete the selected hospital record 
        void DeleteHospital()
        {
            //create a new instance of the customer collection class
            clsVHCHospitalCollection AllHospital = new clsVHCHospitalCollection();
            //find the record to delete
            AllHospital.ThisHospital.Find(Hospital_ID);
            //delete the record
            AllHospital.Delete();
        }

        protected void Home_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospital.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalList.aspx");

        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteHospital();
            Response.Redirect("VHCHospitalList.aspx");

        }
    }
}