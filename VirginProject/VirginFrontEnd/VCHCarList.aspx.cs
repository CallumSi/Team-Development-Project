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
            //create an instance of the car 
            clsVCHCarCollection Car = new clsVCHCarCollection();
            //set the data source to the list of Cars in the collection
            lstCars.DataSource = Car.CarList;
            //set the name of the primary key
            lstCars.DataValueField = "CarID";
            //set the data field to display
            lstCars.DataTextField = "CarModel";
            //bind the data to the list
            lstCars.DataBind();
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {

        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}