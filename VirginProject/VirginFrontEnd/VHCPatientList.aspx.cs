using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VHCPatientList : System.Web.UI.Page
    {
        Int32 Patient_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of patient to be processed
            Patient_ID = Convert.ToInt32(Session["Patient_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of patients
                DisplayPatient();
            }
        }

        private void DisplayPatient()
        {
            //create an instance of the patient class
            clsVHCPatientCollection AllPatients = new clsVHCPatientCollection();
            //set the data source to the list of patient in the collection 
            lstPatient.DataSource = AllPatients.PatientList;
            //set the name of the primary key 
            lstPatient.DataValueField = "Patient_ID";
            //set the data field to display 
            lstPatient.DataTextField = "Patient_Firstname";
            //bind the data to the list
            lstPatient.DataBind();
        }

        Int32 DisplayPatient(string PatientFilter)
        {
            Int32 Patient_ID; //Var to store the primary key  
            String Patient_Title; //Var to store the Patient Title
            String Patient_Firstname; //Var to store the Patient Firstname
            String Patient_Lastname; //Var to store the Patient Lastname
            String Patient_Address; //Var to store the Patient Address
            DateTime Patient_DOB; //Var to store the Patient DOB
            String Patient_Email; //Var to store the Patient Email
            String Patient_Username; //Var to store the Patient Username
            String Patient_Password; //Var to store the Patient Password
            String Patient_Telephone; //Var to store the Patient Telephone
            Boolean Patient_Status; //Var to store the Patient Status
            //create an instance of the patient class
            clsVHCPatientCollection PatientSearch = new clsVHCPatientCollection();
            //invoke the Patient dob filter
            PatientSearch.ReportByPatient(Convert.ToDateTime(PatientFilter));
            Int32 RecordCount; //Var to store the count of records 
            Int32 Index = 0; //Var to store the index for the loop
            RecordCount = PatientSearch.Count; //get the count of records 
            lstPatient.Items.Clear(); //clear the list box
            while (Index < RecordCount) //While there are records to process
            {
                Patient_ID = PatientSearch.PatientList[Index].Patient_ID; //get primary key 
                Patient_Title = PatientSearch.PatientList[Index].Patient_Title; //get Patient Title 
                Patient_Firstname = PatientSearch.PatientList[Index].Patient_Firstname; //get Patient Firstname
                Patient_Lastname = PatientSearch.PatientList[Index].Patient_Lastname; //get Patient Lastname
                Patient_Address = PatientSearch.PatientList[Index].Patient_Address; //get Patient Address
                Patient_DOB = PatientSearch.PatientList[Index].Patient_DOB; //get Patient DOB
                Patient_Email = PatientSearch.PatientList[Index].Patient_Email; //get Patient Email
                Patient_Username = PatientSearch.PatientList[Index].Patient_Username; //get Patient Username
                Patient_Password = PatientSearch.PatientList[Index].Patient_Password; //get Patient Password
                Patient_Telephone = PatientSearch.PatientList[Index].Patient_Telephone; //get Patient Telephone
                Patient_Status = PatientSearch.PatientList[Index].Patient_Status; //get Patient Status
                //create a new entry for the list box
                ListItem NewEntry = new ListItem("[" + Patient_ID + "] " + Patient_Title + " " + Patient_Firstname + " " + Patient_Lastname, Patient_ID.ToString());
                lstPatient.Items.Add(NewEntry);
                Index++;
            }
            return RecordCount; //return the count of records found
        }

        //Close Button
        protected void btnListClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCStaff.aspx");

        }

        //Display All Button
        protected void btnDisplayAllPatients_Click(object sender, EventArgs e)
        {
        
            //display all patients
            DisplayPatient();
        }

        //Apply Button
        protected void btnPatientApplyFilter_Click(object sender, EventArgs e)
        {
            if (txtPatientSearch.Text.Length == 0)
            {
                lblError.Text = "⚠️ SYSTEM ERROR:" + " " + "PLEASE ENTER A VALID DATE OF BIRTH";
            }

            else
            {
                Int32 RecordCount;
                RecordCount = DisplayPatient(txtPatientSearch.Text);
                lblError.Text = RecordCount + " RECORDS FOUND ";
            }

            
        }

        protected void btnEditPatient_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 Patient_ID;
            //if a record has been selected from the list
            if (lstPatient.SelectedIndex != -1)
            {
                //get the primary key of the record to edit
                Patient_ID = Convert.ToInt32(lstPatient.SelectedValue);
                //store the data in the session object
                Session["Patient_ID"] = Patient_ID;
                //redirect to the edit page
                Response.Redirect("VHCPatientAdd.aspx");
            }

            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "⚠️ SYSTEM ERROR:" + " " + "PLEASE SELECT A RECORD TO UPDATE FROM THE LIST!";
            }
        }

        protected void btnDeletePatient_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 Patient_ID;
            //if a record has been selected from the list
            if (lstPatient.SelectedIndex != -1)
            {
                //get the primary key of the record to delete
                Patient_ID = Convert.ToInt32(lstPatient.SelectedValue);
                //store the data in the session object
                Session["Patient_ID"] = Patient_ID;
                //redirect to the delete page
                Response.Redirect("VHCPatientDelete.aspx");
            }

            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "⚠️ SYSTEM ERROR:" + " " + "PLEASE SELECT A RECORD TO BE REMOVED FROM THE LIST!";
            }
        }
    }
}