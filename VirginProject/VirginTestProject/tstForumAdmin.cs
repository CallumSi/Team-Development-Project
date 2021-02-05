using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumAdmin
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsForumAdmin AnAdmin = new clsForumAdmin();
            //test to see that it exists
            Assert.IsNotNull(AnAdmin);
        }
    }
}
