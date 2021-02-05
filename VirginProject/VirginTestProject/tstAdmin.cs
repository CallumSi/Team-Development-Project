using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstAdmin
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAdmin AnAdmin = new clsAdmin();
            //test to see that it exists
            Assert.IsNotNull(AnAdmin);
        }
    }
}
