using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;


namespace VirginTestProject
{
    [TestClass]
    public class tstForumUser
    {
        //create some test data to pass the method
        string UserFirstName = "Qasim";
        string UserLastName = "Mohamed";
        string UserEmail = "MQ@gmail.com";
        string UserPassword = "QQ55";
        string UserPhoneNumber = "12345678912";
        string Userusername = "QMohamed02";

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
        public void UserusernamePropertyOK()
        {
            //create an instance of the class we want to create
            clsForumUser AUser = new clsForumUser();
            //create a variable to store the first name of the user 
            string SomeUserusername;
            //assign a user first name to the variable
            SomeUserusername = "K02";
            //try to send some data to the User first name property
            AUser.Userusername = SomeUserusername;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AUser.Userusername, SomeUserusername);
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
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsForumUser AnUser = new clsForumUser();
            //boolean variable to store the result of the validation
            Boolean found = false;
            //create some test data to use with the method
            Int32 UserID = 1;
            //invoke the method
            found = AnUser.Find(UserID);
            //test to see that the result is correct
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestUserIDFound()
        {
            //create an instance of the class we want to create
            clsForumUser AnUser = new clsForumUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 1;
            //invoke the method
            Found = AnUser.Find(UserID);
            //check the user id
            if (AnUser.UserID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserFirstNameFound()
        {
            //create an instance of the class we want to create
            clsForumUser AnUser = new clsForumUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 1;
            //invoke the method
            Found = AnUser.Find(UserID);
            //check the user firstname
            if (AnUser.UserFirstName != "AbdiKarim")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserLastNameFound()
        {
            //create an instance of the class we want to create
            clsForumUser AnUser = new clsForumUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 1;
            //invoke the method
            Found = AnUser.Find(UserID);
            //check the user Lastname
            if (AnUser.UserLastName != "Suldan")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsForumUser AnUser = new clsForumUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 1;
            //invoke the method
            Found = AnUser.Find(UserID);
            //check the user phonenumber
            if (AnUser.UserPhoneNumber != "34242487")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUserEmailFound()
        {
            //create an instance of the class we want to create
            clsForumUser AnUser = new clsForumUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 UserID = 1;
            //invoke the method
            Found = AnUser.Find(UserID);
            //check the user email
            if (AnUser.UserEmail != "Abdi@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        //[TestMethod]
        //public void TestUserPasswordFound()
        //{
        //    //create an instance of the class we want to create
        //    clsForumUser AnUser = new clsForumUser();
        //    //boolean variable to store the result of the search
        //    Boolean Found = false;
        //    //boolean variable to record if data is OK
        //    Boolean OK = true;
        //    //create some test data to use with the method
        //    Int32 UserID = 1;
        //    //invoke the method
        //    Found = AnUser.Find(UserID);
        //    //check the user password
        //    if (AnUser.UserPassword != "Abz234")
        //    {
        //        OK = false;
        //    }
        //    //test to see that the result is correct
        //    Assert.IsTrue(OK);
        //}
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserFirstNameLessOne()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //String vairable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserFirstName = "";
            //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void UserFirstNameMaxPlusOne()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //String vairable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserFirstName = "qwertyuioplkjhgf";
            //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see the test is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void UserFirstNameExtremeMax()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserFirstName = "";
            UserFirstName = UserFirstName.PadRight(50, 'a'); //this should fail
            //invoke the method
             Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");

        }

        /// <summary>
        /// Validation
        /// </summary>

        /// <summary>
        /// First name validation.
        /// </summary>
        ///

        /// <summary>
        /// Last name validation
        /// </summary>

        [TestMethod]
        public void UserLastNameMinLessOne()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserLastName = "a"; //this should fail
            //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserLastNameMaxPlusOne()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserLastName = "aqwsderfgtyhjuik"; //this should fail
                                                      //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserLastNameExtremeMax()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserLastName = "";
            UserLastName = UserLastName.PadRight(50, 'a'); //this should fail
            //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Phone number validation
        /// </summary>

        [TestMethod]
        public void UserPhoneNumberMinLessOne()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserPhoneNumber = "1234567891"; //this should fail
            //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserPhoneNumberMinPlusOne()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserPhoneNumber = "123456789123"; //this should fail
            //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserPhoneNumberExtremeMax()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserPhoneNumber = "";
            UserPhoneNumber = UserLastName.PadRight(20, 'a'); //this should fail
            //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Email Address
        /// </summary>

        [TestMethod]
        public void UserEmailAddressMaxPlussOne()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserEmail = "";
            UserEmail = UserEmail.PadRight(26, 'a');
            //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserEmailAddressExtremeMax()
        {
            //create an instane of the class we want to create 
            clsForumUser AnUser = new clsForumUser();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UserEmail = "";
            UserEmail = UserEmail.PadRight(50, 'a'); //this should fail
                                                     //invoke the method
            Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail,/* UserPassword,*/ UserPhoneNumber/*, Userusername*/);
            //test to see that the test is correct
            Assert.AreNotEqual(Error, "");
        }

        /// <summary>
        /// Password
        /// </summary>

        //[TestMethod]
        //public void UserPasswordMaxPlussOne()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumUser AnUser = new clsForumUser();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string UserPassword = "qazwsxedcrfvtgbyhnujmiklop"; //this should fail
        //    //invoke the method
        //    Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail, UserPassword, UserPhoneNumber, Userusername);
        //    //test to see that the test is correct
        //    Assert.AreNotEqual(Error, "");
        //}
        //[TestMethod]
        //public void UserPasswordExtremeMax()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumUser AnUser = new clsForumUser();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string UserPassword = "";
        //    UserPassword = UserPassword.PadRight(50, 'a'); //this should fail
        //    //invoke the method
        //    Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail, UserPassword, UserPhoneNumber, Userusername);
        //    //test to see that the test is correct
        //    Assert.AreNotEqual(Error, "");
        //}

        ///// <summary>
        ///// User name
        ///// </summary>

        //[TestMethod]
        //public void UserusernameMinLessOne()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumUser AnUser = new clsForumUser();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string Userusername = "aaa"; //this should fail
        //    //invoke the method
        //    Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail, UserPassword, UserPhoneNumber, Userusername);
        //    //test to see that the test is correct

        //}

        //[TestMethod]
        //public void UserusernameMaxPlussOne()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumUser AnUser = new clsForumUser();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string Userusername = "qwertyuiopasdfgh"; //this should fail
        //    //invoke the method
        //    Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail, UserPassword, UserPhoneNumber, Userusername);
        //    //test to see that the test is correct

        //}
        //[TestMethod]
        //public void UserusernameExtremeMax()
        //{
        //    //create an instane of the class we want to create 
        //    clsForumUser AnUser = new clsForumUser();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create some test data to pass to the method
        //    string Userusername = "";
        //    Userusername = Userusername.PadRight(50, 'a'); //this should fail
        //    //invoke the method
        //    Error = AnUser.Valid(UserFirstName, UserLastName, UserEmail, UserPassword, UserPhoneNumber, Userusername);
        //    //test to see that the test is correct
        //    Assert.AreNotEqual(Error, "");
        //}

    }
}
