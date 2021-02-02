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
    }
}
