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
    
    public partial class VHCHospitalList : System.Web.UI.Page
    {
        Int32 Hospital_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of hospital to be processed
            Hospital_ID = Convert.ToInt32(Session["Hospital_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of hospitals
                DisplayHospital();
            }
        }

        private void DisplayHospital()
        {
            //create an instance of the hospital class
            clsVHCHospitalCollection AllHospitals = new clsVHCHospitalCollection();
            //set the data source to the list of hospital in the collection 
            lstHospital.DataSource = AllHospitals.HospitalList;
            //set the name of the primary key 
            lstHospital.DataValueField = "Hospital_ID";
            //set the data field to display 
            lstHospital.DataTextField = "Hospital_Name";
            //bind the data to the list 
            lstHospital.DataBind();
        }

      Int32 DisplayHospital(string HospitalFilter)
      {
            Int32 Hospital_ID; //Var to store the primary key  
            String Hospital_Name; //Var to store the Hospital Name
            String Hospital_Place; //Var to store the Hospital Place 
            //Create an instance of the Hospital class 
            clsVHCHospitalCollection HospitalSearch = new clsVHCHospitalCollection();
            //invoke the hospital name filter
            HospitalSearch.ReportByHospital(HospitalFilter);
            Int32 RecordCount; //Var to store the count of records 
            Int32 Index = 0; //Var to store the index for the loop
            RecordCount = HospitalSearch.Count; //get the count of records 
            lstHospital.Items.Clear(); //clear the list box
            while (Index < RecordCount) //While there are records to process
            {
                Hospital_ID = HospitalSearch.HospitalList[Index].Hospital_ID; //get primary key 
                Hospital_Name = HospitalSearch.HospitalList[Index].Hospital_Name; //get Hospital Name
                Hospital_Place = HospitalSearch.HospitalList[Index].Hospital_Place; //get Hospital Place
                //create a new entry for the list box
                ListItem NewEntry = new ListItem("[" + Hospital_ID +"] "+ Hospital_Name + " - " + Hospital_Place + " ", Hospital_ID.ToString());
                lstHospital.Items.Add(NewEntry);
                Index++;
            }
            return RecordCount; //return the count of records found
      }

        //Close button
        protected void btnListClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCStaff.aspx");
        }

        //Display All Button
        protected void btnDisplayAllHospitals_Click(object sender, EventArgs e)
        {
            //display all staff
            Int32 RecordCount;
            RecordCount = DisplayHospital("");
            lblError.Text = RecordCount + " RECORDS FOUND ";
        }

        //Apply Button
        protected void btnHospitalApplyFilter_Click(object sender, EventArgs e)
        {

            if (txtHospitalSearch.Text.Length == 0)
            {
                lblError.Text = "⚠️" + " " + "PLEASE ENTER A VALID LOCATION";
            }

            else
            {
                Int32 RecordCount;
                RecordCount = DisplayHospital(txtHospitalSearch.Text);
                lblError.Text = RecordCount + " RECORDS FOUND ";
            }
        }

        //Edit Button
        protected void btnEditHospital_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be edited
            Int32 Hospital_ID;
            //if a record has been selected from the list
            if (lstHospital.SelectedIndex != -1)
            {
                //get the primary key of the record to edit
                Hospital_ID = Convert.ToInt32(lstHospital.SelectedValue);
                //store the data in the session object
                Session["Hospital_ID"] = Hospital_ID;
                //redirect to the edit page
                Response.Redirect("VHCHospitalAdd.aspx");
            }

            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "⚠️" + " " + "PLEASE SELECT A RECORD TO UPDATE FROM THE LIST!";
            }
        }

        protected void btnDeleteHospital_Click(object sender, EventArgs e)
        {
            //var to store the primary key value of the record to be deleted
            Int32 Hospital_ID;
            //if a record has been selected from the list
            if (lstHospital.SelectedIndex != -1)
            {
                //get the primary key of the record to delete
                Hospital_ID = Convert.ToInt32(lstHospital.SelectedValue);
                //store the data in the session object
                Session["Hospital_ID"] = Hospital_ID;
                //redirect to the delete page
                Response.Redirect("VHCHospitalDelete.aspx");
            }

            //if no record has been selected
            else
            {
                //display an error 
                lblError.Text = "⚠️" + " " + "PLEASE SELECT A RECORD TO BE REMOVED FROM THE LIST!";
            }

        }
    }
}