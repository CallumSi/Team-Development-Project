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

    public partial class VHCPatientFirstTime : System.Web.UI.Page
    {
        //variable to store the Patient_ID and OrginialID
        Int32 Patient_ID;
        Int32 OriginalID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the originalID to be processed 
            OriginalID = Convert.ToInt32(Session["UserID"]);

            //create an instance of the VHC Patient Collection Class
            clsVHCPatientCollection VHCPatient = new clsVHCPatientCollection();
            //find the user record
            if (VHCPatient.ThisPatient.FindOriginal(OriginalID) == false)
            {
                //change button text to create account
                btnVHCNewComer.Text = " Create Account";
                btnContinueVHC.Visible = false;
                Patient_ID = -1;
            }
            else
            {
                //change button for edit user details
                btnVHCNewComer.Text = "Edit Patient Details";
                VHCPatient.ThisPatient.FindOriginal(OriginalID);
                Patient_ID = VHCPatient.ThisPatient.Patient_ID;
            }
        }

        protected void btnContinueVHC_Click(object sender, EventArgs e)
        {
            //store Patient_ID in session object 
            Session["Patient_ID"] = Patient_ID;
            Response.Redirect("VHCAppointmentList.aspx");
        }

        protected void btnVHCNewComer_Click(object sender, EventArgs e)
        {
            //store Patient_ID and OrginialID in session object 
            Session["Patient_ID"] = Patient_ID;
            Session["OriginalID"] = OriginalID;
            //redirect to edit user details page
            Response.Redirect("VHCPatientAddFirstTime.aspx");
        }

        //Close Button
        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogIn.aspx");

        }
    }
}