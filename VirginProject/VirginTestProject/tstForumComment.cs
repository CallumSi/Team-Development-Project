using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumComment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsForumComment AnComment = new clsForumComment();
            //test to see that it exists
            Assert.IsNotNull(AnComment);
        }
    }
}
