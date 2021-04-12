using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVMMovieCollection
    {
        [TestMethod]
        public void InstantationOK()
        {
            //create an instance of the movie collection class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //test to see that it exists
            Assert.IsNotNull(allMovies);
        }

        [TestMethod]
        public void VMMovieListOK()
        {
            //create an instance of the movie collection class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //create a list of object to assign to the property
            List<clsVMMovie> TestList = new List<clsVMMovie>();
            //create the item of test data
            clsVMMovie TestItem = new clsVMMovie();
            //set its properties
            TestItem.VMMovieID = 1;
            TestItem.VMmovieTitle = "T-34";
            TestItem.VMmovieGenre = "War";
            TestItem.VMmovieDuration = 139;
            TestItem.VMmovieRating = 10;
            TestItem.VMmovieReleaseDate = Convert.ToDateTime("09/04/2021");
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            allMovies.MovieList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allMovies.MovieList, TestList);
        }

        [TestMethod]
        public void ThisMoviePropertyOK()
        {
            //create an instance of the movie collection class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //create some test data to assign to the property
            clsVMMovie TestMovie = new clsVMMovie();
            //set the properties of the test object
            TestMovie.VMMovieID = 3;
            TestMovie.VMmovieTitle = "Godzilla";
            TestMovie.VMmovieGenre = "Sci-fi";
            TestMovie.VMmovieDuration = 129;
            TestMovie.VMmovieRating = 8;
            TestMovie.VMmovieReleaseDate = Convert.ToDateTime("15/05/2020");
            //assign the data to the property
            allMovies.ThisMovie = TestMovie;
            //test to see that the two values are the same
            Assert.AreEqual(allMovies.ThisMovie, TestMovie);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the movie collection class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //create a list of object to assign to the property
            List<clsVMMovie> TestList = new List<clsVMMovie>();
            //create the item of test data
            clsVMMovie TestMovie = new clsVMMovie();
            //set the properties of the test object
            TestMovie.VMmovieTitle = "Godzilla";
            TestMovie.VMmovieGenre = "Sci-fi";
            TestMovie.VMmovieDuration = 129;
            TestMovie.VMmovieRating = 8;
            TestMovie.VMmovieReleaseDate = Convert.ToDateTime("15/05/2020");
            //add the item to the test list
            TestList.Add(TestMovie);
            //assign the data to the property
            allMovies.MovieList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allMovies.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the movie collection class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //create some test data to assign to the property
            clsVMMovie TestMovie = new clsVMMovie();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestMovie.VMmovieTitle = "Godzilla vs King Kong";
            TestMovie.VMmovieGenre = "Sci-fi";
            TestMovie.VMmovieDuration = 140;
            TestMovie.VMmovieRating = 7;
            TestMovie.VMmovieReleaseDate = Convert.ToDateTime("01/01/2021");
            //set ThisCustomer to the test data
            allMovies.ThisMovie = TestMovie;
            //add the record
            PrimaryKey = allMovies.Add();
            //Set the primary key of the test data
            TestMovie.VMMovieID = PrimaryKey;
            //find the record
            allMovies.ThisMovie.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allMovies.ThisMovie, TestMovie);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the movie collection class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //create some test data to assign to the property
            clsVMMovie TestMovie = new clsVMMovie();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestMovie.VMmovieTitle = "Godzilla";
            TestMovie.VMmovieGenre = "Sci-fi";
            TestMovie.VMmovieDuration = 129;
            TestMovie.VMmovieRating = 8;
            TestMovie.VMmovieReleaseDate = Convert.ToDateTime("15/05/2020");
            //set ThisCustomer to the test data
            allMovies.ThisMovie = TestMovie;
            //add the record
            PrimaryKey = allMovies.Add();
            //Set the primary key of the test data
            TestMovie.VMMovieID = PrimaryKey;
            //mdoify the record
            TestMovie.VMmovieTitle = "Fast and Furious";
            TestMovie.VMmovieGenre = "Racing";
            TestMovie.VMmovieDuration = 110;
            TestMovie.VMmovieRating = 7;
            TestMovie.VMmovieReleaseDate = Convert.ToDateTime("03/09/2009");
            //set the record based on the new test data
            allMovies.ThisMovie = TestMovie;
            //Update the record
            allMovies.Update();
            //find the record
            allMovies.ThisMovie.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(allMovies.ThisMovie, TestMovie);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the movie collection class
            clsVMMovieCollection allMovies = new clsVMMovieCollection();
            //create some test data to assign to the property
            clsVMMovie TestMovie = new clsVMMovie();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestMovie.VMMovieID = 3;
            TestMovie.VMmovieTitle = "Godzilla";
            TestMovie.VMmovieGenre = "Sci-fi";
            TestMovie.VMmovieDuration = 129;
            TestMovie.VMmovieRating = 8;
            TestMovie.VMmovieReleaseDate = Convert.ToDateTime("15/05/2020");
            //set ThisCustomer to the test data
            allMovies.ThisMovie = TestMovie;
            //add the record
            PrimaryKey = allMovies.Add();
            //set the primary key of the test data
            TestMovie.VMMovieID = PrimaryKey;
            //find the record
            allMovies.ThisMovie.Find(PrimaryKey);
            //delete the record
            allMovies.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(allMovies.ThisMovie, TestMovie);
        }

        [TestMethod]
        public void ReportByGenreNoneFound()
        {
            // create an instance of the filtered data
            clsVMMovieCollection FilterByVMGenre = new clsVMMovieCollection();
            //apply a username that doesnt exist
            FilterByVMGenre.FilterByGenre("Hello");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilterByVMGenre.Count);
        }

        [TestMethod]
        public void ReportByGenreTestDataFound()
        {
            // create an instance of the filtered data
            clsVMMovieCollection FilterByVMGenre = new clsVMMovieCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a username that does exist
            FilterByVMGenre.FilterByGenre("War");
            //check that the correct number of records are found
            if (FilterByVMGenre.Count == 2)
            {
                //check that the first record is ID 80
                if (FilterByVMGenre.MovieList[0].VMMovieID != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 82
                if (FilterByVMGenre.mMovieList[1].VMMovieID != 9)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
