using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VHCHospitalAdd : System.Web.UI.Page
    {
        //Declare Hospital Primary Key
        Int32 Hospital_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of hospitals to be processed
            Hospital_ID = Convert.ToInt32(Session["Hospital_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of hospitals
                DisplayHospitals();
                //if this is not a new record
                if (Hospital_ID != -1)
                {
                    //display the current data for the record
                    DisplayHospitals();
                }
            }
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the hospital class
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //validate the data on the web form
            String Error = AllHospitals.ThisHospital.Valid(txtHospital_Name.Text, txtHospital_Place.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                AllHospitals.ThisHospital.Hospital_Name = txtHospital_Name.Text;
                AllHospitals.ThisHospital.Hospital_Place = txtHospital_Place.Text;
                //add the record
                AllHospitals.Add();
                //redirect to the main page
                Response.Redirect("VHCHospitalList.aspx");
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
            //create an instance of the hospital class
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //validate the data on the web form
            String Error = AllHospitals.ThisHospital.Valid(txtHospital_Name.Text, txtHospital_Place.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update 
                AllHospitals.ThisHospital.Find(Hospital_ID);
                //get the data entered by the user 
                AllHospitals.ThisHospital.Hospital_Name = txtHospital_Name.Text;
                AllHospitals.ThisHospital.Hospital_Place = txtHospital_Place.Text;
                //update the record 
                AllHospitals.Update();
                Response.Redirect("VHCHospitalList.aspx");
            }
        }

        void DisplayHospitals()
        {
            //create an instance of the hospital class
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //find the record to update
            AllHospitals.ThisHospital.Find(Hospital_ID);
            //display the data for this record
            txtHospital_Name.Text = AllHospitals.ThisHospital.Hospital_Name;
            txtHospital_Place.Text = AllHospitals.ThisHospital.Hospital_Place;
        }

        //Submit Button
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Hospital_ID == -1)
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
  
        //Close Button
        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCStaff.aspx");
        }
    }
    
}