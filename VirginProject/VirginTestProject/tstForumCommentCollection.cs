using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
using System;
using System.Collections.Generic;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumCommentCollection
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we wnat to create
            clsForumCommentCollection AllPosts = new clsForumCommentCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPosts);
        }
        [TestMethod]
        public void UserListOK()
        {
            //create an instance of the class I want to create
            clsForumCommentCollection AllComment = new clsForumCommentCollection();
            //create a list of object to assign to the property
            List<clsForumComment> TestList = new List<clsForumComment>();
            //create the item of test data
            clsForumComment TestItem = new clsForumComment();
            //set its properties
            TestItem.CommentID = 1;
            TestItem.CommentMessage = "Small text";
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllComment.CommentList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllComment.CommentList, TestList);
        }
        [TestMethod]
        public void ThisUserPropertyOK()
        {
            //Create an instance of the class I want to create
            clsForumCommentCollection AllComment = new clsForumCommentCollection();
            //create some test data to assign to the property
            clsForumComment TestComment = new clsForumComment();
            //set the properties of the test object
            TestComment.CommentID = 1;
            TestComment.CommentMessage = "Small text";
            //assign the data to the property
            AllComment.ThisComment = TestComment;
            //test to see that the two values are the same
            Assert.AreEqual(AllComment.ThisComment, TestComment);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class I want to create
            clsForumCommentCollection AllComment = new clsForumCommentCollection();
            //create a list of object to assign to the property
            List<clsForumComment> TestList = new List<clsForumComment>();
            //create an item to the list
            clsForumComment TestItem = new clsForumComment();
            //set its properties
            TestItem.CommentID = 1;
            TestItem.CommentMessage = "Small text";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllComment.CommentList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllComment.Count, TestList.Count);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsForumCommentCollection AllComments = new clsForumCommentCollection();
            //create the item of test data
            clsForumComment TestItem = new clsForumComment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CommentID = 6;
            TestItem.CommentMessage = "me too!!";
            //find the record
            AllComments.ThisComment.Find(PrimaryKey);
            //delete the record
            AllComments.Delete();
            //now find the record
            Boolean Found = AllComments.ThisComment.Find(PrimaryKey);
            //test to see that the two value are the same
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsForumCommentCollection AllComments = new clsForumCommentCollection();
            //create the item of test data
            clsForumComment TestItem = new clsForumComment();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CommentID = 4;
            TestItem.CommentMessage = "hello";
            //set ThisUser to the test data
            AllComments.ThisComment = TestItem;
            //add the record
            //PrimaryKey = AllPosts.Add();
            //set the primary key of the test data
            TestItem.CommentID = PrimaryKey;
            //modify the test data
            TestItem.CommentID = 5;
            TestItem.CommentMessage = "Me too!!";
            //set the record based on the new test data
            AllComments.ThisComment = TestItem;
            //update the record
            AllComments.Update();
            //find the record
            AllComments.ThisComment.Find(PrimaryKey);
            //test to see ThisUser matches the test data
            Assert.AreEqual(AllComments.ThisComment, TestItem);

        }

    }
}
