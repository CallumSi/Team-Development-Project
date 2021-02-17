﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVHCStaff
    {
        /// <summary>
        /// TESTING STAFF PROPERTIES
        /// </summary>

        //good test data 
        //create some test data to pass to the method 
        //TOTAL: 9 Properties including PK (Staff_ID) 

        string Staff_Title = "Dr"; // (1) 
        string Staff_Firstname = "Monica"; // (2) 
        string Staff_Lastname = "Geller"; // (3) 
        string Staff_Email = "MGeller@gmail.com"; // (4) 
        string Staff_Username = "MonGeller"; // (5) 
        string Staff_Password = "MG3007"; // (6) 
        string Staff_Role = "Doctor"; // (7) 
        string Staff_Status = "True"; // (8)

        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the staff class 
            clsVHCStaff AVHCStaff = new clsVHCStaff();
            //test to see that it exists 
            Assert.IsNotNull(AVHCStaff);
        }
    }
}
