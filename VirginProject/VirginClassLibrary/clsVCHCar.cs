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
        public Decimal CarEngine { get; set; }
        
        //Car Body property
        public string CarBody { get; set; }

        //Car Colour property
        public string CarColour { get; set; }

        //Car Fuel type property
        public string CarFuel { get; set; }

        //Car weekly hire Price property
        public Decimal CarPrice { get; set; }

        //Car registration property
        public string CarRegistration { get; set; }

        public string Valid(string CarMake, string CarModel, string CarEngine, string CarBody, string CarColour, string CarFuel, string CarPrice, string CarRegistration)
        {
            //string variable to store the error message
            string Error = "";

            //variables for later uses
            decimal ConvertedCarEngine;
            decimal ConvertedCarPrice;

            //if the car make length is more than blank/null
            if (CarMake.Length == 0)
            {
                //return the following error message
                return "The Car Make may not be left empty. Please enter a Car Make.";
            }
            //if the car make length is more than 30 characters
            if (CarMake.Length > 30)
            {
                //return the following error message
                return "The entered Car Make is not applicable. Please enter a shorter Car Make.";
            }
            //if the car make length is less than 2 characters
            if (CarMake.Length < 2)
            {
                //return the following error message
                return "The entered Car Make is not applicable. Please enter a longer Car Make.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the car model length is more than blank/null
            if (CarModel.Length == 0)
            {
                //return the following error message
                return "The Car Model may not be left empty. Please enter a Car Model.";
            }
            //if the car model length is more than 30 characters
            if (CarModel.Length > 30)
            {
                //return the following error message
                return "The entered Car Model is not applicable. Please enter a shorter Car Model.";
            }
            //if the car model length is less than 2 characters
            if (CarModel.Length < 2)
            {
                //return the following error message
                return "The entered Car Model is not applicable. Please enter a longer Car Model.";
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            
            /*//if the car engine length is more than blank/null
            if (CarEngine.Length == 0)
            {
                //return the following error message
                return "The Car Engine size may not be left empty. Please enter a Car Engine size.";
            }
            //if the car engine length is more than 4 characters
            if (CarEngine.Length > 4)
            {
                //return the following error message
                return "The entered Car Engine size is not applicable. Please enter a shorter Car Engine size.";
            }
            //if the car engine length is less than 3 characters
            if (CarEngine.Length < 3)
            {
                //return the following error message
                return "The entered Car Engine size is not applicable. Please enter a longer Car Engine size.";
            }*/

            //check engine size is in correct format and in range
            if (CarEngine.Length >0)
            {
                try
                {
                    ConvertedCarEngine = Convert.ToDecimal(CarEngine);
                    int decimalplaces = BitConverter.GetBytes(decimal.GetBits(ConvertedCarEngine)[3])[2];
                    if (decimalplaces == 1)
                    {
                        if (ConvertedCarEngine > 0m && ConvertedCarEngine < 10.1m)
                        {
                            Error += "";
                        }
                        else
                        {
                            Error += "Engine size must be between 0.0 and 10.9";
                        }
                    }
                    else
                    {
                        Error += "Engine size must have 1 decimal place";
                    }

                }
                //if the car engine length is more than blank/null
                catch
                {
                    Error += "The car engine size may not be blank and must be in decimal format.";
                }
            } 

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the car body length is more than blank/null
            if (CarBody.Length == 0)
            {
                //return the following error message
                return "The body type may not be left empty. Please enter a body type.";
            }
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
            //if the car colour length is more than blank/null
            if (CarColour.Length == 0)
            {
                //return the following error message
                return "The colour may not be left empty. Please enter a colour.";
            }
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
            //if the fuel type length is more than blank/null
            if (CarFuel.Length == 0)
            {
                //return the following error message
                return "The fuel type may not be left empty. Please enter a fuel type.";
            }
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
            /* //if the car price length is more than blank/null
            if (CarPrice.Length == 0)
            {
                //return the following error message
                return "The hire price may not be left empty. Please enter a hire price.";
            }
            //if the car price length is more than 8 characters
            if (CarPrice.Length > 8)
            {
                //return the following error message
                return "The entered hire price is not applicable. Please enter a shorter hire price.";
            }
            //if the car price length is less than 3 characters
            if (CarPrice.Length < 3)
            {
                //return the following error message
                return "The entered hire price is not applicable. Please enter a longer hire price.";
            } */

            //check car hire price is in correct format and in range
            if (CarPrice.Length > 0)
            {
                try
                {
                    ConvertedCarPrice = Convert.ToDecimal(CarPrice);
                    int decimalplaces = BitConverter.GetBytes(decimal.GetBits(ConvertedCarPrice)[3])[2];
                    if (decimalplaces == 2)
                    {
                        if (ConvertedCarPrice > 50.00m && ConvertedCarPrice < 999.99m)
                        {
                            Error += "";
                        }
                        else
                        {
                            Error += "Car hire price must be between £0.0 and £999.99";
                        }
                    }
                    else
                    {
                        Error += "Car hire price must have 2 decimal place";
                    }

                }
                //if the car hire price length is more than blank/null
                catch
                {
                    Error += "The car hire price may not be blank and must be in decimal format.";
                }
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////// 
            //if the registration number length is more than blank/null
            if (CarRegistration.Length == 0)
            {
                //return the following error message
                return "The registration number may not be left empty. Please enter a registration number.";
            }
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