using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumComment
    {
        string CommentMessage = "This website is spot on";
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsForumComment AnComment = new clsForumComment();
            //test to see that it exists
            Assert.IsNotNull(AnComment);
        }
        [TestMethod]
        public void CommentIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsForumComment AComment = new clsForumComment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AComment.CommentID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AComment.CommentID, TestData);
        }

        [TestMethod]
        public void CommentMessagePropertyOK()
        {
            //create an instance of the class we want to create
            clsForumComment AComment = new clsForumComment();
            //create a variable to store the first name of the user 
            string SomeCommentMessage;
            //assign a user first name to the variable
            SomeCommentMessage = "The colour of the website is bland.";
            //try to send some data to the User first name property
            AComment.CommentMessage = SomeCommentMessage;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AComment.CommentMessage, SomeCommentMessage);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsForumComment AComment = new clsForumComment();
            //boolean variable to store the result of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 CommentID = 5;
            //invoke the method
            found = AComment.Find(CommentID);
            //test to see that the result is correct
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestCommentIDFound()
        {
            //create an instance of the class we want to create
            clsForumComment AComment = new clsForumComment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CommentID = 4;
            //invoke the method
            Found = AComment.Find(CommentID);
            //check the user id
            if (AComment.CommentID != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCommentMessageFound()
        {
            //create an instance of the class we want to create
            clsForumComment AComment = new clsForumComment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CommentID = 4;
            //invoke the method
            Found = AComment.Find(CommentID);
            //check the post message
            if (AComment.CommentMessage != "hello")
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
            clsForumComment AComment = new clsForumComment();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AComment.Valid(CommentMessage);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CommentMessageExtremeMin()
        {
            //create an instance of the class we want to create
            clsForumComment AComment = new clsForumComment();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CommentMessage = "";
            //invoke the method
            Error = AComment.Valid(CommentMessage);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CommentMessageMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsForumComment AComment = new clsForumComment();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CommentMessage = "";
            CommentMessage = CommentMessage.PadRight(301, 'a');
            //invoke the method
            Error = AComment.Valid(CommentMessage);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CommentMessageExtremeMax()
        {
            //create an instance of the class we want to create
            clsForumComment AComment = new clsForumComment();
            //String variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CommentMessage = "";
            CommentMessage = CommentMessage.PadRight(500, 'a');
            //invoke the method
            Error = AComment.Valid(CommentMessage);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
