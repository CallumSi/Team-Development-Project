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
    
    public partial class VHCPatientDelete : System.Web.UI.Page
    {
        Int32 Patient_ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the patient to be deleted from the session object
            Patient_ID = Convert.ToInt32(Session["Patient_ID"]);
        }

        //function to delete the selected patient record 
        void DeletePatient()
        {
            //create a new instance of the patient collection class
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //find the record to delete
            AllPatients.ThisPatient.Find(Patient_ID);
            //delete the record
            AllPatients.Delete();
        }

        //Yes Button
        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete the record
            DeletePatient();
            Response.Redirect("VHCPatientList.aspx");

        }

        //No Button
        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCPatientList.aspx");
        }
    }
}