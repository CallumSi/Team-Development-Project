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

        public string Valid(string CarMake, string CarModel, string CarBody, string CarColour, string CarFuel, string CarRegistration)
        {
            //string variable to store the error message
            string Error = "";
            //if the car make length is more than 30 characters
            if (CarMake.Length > 30)
            {
                //return the following error message
                return "The entered Car Make is not applicable. Please enter a short Car Make.";
            }
            //if the car make length is less than 2 characters
            if (CarMake.Length < 2)
            {
                //return the following error message
                return "The entered Car Make is not applicable. Please enter a longer Car Make.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the car model length is more than 30 characters
            if (CarModel.Length > 30)
            {
                //return the following error message
                return "The entered Car Model is not applicable. Please enter a short Car Make.";
            }
            //if the car model length is less than 2 characters
            if (CarModel.Length < 2)
            {
                //return the following error message
                return "The entered Car Make is not applicable. Please enter a longer Car Make.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the car body length is more than 20 characters
            if (CarBody.Length > 20)
            {
                //return the following error message
                return "The entered body type is not applicable. Please enter a correct body type.";
            }
            //if the car body length is less than 3 characters
            if (CarBody.Length < 3)
            {
                //return the following error message
                return "The entered body type is not applicable. Please enter a correct body type.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the car colour length is more than 25 characters
            if (CarColour.Length > 25)
            {
                //return the following error message
                return "The entered colour is not applicable. Please enter a different colour.";
            }
            //if the car colour length is less than 2 characters
            if (CarColour.Length < 2)
            {
                //return the following error message
                return "The entered colour is not applicable. Please enter a different colour.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the car fuel type length is more than 10 characters
            if (CarFuel.Length > 10)
            {
                //return the following error message
                return "The exclusively acceptable fuel types are Petrol, Diesel or Electric. Please enter the applicable fuel type.";
            }
            //if the car fuel type length is less than 6 characters
            if (CarFuel.Length < 6)
            {
                //return the following error message
                return "The exclusively acceptable fuel types are Petrol, Diesel or Electric. Please enter the applicable fuel type.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the car registration length is more than 11 characters
            if (CarRegistration.Length > 11)
            {
                //return the following error message
                return "A registration number cannot exceed 11 characters. Please enter a shorter registration number.";
            }
            //if the car registrationlength is less than 2 characters
            if (CarRegistration.Length < 2)
            {
                //return the following error message
                return "A registration number must have at least 2 characters. Please enter a longer registration number.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            return Error;
        }
    }
}