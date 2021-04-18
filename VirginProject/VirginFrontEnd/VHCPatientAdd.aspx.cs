using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VHCPatientAdd : System.Web.UI.Page
    {
        //Declare Patient Primary Key
        Int32 Patient_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of patients to be processed
            Patient_ID = Convert.ToInt32(Session["Patient_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of patients
                DisplayPatients();
                //if this is not a new record
                if (Patient_ID != -1)
                {
                    //display the current data for the record
                    DisplayPatients();
                }
            }
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the patient class
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //validate the data on the web form
            String Error = AllPatients.ThisPatient.Valid(txtPatient_Title.Text, txtPatient_Firstname.Text, txtPatient_Lastname.Text, txtPatient_Address.Text, txtPatient_DOB.Text, txtPatient_Email.Text, txtPatient_Username.Text, txtPatient_Password.Text, txtPatient_Telephone.Text, cbPatient_Status.Checked.ToString());
            //if the data is OK then add it to the object
            if (Error == "")
            {
                AllPatients.ThisPatient.Patient_Title = txtPatient_Title.Text;
                AllPatients.ThisPatient.Patient_Firstname = txtPatient_Firstname.Text;
                AllPatients.ThisPatient.Patient_Lastname = txtPatient_Lastname.Text;
                AllPatients.ThisPatient.Patient_Address = txtPatient_Address.Text;
                AllPatients.ThisPatient.Patient_DOB = Convert.ToDateTime(txtPatient_DOB.Text);
                AllPatients.ThisPatient.Patient_Email = txtPatient_Email.Text;
                AllPatients.ThisPatient.Patient_Username = txtPatient_Username.Text;
                AllPatients.ThisPatient.Patient_Password= txtPatient_Password.Text;
                AllPatients.ThisPatient.Patient_Telephone = txtPatient_Telephone.Text;
                AllPatients.ThisPatient.Patient_Status = Convert.ToBoolean(cbPatient_Status.Checked);
                //add the record
                AllPatients.Add();
                //redirect to the main page
                Response.Redirect("VHCPatientList.aspx");
            }

            else
            {
                //report an error
                lblError.Text = "⚠️ ERROR:" + "  " + Error;
            }
        }


        //function for updating new records
        void Update()
        {
            //create an instance of the patient class
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //validate the data on the web form
            String Error = AllPatients.ThisPatient.Valid(txtPatient_Title.Text, txtPatient_Firstname.Text, txtPatient_Lastname.Text, txtPatient_Address.Text, txtPatient_DOB.Text, txtPatient_Email.Text, txtPatient_Username.Text, txtPatient_Password.Text, txtPatient_Telephone.Text, cbPatient_Status.Checked.ToString());
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update 
                AllPatients.ThisPatient.Find(Patient_ID);
                //get the data entered by the user 
                AllPatients.ThisPatient.Patient_Title = txtPatient_Title.Text;
                AllPatients.ThisPatient.Patient_Firstname = txtPatient_Firstname.Text;
                AllPatients.ThisPatient.Patient_Lastname = txtPatient_Lastname.Text;
                AllPatients.ThisPatient.Patient_Address = txtPatient_Address.Text;
                AllPatients.ThisPatient.Patient_DOB = Convert.ToDateTime(txtPatient_DOB.Text);
                AllPatients.ThisPatient.Patient_Email = txtPatient_Email.Text;
                AllPatients.ThisPatient.Patient_Username = txtPatient_Username.Text;
                AllPatients.ThisPatient.Patient_Password = txtPatient_Password.Text;
                AllPatients.ThisPatient.Patient_Telephone = txtPatient_Telephone.Text;
                AllPatients.ThisPatient.Patient_Status = Convert.ToBoolean(cbPatient_Status.Checked);
                //update the record 
                AllPatients.Update();
                Response.Redirect("VHCPatientList.aspx");
            }
        }

        private void DisplayPatients()
        {
            //create an instance of the patient class
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //find the record to update
            AllPatients.ThisPatient.Find(Patient_ID);
            //display the data for this record
            txtPatient_Title.Text = AllPatients.ThisPatient.Patient_Title;
            txtPatient_Firstname.Text = AllPatients.ThisPatient.Patient_Firstname;
            txtPatient_Lastname.Text = AllPatients.ThisPatient.Patient_Lastname;
            txtPatient_Address.Text = AllPatients.ThisPatient.Patient_Address;
            txtPatient_DOB.Text = Convert.ToDateTime(AllPatients.ThisPatient.Patient_DOB).ToShortDateString();
            txtPatient_Email.Text = AllPatients.ThisPatient.Patient_Email;
            txtPatient_Username.Text = AllPatients.ThisPatient.Patient_Username;
            txtPatient_Password.Text = AllPatients.ThisPatient.Patient_Password;
            txtPatient_Telephone.Text = AllPatients.ThisPatient.Patient_Telephone;
            cbPatient_Status.Checked = Convert.ToBoolean(AllPatients.ThisPatient.Patient_Status);

        }
        //Close Button
        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCStaff.aspx");
        }

        //Submit Button
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Patient_ID == -1)
            {
                //Add the new record
                Add();
            }

            else
            {
                ////Update the record
                Update();
            }
        }
    }
}