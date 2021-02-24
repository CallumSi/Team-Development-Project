using System;

namespace VirginClassLibrary
{
    public class clsVCHHire
    {
        //Car Hire ID property
        public int HireID { get; set; }

        //hire date property
        public DateTime HireDate { get; set; }

        //hire price property
        public decimal HirePrice { get; set; }

        //hire location - address property
        public string HireAddress { get; set; }

        //hire location - postcode property
        public string HirePostCode { get; set; }

        //Car ID property
        //foreign key
        public int CarID { get; set; }
        
        //customer ID property
        //foreign key
        public int CustomerID { get; set; }
        
        //staff ID property
        //foreign key
        public int StaffID { get; set; }

        //driver age property
        public string DriverAge { get; set; }

        //drivers license number property
        public string DriverLicenseNumber { get; set; }
    }
}