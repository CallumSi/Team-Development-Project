using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;
namespace VirginTestProject
{
    [TestClass]
    public class tstMarketplaceUserCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
          
                //create an instance of the class I want to create
                clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
                //create a list of object to assign to the property
                List<clsMarketplaceUser> TestList = new List<clsMarketplaceUser>();
                //create the item of test data
                clsMarketplaceUser User = new clsMarketplaceUser();
                //set some default data
                User.UserID = 1;
                User.Admin = false;
                User.Email = "cjs@hotmail.com";
                User.Rating = 1;
                User.DeliveryAdressLineOne = "";
                User.DeliveryAdressLineTwo = "";
                User.PostCode = "ABC DEF";
                //add the item 
                TestList.Add(User);
                //assign the data to the property
                Users.UserList = TestList;
                //test to see if equal
                Assert.AreEqual(Users.UserList, TestList);

        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {

            //create an instance of the class I want to create
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            //create the item of test data
            clsMarketplaceUser User = new clsMarketplaceUser();
            //set some default data
            User.UserID = 1;
            User.Admin = false;
            User.Email = "cjs@hotmail.com";
            User.Rating = 1;
            User.DeliveryAdressLineOne = "";
            User.DeliveryAdressLineTwo = "";
            User.PostCode = "ABC DEF";
            //add the item 
            //assign the data to the property
            Users.ThisUser = User;
            //test to see if equal
            Assert.AreEqual(Users.ThisUser, User);

        }

        [TestMethod]
        public void CountOK()
        {

            //create an instance of the class I want to create
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            //create a list of object to assign to the property
            List<clsMarketplaceUser> TestList = new List<clsMarketplaceUser>();
            //create the item of test data
            clsMarketplaceUser User = new clsMarketplaceUser();
            //set some default data
            User.UserID = 1;
            User.Admin = false;
            User.Email = "cjs@hotmail.com";
            User.Rating = 1;
            User.DeliveryAdressLineOne = "";
            User.DeliveryAdressLineTwo = "";
            User.PostCode = "ABC DEF";
            //add the item 
            TestList.Add(User);
            //assign the data to the property
            Users.UserList = TestList;
            //test to see if equal
            Assert.AreEqual(Users.Count, TestList.Count);

        }
        [TestMethod]
        public void AddUserMethodOK()
        {
            //Create an instance of the class
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            //create some properties
            clsMarketplaceUser User = new clsMarketplaceUser();

            User.Admin = false;
            User.Email = "cjs@hotmail.com";
            User.Rating = 1;
            User.DeliveryAdressLineOne = "Test";
            User.DeliveryAdressLineTwo = "Test";
            User.PostCode = "ABC DEF";
            //set test data 
            Users.ThisUser = User;
            //add
            Int32 PK = Users.AddUser();
            //find the record
            Users.ThisUser.Find(PK);
            //test are equal 
            Assert.AreEqual(Users.ThisUser, User);
        }

        [TestMethod]
        public void DeleteUserMethodOK()
        {
            //Create an instance of the class
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            //create some properties
            clsMarketplaceUser User = new clsMarketplaceUser();

            User.Admin = false;
            User.Email = "cjs@hotmail.com";
            User.Rating = 1;
            User.DeliveryAdressLineOne = "Test";
            User.DeliveryAdressLineTwo = "Test";
            User.PostCode = "ABC DEF";

            //set test data 
            Users.ThisUser = User;
            //add
            Int32 PK = Users.AddUser();
            //find the record
            Users.ThisUser.Find(PK);

            Users.DeleteUser();
            Boolean Found = Users.ThisUser.Find(PK);
            //test are equal 
            Assert.AreEqual(false, Found);
        }
        [TestMethod]
        public void UpdateUserMethodOK()
        {
            //Create an instance of the class
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            //create some properties
            clsMarketplaceUser User = new clsMarketplaceUser();
            User.Admin = false;
            User.Email = "cjs@hotmail.com";
            User.Rating = 1;
            User.DeliveryAdressLineOne = "Test";
            User.DeliveryAdressLineTwo = "Test";
            User.PostCode = "ABC DEF";

            //set test data 
            Users.ThisUser = User;
            //add
            Int32 PK = Users.AddUser();
            //set the pk
            User.UserID = PK;
            //modify the record
            User.Admin = false;
            User.Email = "Something";
            User.Rating = 1;
            User.DeliveryAdressLineOne = "Something";
            User.DeliveryAdressLineTwo = "Something";
            User.PostCode = "ABC DEF";
            //set the record
            Users.ThisUser = User;
            //update
            Users.UpdateUser();
            //find the user to see if data matches
            Users.ThisUser.Find(PK);
            Assert.AreEqual(Users.ThisUser, User);
        }


        [TestMethod]
        public void FilterByEmailMethodOK()
        {
            //create an instance of the class we want to create
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            //create an instance of the filtered data
            clsMarketplaceUserCollection FilteredUsers = new clsMarketplaceUserCollection();
            //apply a blank string(should return all records)
            FilteredUsers.FilterByEmail("");
            //test to see that the two values are the same
            Assert.AreEqual(Users.Count, FilteredUsers.Count);
        }

        [TestMethod]
        public void FilterByEmailNotFound()
        {
            //create an instance of the class we want to create
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            //create an instance of the filtered data
            clsMarketplaceUserCollection FilteredUsers = new clsMarketplaceUserCollection();
            //apply a blank string(should return all records)
            FilteredUsers.FilterByEmail("hqtehqtehqehqe");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredUsers.Count);
        }

        [TestMethod]
        public void FilterByEmailFound()
        {
            //create an instance of the class we want to create
            clsMarketplaceUserCollection Users = new clsMarketplaceUserCollection();
            //create an instance of the filtered data
            clsMarketplaceUserCollection FilteredUsers = new clsMarketplaceUserCollection();
            //apply a blank string(should return all records)
            FilteredUsers.FilterByEmail("zzz@hotmail.com");
            //test to see that the two values are the same
            Assert.AreEqual(1, FilteredUsers.Count);
        }
    }
}
