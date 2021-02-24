using System;

namespace VirginClassLibrary
{
    public class clsVHCHospital
    {
        //Hospital_ID Property
        public int Hospital_ID { get; set; }

        //Hospital_Name Property
        public string Hospital_Name { get; set; }

        //Hospital_Place Property
        public string Hospital_Place { get; set; }

        public string Valid(string Hospital_Name, string Hospital_Place)
        {
            String Error = "";

            // (1) Hospital Name Validation

            //if hospital name is blank 
            if (Hospital_Name.Length == 0)
            {
                //record the error 
                Error = Error + "HOSPITAL NAME CANNOT BE BLANK!" + " ";

            }

            if (Hospital_Name.Length < 1 | Hospital_Name.Length > 50)
            {
                //set the error message 
                Error = Error + "HOSPITAL NAME MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            }

            // (2) Hospital Place Validation

            //if hospital place is blank 
            if (Hospital_Place.Length == 0)
            {
                //record the error 
                Error = Error + "HOSPITAL PLACE CANNOT BE BLANK!" + " ";

            }

            if (Hospital_Place.Length < 1 | Hospital_Place.Length > 50)
            {
                //set the error message 
                Error = Error + "HOSPITAL NAME MUST BE BETWEEN 1 TO 50 CHARACTERS!" + " ";
            }

            return Error; 
        }
    }
}