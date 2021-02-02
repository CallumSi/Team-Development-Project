using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstMarketplaceUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test to see if it existis
            Assert.IsNotNull(AnMarketplaceUser);
        }

        [TestMethod]
        public void AdminPropertyOK()
        {
            //create instance of Marketplace user
            clsMarketplaceUser AnMarketplaceUser = new clsMarketplaceUser();
            //test data for property
            Boolean TestData = true;
            //assign data to the property
            AnMarketplaceUser.Admin = TestData;
            //test if values are equal 
            Assert.AreEqual(AnMarketplaceUser.Admin, TestData);
        }

    }
}
