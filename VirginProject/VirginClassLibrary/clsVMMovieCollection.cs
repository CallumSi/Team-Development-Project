using System;
using System.Collections.Generic;

namespace VirginClassLibrary
{
    public class clsVMMovieCollection
    {
        //private data member for the list

        List<clsVMMovie> mMovieList = new List<clsVMMovie>();

        public List<clsVMMovie> MovieList
        {
            get
            {
                //return the private data
                return mMovieList;
            }
            set
            {
                //set the private data
                mMovieList = value;
            }
        }

        //private data member thisMovie
        clsVMMovie mThisMovie = new clsVMMovie();

        //public property for ThisMovie
        public clsVMMovie ThisMovie
        {
            get
            {
                //return the private data
                return mThisMovie;
            }
            set
            {
                //set the private data
                mThisMovie = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mMovieList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //constructor for the class
        public clsVMMovieCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblVMMovie_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var to store the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the private array list
            mMovieList = new List<clsVMMovie>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank movie
                clsVMMovie AMovie = new clsVMMovie();
                //read in the fields from the current record
                AMovie.VMMovieID = Convert.ToInt32(DB.DataTable.Rows[Index]["VMMovieID"]);
                AMovie.VMmovieTitle = Convert.ToString(DB.DataTable.Rows[Index]["VMMovieTitle"]);
                AMovie.VMmovieGenre = Convert.ToString(DB.DataTable.Rows[Index]["VMMovieGenre"]);
                AMovie.VMmovieDuration = Convert.ToInt32(DB.DataTable.Rows[Index]["VMMovieDuration"]);
                AMovie.VMmovieRating = Convert.ToInt32(DB.DataTable.Rows[Index]["VMMovieRating"]);
                AMovie.VMmovieReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["VMMovieReleaseDate"]);
                AMovie.VMImage = Convert.ToString(DB.DataTable.Rows[Index]["VMImage"]);
                //add the record to the private data member
                mMovieList.Add(AMovie);
                //point to the next record
                Index++;
            }
        }

        //Add method
        public int Add()
        {

            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VMMovieTitle", mThisMovie.VMmovieTitle);
            DB.AddParameter("@VMMovieGenre", mThisMovie.VMmovieGenre);
            DB.AddParameter("@VMMovieDuration", mThisMovie.VMmovieDuration);
            DB.AddParameter("@VMMovieRating", mThisMovie.VMmovieRating);
            DB.AddParameter("@VMMovieReleaseDate", mThisMovie.VMmovieReleaseDate);
            DB.AddParameter("@VMImage", mThisMovie.VMImage);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblVMMovie_Insert");
        }

        //Update method
        public void Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@VMMovieID", mThisMovie.VMMovieID);
            DB.AddParameter("@VMMovieTitle", mThisMovie.VMmovieTitle);
            DB.AddParameter("@VMMovieGenre", mThisMovie.VMmovieGenre);
            DB.AddParameter("@VMMovieDuration", mThisMovie.VMmovieDuration);
            DB.AddParameter("@VMMovieRating", mThisMovie.VMmovieRating);
            DB.AddParameter("@VMMovieReleaseDate", mThisMovie.VMmovieReleaseDate);
            DB.AddParameter("@VMImage", mThisMovie.VMImage);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblVMMovie_Update");
        }

        public void Delete()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@VMMovieID", mThisMovie.VMMovieID);
            //execute the stored procedure
            DB.Execute("sproc_tblVMMovie_Delete");
        }

        public void FilterByGenre(string VMMovieGenre)
        {
            //add a new record to the database based on private data variables
            //first establish connection 
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the sproc
            DB.AddParameter("@VMMovieGenre", VMMovieGenre);
            //execute the sproc
            DB.Execute("sproc_tblVMMovie_FilterByGenre");
            //populate the array with the found data
            PopulateArray(DB);
        }
    }
}