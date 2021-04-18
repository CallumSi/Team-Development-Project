using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMStaffAddMovie : System.Web.UI.Page
    {
        Int32 VMMovieID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the number of movies to be processed
            VMMovieID = Convert.ToInt32(Session["VMMovieID"]);
            if (IsPostBack == false)
            {
                //populate the list of movie
                DisplayVMMovie();
                //if this is not a new record
                if (VMMovieID != -1)
                {
                    //display the current data for the record
                    DisplayVMMovie();
                }
            }
        }

        void DisplayVMMovie()
        {
            //create an instance of the movie class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //find the record to update
            allMovies.ThisMovie.Find(VMMovieID);
            //display the data for this record
            txtMovieTitle.Text = allMovies.ThisMovie.VMmovieTitle;
            txtMovieGenre.Text = allMovies.ThisMovie.VMmovieGenre;
            txtMovieDuration.Text = allMovies.ThisMovie.VMmovieDuration.ToString();
            txtMovieRating.Text = allMovies.ThisMovie.VMmovieRating.ToString();
            txtMovieReleaseDate.Text = allMovies.ThisMovie.VMmovieReleaseDate.ToString();
            txtMovieImage.Text = allMovies.ThisMovie.VMImage;
            txtMoviePrice.Text = allMovies.ThisMovie.VMmoviePrice.ToString();
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            if (VMMovieID == -1)
            {
                //add the new record
                Add();

            }
            else
            {
                //update the record
                Update();
            }
        }

        //function for adding new records
        void Add()
        {
            //create an instance of the movie class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //validate the data on the web form
            String Error = allMovies.ThisMovie.Valid(txtMovieTitle.Text, txtMovieGenre.Text, txtMovieDuration.Text, txtMovieRating.Text, txtMovieReleaseDate.Text, txtMovieImage.Text, txtMoviePrice.Text); 
            //if the data is OK then add it to the object
            if (Error == "")
            {
                allMovies.ThisMovie.VMmovieTitle = txtMovieTitle.Text;
                allMovies.ThisMovie.VMmovieGenre = txtMovieGenre.Text;
                allMovies.ThisMovie.VMmovieDuration = Convert.ToInt32(txtMovieDuration.Text);
                allMovies.ThisMovie.VMmovieRating = Convert.ToInt32(txtMovieRating.Text);
                allMovies.ThisMovie.VMmovieReleaseDate = Convert.ToDateTime(txtMovieReleaseDate.Text);
                allMovies.ThisMovie.VMImage = txtMovieImage.Text;
                allMovies.ThisMovie.VMmoviePrice = Convert.ToDecimal(txtMoviePrice.Text);
                //add the record
                allMovies.Add();
                //redirect to the main page
                Response.Redirect("VMStaffMovie.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered: " + Error;
            }
        }

        //function for Updating records
        void Update()
        {
            //create an instance of the movie class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //validate the data on the web form
            String Error = allMovies.ThisMovie.Valid(txtMovieTitle.Text, txtMovieGenre.Text, txtMovieDuration.Text, txtMovieRating.Text, txtMovieReleaseDate.Text, txtMovieImage.Text, txtMoviePrice.Text);
            //if the data is OK then add it to the object
            if (Error == "")
            {
                //find the record to update
                allMovies.ThisMovie.Find(VMMovieID);
                //get the data entered by the user
                allMovies.ThisMovie.VMMovieID = VMMovieID;
                allMovies.ThisMovie.VMmovieTitle = txtMovieTitle.Text;
                allMovies.ThisMovie.VMmovieGenre = txtMovieGenre.Text;
                allMovies.ThisMovie.VMmovieDuration = Convert.ToInt32(txtMovieDuration.Text);
                allMovies.ThisMovie.VMmovieRating = Convert.ToInt32(txtMovieRating.Text);
                allMovies.ThisMovie.VMmovieReleaseDate = Convert.ToDateTime(txtMovieReleaseDate.Text);
                allMovies.ThisMovie.VMImage = txtMovieImage.Text;
                allMovies.ThisMovie.VMmoviePrice = Convert.ToDecimal(txtMoviePrice.Text);

                //add the record
                allMovies.Update();
                //redirect to the main page
                Response.Redirect("VMStaffMovie.aspx");
            }
            else
            {
                //report an error
                lblError.Text = "There were problems with the data entered: " + Error;
            }
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffMovie.aspx");
        }

        protected void btnStaffHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffMovie.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffList.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("VirginLogin.aspx");
        }

        protected void btnCustomerList_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMCustomerList.aspx");
        }

        protected void btnStaffMovie_Click(object sender, EventArgs e)
        {
            Response.Redirect("VMStaffMovie.aspx");
        }
    }
}