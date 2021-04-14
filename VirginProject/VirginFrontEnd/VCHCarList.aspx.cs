using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHCarList : System.Web.UI.Page
    {
        //function to handle this pages load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayCars();
            }
        }

        void DisplayCars()
        {
            /*//create an instance of the car 
            clsVCHCarCollection Car = new clsVCHCarCollection();
            //set the data source to the list of Cars in the collection
            lstCars.DataSource = Car.CarList;
            //set the name of the primary key
            lstCars.DataValueField = "CarID";
            //set the data field to display
            lstCars.DataTextField = "CarModel";
            //bind the data to the list
            lstCars.DataBind();*/

            //int to store the primary key
            Int32 CarID;
            //Car make property
            string CarMake;
            //Car model property
            string CarModel;
            //Car body property
            string CarBody;

            //create an instance of the car collection class
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = CarCollection.Count;
            //clear the list box
            lstCars.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve CarID
                CarID = CarCollection.CarList[Index].CarID;
                //retrieve CarMake
                CarMake = CarCollection.CarList[Index].CarMake;
                //retrieve CarModel
                CarModel = CarCollection.CarList[Index].CarModel;
                //retrieve CarBody
                CarBody = CarCollection.CarList[Index].CarBody;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Make - " + CarMake + " | Model - " + CarModel + " | Body Type - " + CarBody, CarID.ToString());
                //add the user to the list
                lstCars.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            //display only staff usernames
            DisplayFilterCarBody(txtBxSearch.Text);
        }

        Int32 DisplayFilterCarBody (string CarBodyFilter)
        {
            //int to store the primary key
            Int32 CarID;
            //Car make property
            string CarMake;
            //Car model property
            string CarModel;
            //Car body property
            string CarBody;

            //create an instance of the car collection class
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            CarCollection.ReportByCarBody(CarBodyFilter);
            //count of records
            Int32 RecordCount;
            //index for the loop
            Int32 Index = 0;
            //get the count of records
            RecordCount = CarCollection.Count;
            //clear the list box
            lstCars.Items.Clear();
            //while there are records to process
            while (Index < RecordCount)
            {
                //retrieve CarID
                CarID = CarCollection.CarList[Index].CarID;
                //retrieve CarMake
                CarMake = CarCollection.CarList[Index].CarMake;
                //retrieve CarModel
                CarModel = CarCollection.CarList[Index].CarModel;
                //retrieve CarBody
                CarBody = CarCollection.CarList[Index].CarBody;
                //create new lstBx (list box) entry 
                ListItem NewEntry = new ListItem("Make - " + CarMake + " | Model - " + CarModel + " | Body Type - " + CarBody, CarID.ToString());
                //add the user to the list
                lstCars.Items.Add(NewEntry);
                //move the indext to the next record
                Index++;
            }
            //return the count of records
            return RecordCount;
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //display the car list
            DisplayCars();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["CarID"] = -1;
            //redirect the user back to the car add page
            Response.Redirect("VCHACar.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 CarID;
            //if a record has been selected from the list
            if (lstCars.SelectedIndex != -1)
            {
                //retrieve intended delete records primary key
                CarID = Convert.ToInt32(lstCars.SelectedValue);
                //store the data in the session object
                Session["CarID"] = CarID;
                //redirect the delete page
                Response.Redirect("VCHACar.aspx");
            }
            else //if a user has not selected a car record to edit
            {
                //display an error
                lblError.Text = "Please select a car to edit from the list";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the primary key value
            Int32 CarID;
            //if a record has been selected from the list
            if (lstCars.SelectedIndex != -1)
            {
                //retrieve intended delete records primary key
                CarID = Convert.ToInt32(lstCars.SelectedValue);
                //store the data in the session object
                Session["CarID"] = CarID;
                //redirect the delete page
                Response.Redirect("VCHCarDelete.aspx");
            }
            else //if a user has not selected a car record to delete
            {
                //display an error
                lblError.Text = "Please select a car to delete from the list";
            }
        }
    }
}