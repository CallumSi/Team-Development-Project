using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    ///This page uses code originated by Matthew Dean.
    ///it is free for use by anybody so long as you give credit to the original author.
    ///Matthew Dean mjdean@dmu.ac.uk De Montfort University 2019
    
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
            //create a new instance of the hospital collection class
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //find the record to delete
            AllHospitals.ThisHospital.Find(Hospital_ID);
            //delete the record
            AllHospitals.Delete();
        }

        //No Button
        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalList.aspx");

        }

        //Yes Button
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteHospital();
            Response.Redirect("VHCHospitalList.aspx");
        }
    }
}