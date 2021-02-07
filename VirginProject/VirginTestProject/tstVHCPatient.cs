using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VirginClassLibrary;

namespace VirginTestProject
{
    [TestClass]
    public class tstVHCPatient
    {
        [TestMethod]
        public void InstantiationOK()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient(); 
        }

        [TestMethod]
        //used to test the Patient_Title property of the class 
        public void Patient_Title()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the title of a patient 
            string SomePatient_Title;
            //assign a patient title to the variable 
            SomePatient_Title = "Miss"; 
            //try to send some data to the Patient_Title property
            AVHCPatient.Patient_Title = SomePatient_Title;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Title, SomePatient_Title); 
        }

        [TestMethod]
        //used to test the Patient_Firstname property of the class 
        public void Patient_Firstname()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the firstname of a patient 
            string SomePatient_Firstname;
            //assign a patient firstname to the variable 
            SomePatient_Firstname = "Harry";
            //try to send some data to the Patient_Firstname property
            AVHCPatient.Patient_Firstname = SomePatient_Firstname;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Firstname, SomePatient_Firstname);
        }

        [TestMethod]
        //used to test the Patient_Lastname property of the class 
        public void Patient_Lastname()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the lastname of a patient 
            string SomePatient_Lastname;
            //assign a patient lastname to the variable 
            SomePatient_Lastname = "Potter";
            //try to send some data to the Patient_Lastname property
            AVHCPatient.Patient_Lastname = SomePatient_Lastname;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Lastname, SomePatient_Lastname);
        }

        [TestMethod]
        //used to test the Patient_Address property of the class 
        public void Patient_Address()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the address of a patient 
            string SomePatient_Address;
            //assign a patient address to the variable 
            SomePatient_Address = "42 Western Road, Leicestershire";
            //try to send some data to the Patient_Address property
            AVHCPatient.Patient_Address = SomePatient_Address;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Address, SomePatient_Address);
        }

        [TestMethod]
        //used to test the Patient_DOB property of the class 
        public void Patient_DOB()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the date of birth of a patient 
            DateTime SomePatient_DOB;
            //assign a patient date of birth to the variable 
            SomePatient_DOB = Convert.ToDateTime("01/01/2000");
            //try to send some data to the Patient_DOB property
            AVHCPatient.Patient_DOB = SomePatient_DOB;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_DOB, SomePatient_DOB);
        }

        [TestMethod]
        //used to test the Patient_Email property of the class 
        public void Patient_Email()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the email of a patient 
            string SomePatient_Email;
            //assign a patient email to the variable 
            SomePatient_Email = "HarryPotter@gmail.com";
            //try to send some data to the Patient_Email property
            AVHCPatient.Patient_Email = SomePatient_Email;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Email, SomePatient_Email);
        }

        [TestMethod]
        //used to test the Patient_Username property of the class 
        public void Patient_Username()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the username of a patient 
            string SomePatient_Username;
            //assign a patient username to the variable 
            SomePatient_Username = "HP123";
            //try to send some data to the Patient_Username property
            AVHCPatient.Patient_Username = SomePatient_Username;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Username, SomePatient_Username);
        }

        [TestMethod]
        //used to test the Patient_Password property of the class 
        public void Patient_Password()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the password of a patient 
            string SomePatient_Password;
            //assign a patient password to the variable 
            SomePatient_Password = "HarryPotter123!";
            //try to send some data to the Patient_Password property
            AVHCPatient.Patient_Password = SomePatient_Password;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Password, SomePatient_Password);
        }

        [TestMethod]
        //used to test the Patient_Telephone property of the class 
        public void Patient_Telephone()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the telephone of a patient 
            string SomePatient_Telephone;
            //assign a patient telephone to the variable 
            SomePatient_Telephone = "01234567891";
            //try to send some data to the Patient_Telephone property
            AVHCPatient.Patient_Telephone = SomePatient_Telephone;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Telephone, SomePatient_Telephone);
        }

        [TestMethod]
        //used to test the Patient_Status property of the class 
        public void Patient_Status()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //create a variable to store the status of a patient 
            Boolean SomePatient_Status;
            //assign a patient status to the variable 
            SomePatient_Status = true;
            //try to send some data to the Patient_Status property
            AVHCPatient.Patient_Status = SomePatient_Status;
            //check to see that the data in the variable and the property are the same
            Assert.AreEqual(AVHCPatient.Patient_Status, SomePatient_Status);
        }

        [TestMethod]
        //used to test the presence of the Valid Method
        public void Valid()
        {
            //create an instance of the class 
            clsVHCPatient AVHCPatient = new clsVHCPatient();
            //test to see if the valid method exists 
            AVHCPatient.Valid("Miss"); 
           
        }


    }
}
