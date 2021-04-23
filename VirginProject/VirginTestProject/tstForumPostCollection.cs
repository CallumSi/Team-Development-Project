using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumPostCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we wnat to create
            clsForumPostCollection AllPosts = new clsForumPostCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPosts);
        }
        [TestMethod]
        public void UserListOK()
        {
            //create an instance of the class I want to create
            clsForumPostCollection AllPosts = new clsForumPostCollection();
            //create a list of object to assign to the property
            List<clsForumPost> TestList = new List<clsForumPost>();
            //create the item of test data
            clsForumPost TestItem = new clsForumPost();
            //set its properties
            TestItem.PostID = 1;
            TestItem.PostTitle = "Small text";
            TestItem.PostMessage = "I can see the text.";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllPosts.PostList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllPosts.PostList, TestList);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            //Create an instance of the class I want to create
            clsForumPostCollection AllPosts = new clsForumPostCollection();
            //create some test data to assign to the property
            clsForumPost TestPost = new clsForumPost();
            //set the properties of the test object
            TestPost.PostID = 1;
            TestPost.PostTitle = "Small text";
            TestPost.PostMessage = "I can see the text.";
            //assign the data to the property
            AllPosts.ThisPost = TestPost;
            //test to see that the two values are the same
            Assert.AreEqual(AllPosts.ThisPost, TestPost);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class I want to create
            clsForumPostCollection AllPosts = new clsForumPostCollection();
            //create a list of object to assign to the property
            List<clsForumPost> TestList = new List<clsForumPost>();
            //create an item to the list
            clsForumPost TestItem = new clsForumPost();
            //set its properties
            TestItem.PostID = 1;
            TestItem.PostTitle = "Small text";
            TestItem.PostMessage = "I can see the text.";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllPosts.PostList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllPosts.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class I want to create
            clsForumPostCollection AllPosts = new clsForumPostCollection();
            //create an item of test data
            clsForumPost TestItem = new clsForumPost();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PostID = 1;
            TestItem.PostTitle = "The webpage transititon is slow";
            TestItem.PostMessage = "Why is the transition so slow?";
            //set ThisUser to the test data
            AllPosts.ThisPost = TestItem;
            //add the record
            PrimaryKey = AllPosts.Add();
            //set the primary key of the test data
            TestItem.PostID = PrimaryKey;
            //find the record
            AllPosts.ThisPost.Find(PrimaryKey);
            //test to see that the two value are the same
            Assert.AreEqual(AllPosts.ThisPost, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsForumPostCollection AllPosts = new clsForumPostCollection();
            //create the item of test data
            clsForumPost TestItem = new clsForumPost();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PostID = 1;
            TestItem.PostTitle = "The webpage transititon is slow";
            TestItem.PostMessage = "Why is the transition so slow?";
            //set ThisUser to the test data
            AllPosts.ThisPost = TestItem;
            //add the record
            PrimaryKey = AllPosts.Add();
            //set the primary key of the test data
            TestItem.PostID = PrimaryKey;
            //find the record
            AllPosts.ThisPost.Find(PrimaryKey);
            //delete teh record
            AllPosts.Delete();
            //now find the record
            Boolean Found = AllPosts.ThisPost.Find(PrimaryKey);
            //test to see that the two value are the same
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsForumPostCollection AllPosts = new clsForumPostCollection();
            //create the item of test data
            clsForumPost TestItem = new clsForumPost();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.PostTitle = "The webpage transititon is slow";
            TestItem.PostMessage = "Why is the transition so slow?";
            //set ThisUser to the test data
            AllPosts.ThisPost = TestItem;
            //add the record
            PrimaryKey = AllPosts.Add();
            //set the primary key of the test data
            TestItem.PostID = PrimaryKey;
            //modify the test data
            TestItem.PostTitle = "The transition of the pictures";
            TestItem.PostMessage = "Tansition of the pictures are slow. They need to imporve this.";
            //set the record based on the new test data
            AllPosts.ThisPost = TestItem;
            //update the record
            AllPosts.Update();
            //find the record
            AllPosts.ThisPost.Find(PrimaryKey);
            //test to see ThisUser matches the test data
            Assert.AreEqual(AllPosts.ThisPost, TestItem);

        }
        [TestMethod]
        public void ReportByPostTitleMethodOK()
        {
            //create an instance of the class we want to create
            clsForumPostCollection AllPosts = new clsForumPostCollection();
            //create an instance of the filtered data
            clsForumPostCollection FilteredPosts = new clsForumPostCollection();
            //apply a blank string(should return all records)
            FilteredPosts.ReportByPostTitle("");
            //test to see that the two values are the same
            Assert.AreEqual(AllPosts.Count, FilteredPosts.Count);
        }
        [TestMethod]
        public void ReportByPostTitleNoneFound()
        {
            //create an instance of the filtered data
            clsForumPostCollection FilteredPosts = new clsForumPostCollection();
            //apply a username that does not exist
            FilteredPosts.ReportByPostTitle("xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredPosts.Count);
        }
        [TestMethod]
        public void ReportByUserusernameTestDataFound()
        {
            //create an instance of filtered data
            clsForumPostCollection FilteredPosts = new clsForumPostCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a username that doesn't exist
            FilteredPosts.ReportByPostTitle("The best forum ever!");
            //check that the correct number of records 
            if (FilteredPosts.Count == 2)
            {
                //check that the correct number of records are found
                if (FilteredPosts.PostList[0].PostID != 12)
                {
                    OK = false;
                }
                //check that the first record is ID 7
                if (FilteredPosts.PostList[1].PostID != 13)
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
