﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsUser AnUser = new clsUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
    }
}