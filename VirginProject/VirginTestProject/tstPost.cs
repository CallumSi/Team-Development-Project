using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstPost
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPost AnPost = new clsPost();
            //test to see that it exists
            Assert.IsNotNull(AnPost);

        }
    }
}
