using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary; 

namespace VirginFrontEnd
{
    public partial class VHCHospitalList : System.Web.UI.Page
    {
        Int32 Hospital_ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of hospital to be processed
            Hospital_ID = Convert.ToInt32(Session["Hospital_ID"]);
            if (IsPostBack == false)
            {
                //populate the list of phones
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
            Response.Redirect("VHCHospital.aspx");
        }

        //Home Button
        protected void btnListHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospital.aspx");

        }

        //Display All Button
        protected void btnDisplayAllHospitals_Click(object sender, EventArgs e)
        {
            //display all hospitals
            DisplayHospital("");
        }

        //Apply Button
        protected void btnHospitalApplyFilter_Click(object sender, EventArgs e)
        {

            if (txtHospitalSearch.Text.Length == 0)
            {
                lblError.Text = "⚠️ SYSTEM ERROR:" + " " + "PLEASE ENTER A VALID LOCATION";
            }

            else
            {
                Int32 RecordCount;
                RecordCount = DisplayHospital(txtHospitalSearch.Text);
                lblError.Text = RecordCount + " Records Found ";
            }
        }

        //Total Records Button
        protected void btnTotalRecords_Click(object sender, EventArgs e)
        {
            //display all hospitals
            DisplayHospital("");

            //declare var to store the record count 
            Int32 RecordCount;
            RecordCount = DisplayHospital("");
            lblError.Text = RecordCount + " Records Found ";
        }

        protected void btnEditHospital_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalAdd.aspx");
        }

        protected void btnDeleteHospital_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospitalDelete.aspx");

        }
    }
}