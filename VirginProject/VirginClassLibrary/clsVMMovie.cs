using System;

namespace VirginClassLibrary
{
    public class clsVMMovie
    {
        //Unique Movie Identifier
        //private data member for the MovieID property
        private Int32 mVMMovieID;
        //Common Movie Attributes
        String mVMmovieTitle;
        String mVMmovieGenre;
        Int32 mVMmovieDuration;
        Int32 mVMmovieRating;
        DateTime mVMmovieReleaseDate;
        String mVMImage;
        Decimal mVMmoviePrice;


        //Public property for MovieID
        public int VMMovieID
        {
            get
            {
                //return the private data
                return mVMMovieID;
            }
            set
            {
                //set the private data
                mVMMovieID = value;
            }
        }

        public string VMmovieTitle
        {
            get
            {
                //return the private data
                return mVMmovieTitle;
            }

            set
            {
                //set the private data
                mVMmovieTitle = value;
            }
        }

        public string VMmovieGenre
        {
            get
            {
                //return the private data
                return mVMmovieGenre;
            }

            set
            {
                //set the private data
                mVMmovieGenre = value;
            }
        }

        public int VMmovieDuration
        {
            get
            {
                //return the private data
                return mVMmovieDuration;
            }

            set
            {
                //set the private data
                mVMmovieDuration = value;
            }
        }

        public int VMmovieRating
        {
            get
            {
                //return the private data
                return mVMmovieRating;
            }

            set
            {
                //set the private data
                mVMmovieRating = value;
            }
        }

        public DateTime VMmovieReleaseDate
        {
            get
            {
                //return the private data
                return mVMmovieReleaseDate;
            }

            set
            {
                //set the private data
                mVMmovieReleaseDate = value;
            }
        }

        public string VMImage
        {
            get
            {
                //return the private data
                return mVMImage;
            }

            set
            {
                //set the private data
                mVMImage = value;
            }
        }

        public decimal VMmoviePrice
        {
            get
            {
                //return the private data
                return mVMmoviePrice;
            }
            set
            {
                //set the private data
                mVMmoviePrice = value;
            }
        }

        public bool Find(int VMMovieID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the CustomerID to search for
            DB.AddParameter("@VMMovieID", VMMovieID);
            //execute the stored procedure
            DB.Execute("sproc_tblVMMovie_FilterByVMMovieID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mVMMovieID = Convert.ToInt32(DB.DataTable.Rows[0]["VMMovieID"]);
                mVMmovieTitle = Convert.ToString(DB.DataTable.Rows[0]["VMMovieTitle"]);
                mVMmovieGenre = Convert.ToString(DB.DataTable.Rows[0]["VMMovieGenre"]);
                mVMmovieDuration = Convert.ToInt32(DB.DataTable.Rows[0]["VMMovieDuration"]);
                mVMmovieRating = Convert.ToInt32(DB.DataTable.Rows[0]["VMMovieRating"]);
                mVMmovieReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["VMMovieReleaseDate"]);
                mVMImage = Convert.ToString(DB.DataTable.Rows[0]["VMImage"]);
                VMmoviePrice = Convert.ToDecimal(DB.DataTable.Rows[0]["VMMoviePrice"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string VMmovieTitle, string VMmovieGenre, string VMmovieDuration, string VMmovieRating, string VMmovieReleaseDate, string VMImage, string VMmoviePrice)
        {


            //create a string variable to store the error message
            String Error = "";

            //**************** MOVIE TITLE ***********************// 
            //test to see if the movie title has zero characters
            if (VMmovieTitle.Length == 0)
            {
                //return error message 
                Error = Error + "Movie Title cannot be blank!" + " ";
            }

            //if the Movie title is less than 1 and greater than 55 characters
            if (VMmovieTitle.Length < 1 | VMmovieTitle.Length > 55)
            {
                //return error message 
                Error = Error + "Movie Title cannot be more than 55 characters" + " ";
            }

            //**************** MOVIE GENRE ***********************// 
            //test to see if the movie genre has zero characters
            if (VMmovieGenre.Length == 0)
            {
                //return error message 
                Error = Error + "Movie Genre cannot be blank!" + " ";
            }

            //if the Movie genre is less than 3 and greater than 55 characters
            if (VMmovieGenre.Length < 3 | VMmovieGenre.Length > 55)
            {
                //return error message 
                Error = Error + "Movie Title cannot be less than 3 characters or more than 55 characters" + " ";
            }

            //**************** MOVIE DURATION ***********************// 

            try
            {
                Int32 TempMovieDuration = Convert.ToInt32(VMmovieDuration);

                if (TempMovieDuration < 0)
                {
                    Error = Error + "Movie duration cannot be less than 0 minutes!" + " ";
                }

                if (TempMovieDuration >= 301)
                {
                    Error = Error + "Movie duration cannot be less than 0 minutes or more than 300 minutes" + " ";

                }
            }
            catch
            {
                Error = Error + "Movie duration was invalid" + " ";
            }

            //**************** MOVIE RATING ***********************// 

            try
            {
                Int32 TempMovieRating = Convert.ToInt32(VMmovieRating);

                if (TempMovieRating < 0)
                {
                    Error = Error + "Movie Rating cannot be less than 0!" + " ";
                }

                if (TempMovieRating >= 11)
                {
                    Error = Error + "Movie Rating cannot be less than 0 or more than 10" + " ";

                }
            }
            catch
            {
                Error = Error + "Movie Rating was invalid" + " ";
            }

            //**************** MOVIE RELEASE DATE ***********************// 

            try
            {
                DateTime TempMovieReleaseDate = Convert.ToDateTime(VMmovieReleaseDate);

                if (TempMovieReleaseDate < DateTime.Now.AddYears(-122))
                {
                    Error = Error + "Movie Release Date cannot be before 1900!" + " ";
                }

                if (TempMovieReleaseDate > DateTime.Now.Date)
                {
                    Error = Error + "Movie Release Date cannot be in the future." + " ";
                }
            }
            catch
            {
                Error = Error + "Movie Release Date was invalid" + " ";
            }

            //**************** MOVIE IMAGE ***********************// 
            //test to see if the movie image has zero characters
            if (VMImage.Length < 0)
            {
                //return error message 
                Error = Error + "Movie Image cannot be blank!" + " ";
            }
            if (VMImage.Length < 5 | VMImage.Length > 200)
            {
                Error = Error + "Movie Release Date was invalid. Movie Image cannot be blank or exceed 200 characters" + " ";
            }

            //**************** MOVIE PRICE ***********************// 

            try
            {
                decimal PriceTemp = Convert.ToDecimal(VMmoviePrice);
                if (PriceTemp < 5.01m | PriceTemp > 100.01m)
                {
                    //set the error message
                    Error = Error + "Movie Price must be between £5 and £100" + " ";
                }
            }
            catch
            {
                //record the error message 
                Error = Error + "The data was not a valid price : ";
            }
            //return any error messages
            return Error;
        }

    }
}