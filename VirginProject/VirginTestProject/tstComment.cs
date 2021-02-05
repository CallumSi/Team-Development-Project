using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstComment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsComment AnComment = new clsComment();
            //test to see that it exists
            Assert.IsNotNull(AnComment);
        }
    }
}
