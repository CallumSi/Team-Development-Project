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
        String mVMmovieDuration;
        String mVMmovieRating;
        DateTime mVMmovieReleaseDate;


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

        public string VMmovieDuration
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

        public string VMmovieRating
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
    }
}