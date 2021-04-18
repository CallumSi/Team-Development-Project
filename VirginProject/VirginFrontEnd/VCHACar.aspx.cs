using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VCHACar : System.Web.UI.Page
    {
        //variable to store the primary key with page level scope
        Int32 CarID;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of the car to be processed
            CarID = Convert.ToInt32(Session["CarID"]);
            if (IsPostBack == false)
            {
                //populate the list of car
                DisplayCar();
                //if this is not a new record
                if (CarID != -1)
                {
                    //display the current data for the record
                    DisplayCar();
                }
            }
        }

        //function to add new car records
        void Add()
        {
            //create an instance of the car collection class
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            //validate the data on the web front
            String Error = CarCollection.ThisCar.Valid(txtCarMake.Text, txtCarModel.Text, txtCarEngine.Text, ddlCarBody.SelectedValue.ToString(), txtCarColour.Text, ddlFuelType.SelectedValue.ToString(), txtCarPrice.Text, txtCarRegistration.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //get the data entered by the user
                CarCollection.ThisCar.CarMake = txtCarMake.Text;
                CarCollection.ThisCar.CarModel = txtCarModel.Text;
                CarCollection.ThisCar.CarEngine = Convert.ToDecimal(txtCarEngine.Text);
                CarCollection.ThisCar.CarBody = Convert.ToString(ddlCarBody.SelectedValue.ToString());
                CarCollection.ThisCar.CarColour = txtCarColour.Text;
                CarCollection.ThisCar.CarFuel = Convert.ToString(ddlFuelType.SelectedValue.ToString());
                CarCollection.ThisCar.CarPrice = Convert.ToDecimal(txtCarPrice.Text);
                CarCollection.ThisCar.CarRegistration = txtCarRegistration.Text;
                //add the new car record
                CarCollection.Add();

                //once complete redirect the user to the car list page
                Response.Redirect("VCHCarList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
        }

        void DisplayCar()
        {
            //create an instance of the car collection class
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            //find the CarID for the record to be updated
            CarCollection.ThisCar.Find(CarID);
            //display the data for this record
            txtCarMake.Text = CarCollection.ThisCar.CarMake;
            txtCarModel.Text = CarCollection.ThisCar.CarModel;
            txtCarEngine.Text = CarCollection.ThisCar.CarEngine.ToString();
            ddlCarBody.SelectedValue = CarCollection.ThisCar.CarBody;
            txtCarColour.Text = CarCollection.ThisCar.CarColour;
            ddlFuelType.SelectedValue = CarCollection.ThisCar.CarFuel;
            txtCarPrice.Text = CarCollection.ThisCar.CarPrice.ToString();
            txtCarRegistration.Text = CarCollection.ThisCar.CarRegistration;
        }

        //function to update existing car records
        void Update()
        {
            //create an instance of the car collection class
            clsVCHCarCollection CarCollection = new clsVCHCarCollection();
            //validate the data on the web front
            String Error = CarCollection.ThisCar.Valid(txtCarMake.Text, txtCarModel.Text, txtCarEngine.Text, ddlCarBody.SelectedValue.ToString(), txtCarColour.Text, ddlFuelType.SelectedValue.ToString(), txtCarPrice.Text, txtCarRegistration.Text);
            //if the data is correct/OK then it'll be added to the object
            if (Error == "")
            {
                //find the record to update/edit
                CarCollection.ThisCar.Find(CarID);
                //get the data entered by the user
                CarCollection.ThisCar.CarMake = txtCarMake.Text;
                CarCollection.ThisCar.CarModel = txtCarModel.Text;
                CarCollection.ThisCar.CarEngine = Convert.ToDecimal(txtCarEngine.Text);
                CarCollection.ThisCar.CarBody = Convert.ToString(ddlCarBody.SelectedValue.ToString());
                CarCollection.ThisCar.CarColour = txtCarColour.Text;
                CarCollection.ThisCar.CarFuel = Convert.ToString(ddlFuelType.SelectedValue.ToString());
                CarCollection.ThisCar.CarPrice = Convert.ToDecimal(txtCarPrice.Text);
                CarCollection.ThisCar.CarRegistration = txtCarRegistration.Text;
                //update the existing car record
                CarCollection.Update();

                //once complete redirect the user to the car list page
                Response.Redirect("VCHCarList.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "The inputted data is not acceptable. " + Error;
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (CarID == -1)
            {
                //add the new car record
                Add();
            }
            else
            {
                //update the car record
                Update();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //redirect the user to the car list page, without having added or edited a car record
            Response.Redirect("VCHCarList.aspx");
        }
    }
}