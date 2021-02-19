using System;

namespace VirginClassLibrary
{
    public class clsVCHCar
    {
        //Car ID property
        public int CarID { get; set; }

        //Car Make property
        public string CarMake { get; set; }

        //Car Model property
        public string CarModel { get; set; }

        //Car Engine size property
        public decimal CarEngine { get; set; }
        
        //Car Body property
        public string CarBody { get; set; }

        //Car Colour property
        public string CarColour { get; set; }

        //Car Fuel type property
        public string CarFuel { get; set; }

        //Car weekly hire Price property
        public decimal CarPrice { get; set; }

        //Car registration property
        public string CarRegistration { get; set; }

        public string Valid(string CarMake, string CarModel)
        {
            //string variable to store the error message
            string Error = "";
            //if the car make length is more than 30 characters
            if (CarMake.Length > 30)
            {
                //return the following error message
                return "Car Makes cannot exceed 30 characters, please fill it in accordingly.";
            }
            //if the car make length is less than 2 characters
            if (CarMake.Length < 2)
            {
                //return the following error message
                return "The Car Make is too short, please fill it in accordingly.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the car model length is more than 30 characters
            if (CarModel.Length > 30)
            {
                //return the following error message
                return "Car Models cannot exceed 30 characters, please fill it in accordingly.";
            }
            //if the car model length is less than 2 characters
            if (CarModel.Length < 2)
            {
                //return the following error message
                return "The Car Models is too short, please fill it in accordingly.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            
            return Error;
        }
    }
}