using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;


namespace VirginTestProject
{
    [TestClass]
    public class tstForumUser
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class we want to create
            clsForumUser AnUser = new clsForumUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsForumUser AUser = new clsForumUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.UserID, TestData);
        }
        [TestMethod]
        public void UserFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsForumUser AUser = new clsForumUser();
            //create a variable to store the first name of the user 
            string SomeUserFirstName;
            //assign a user first name to the variable
            SomeUserFirstName = "Katie";
            //try to send some data to the User first name property
            AUser.UserFirstName = SomeUserFirstName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AUser.UserFirstName, SomeUserFirstName);
        }
        [TestMethod]
        public void UserLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsForumUser AUser = new clsForumUser();
            //create a variable to store the last name of the user
            string SomeUserLastName;
            //assigna user last name to the variable
            SomeUserLastName = "Lewis";
            //try to send some data to the user last name property
            AUser.UserLastName = SomeUserLastName;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AUser.UserLastName, SomeUserLastName);
        }
        [TestMethod]
        public void UserEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsForumUser AUser = new clsForumUser();
            //create a variable to store the email of the user
            string SomeUserEmail;
            //assign user last name to the variable
            SomeUserEmail = "KatieLewis@gmail.com";
            //try to send some data to the user email property
            AUser.UserEmail = SomeUserEmail;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AUser.UserEmail, SomeUserEmail);
        }
        [TestMethod]
        public void UserPasswordOk()
        {
            //create an instance of the class we want to create
            clsForumUser AUser = new clsForumUser();
            //create a variable to store the password of the user
            string SomeUserPassword;
            //assign user password to the variable
            SomeUserPassword = "KatLover";
            //try to send some data to the user password property
            AUser.UserPassword = SomeUserPassword;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AUser.UserPassword, SomeUserPassword);
        }
        [TestMethod]
        public void UserPhoneNumberOk()
        {
            //create an instance of the class we want to create
            clsForumUser AUser = new clsForumUser();
            //create a variable to store the phone number of the user
            string SomeUserPhoneNumber;
            //assign user phone number to the variable
            SomeUserPhoneNumber = "01234567890";
            //try to send some data to the user password property
            AUser.UserPhoneNumber = SomeUserPhoneNumber;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AUser.UserPhoneNumber, SomeUserPhoneNumber);
        }


    }
}
