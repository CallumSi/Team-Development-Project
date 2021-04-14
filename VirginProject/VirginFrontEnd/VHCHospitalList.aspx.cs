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
                ListItem NewEntry = new ListItem(Hospital_Name + " " + Hospital_Place + " ", Hospital_ID.ToString());
                lstHospital.Items.Add(NewEntry);
                Index++;
            }
            return RecordCount; //return the count of records found
        }

        protected void Home_Button_List_Click(object sender, EventArgs e)
        {
            Response.Redirect("VHCHospital.aspx");
        }

        protected void btnDisplayAllHospitals_Click(object sender, EventArgs e)
        {
            //display all hospitals
            DisplayHospital("");
        }

        protected void btnApplyHospital_Click(object sender, EventArgs e)
        {
            //declare var to store the record count 
            Int32 RecordCount;
            RecordCount = DisplayHospital(txtHospitalSearch.Text);
            lblError.Text = RecordCount + " Record Found ";
        }
    }
}