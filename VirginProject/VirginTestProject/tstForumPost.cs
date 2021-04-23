using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumPost
    {
        //good test data
        //create some test data to pass to the method
        string PostTitle = "The website is a fantastic website";
        string PostMessage = "This website is spot on";
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //test to see that it exists
            Assert.IsNotNull(AnPost);

        }
        [TestMethod]
        public void PostIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsForumPost AUser = new clsForumPost();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AUser.PostID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.PostID, TestData);
        }
        [TestMethod]
        public void PostTitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsForumPost APost = new clsForumPost();
            //create a variable to store the first name of the user 
            string SomePostTitle;
            //assign a user first name to the variable
            SomePostTitle = "Colour";
            //try to send some data to the User first name property
            APost.PostTitle = SomePostTitle;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(APost.PostTitle, SomePostTitle);
        }
        [TestMethod]
        public void PostMessagePropertyOK()
        {
            //create an instance of the class we want to create
            clsForumPost APost = new clsForumPost();
            //create a variable to store the first name of the user 
            string SomePostMessage;
            //assign a user first name to the variable
            SomePostMessage = "The colour of the website is bland.";
            //try to send some data to the User first name property
            APost.PostMessage = SomePostMessage;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(APost.PostMessage, SomePostMessage);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //boolean variable to store the result of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 PostID = 11;
            //invoke the method
            found = AnPost.Find(PostID);
            //test to see that the result is correct
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestPostIDFound()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PostID = 11;
            //invoke the method
            Found = AnPost.Find(PostID);
            //check the user id
            if (AnPost.PostID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostTitleFound()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PostID = 11;
            //invoke the method
            Found = AnPost.Find(PostID);
            //check the user firstname
            if (AnPost.PostTitle != "I love this website!!")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostMessageFound()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PostID = 11;
            //invoke the method
            Found = AnPost.Find(PostID);
            //check the post message
            if (AnPost.PostMessage != "This website is amazing and useful :)")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnPost.Valid(PostTitle, PostMessage);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostTitleExtremeMin()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostTitle = "";
            //invoke the method
            Error = AnPost.Valid(PostTitle, PostMessage);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostTitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostTitle = "";
            PostTitle = PostTitle.PadRight(201, 'a');
            //invoke the method
            Error = AnPost.Valid(PostTitle, PostMessage);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostTitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostTitle = "";
            PostTitle = PostTitle.PadRight(300, 'a');
            //invoke the method
            Error = AnPost.Valid(PostTitle, PostMessage);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");
        }
        /// <summary>
        /// Post message
        /// </summary>
        [TestMethod]
        public void PostMessageExtremeMin()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostMessage = "";
            //invoke the method
            Error = AnPost.Valid(PostTitle, PostMessage);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostMessageMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostMessage = "";
            PostMessage = PostMessage.PadRight(301, 'a');
            //invoke the method
            Error = AnPost.Valid(PostTitle, PostMessage);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PostMessageExtremeMax()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostMessage = "";
            PostMessage = PostMessage.PadRight(500, 'a');
            //invoke the method
            Error = AnPost.Valid(PostTitle, PostMessage);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
