using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstForumPost
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsForumPost AnPost = new clsForumPost();
            //test to see that it exists
            Assert.IsNotNull(AnPost);

        }
    }
}
