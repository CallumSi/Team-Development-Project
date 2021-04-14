using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VirginClassLibrary;

namespace VirginFrontEnd
{
    public partial class VMHome : System.Web.UI.Page
    {
        //Int32 VMMovieID;
        ////used to store the details of the current user
        //clsVMCustomer TheCurrentUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            //    //this event runs when the page is loaded at the server
            //    //if this is the first time the page has loaded
            //    if (IsPostBack == false)
            //    {
            //        //display the film list 
            //        DisplayVMMovie();
            //    }
            //}

            //void DisplayVMMovie()
            //{
            //    //create an instance of the movie collection class
            //    clsVMMovieCollection allMovie = new clsVMMovieCollection();
            //    lstCustomerMovies.DataSource = allMovie.MovieList;
            //    //set name of primary key
            //    lstCustomerMovies.DataValueField = "VMMovieID";
            //    //bind data
            //    lstCustomerMovies.DataTextField = "VMMovieTitle";
            //    lstCustomerMovies.DataBind();
            //}

            //protected void lstFilms_SelectedIndexChanged(object sender, EventArgs e)
            //{
            //    //this code runs when the user clicks on a movie in the list
            //    //var to store the MovieID
            //    Int32 MovieID;
            //    //get the MovieID of the item clicked on
            //    MovieID = Convert.ToInt32(lstCustomerMovies.SelectedValue);
            //    //display the image for that record
            //    MovieImage.ImageUrl = GetSwapImage(VMMovieID);
            //    //display the description for that record
            //    lblFilmDescription.Text = GetFilmDescription(VMMovieID);
            //}

            //private string GetFilmDescription(int VMMovieID)
            //{
            //    //create an instance of the movie collection class
            //    clsVMMovieCollection SomeMovie = new clsVMMovieCollection();
            //    //find the record to display
            //    SomeMovie.ThisMovie.Find(VMMovieID);
            //    //display the data for this record
            //    lblFilmDescription.Text = SomeMovie.ThisMovie.VMmovieTitle;
            //    lblFilmDescription.Text = SomeMovie.ThisMovie.VMmovieGenre;
            //    lblFilmDescription.Text = SomeMovie.ThisMovie.VMmovieDuration.ToString();
            //    lblFilmDescription.Text = SomeMovie.ThisMovie.VMmovieRating.ToString();
            //    lblFilmDescription.Text = SomeMovie.ThisMovie.VMmovieReleaseDate.ToString();
            //    return SomeMovie.ToString();
            //}

            //private string GetSwapImage(int VMMovieID)
            //{
            //    //this function looks up the image name for the SwapNo
            //    //it returns the name of the image
            //    //
            //    //var to store the name of the image
            //    string ImageFile = "";
            //    //find the record for this swap
            //    clsVMMovieCollection SomeMovie = new clsVMMovieCollection();
            //    //find the image to display
            //    MovieImage.ImageUrl = SomeMovie.ThisMovie.VMImage;
            //    //if the record has been found
            //    if (SomeMovie.Count == 1)
            //    {
            //        ImageFile = SomeMovie.ThisMovie.VMImage;
            //        return ImageFile;
            //    }
            //    else
            //    {
            //        //otherwise return a blank string
            //        return "";
            //    }
            //}

        }
    }
}