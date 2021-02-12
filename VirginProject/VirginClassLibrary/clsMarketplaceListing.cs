using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirginClassLibrary
{
    public class clsMarketplaceListing
    {
        public bool AllowBids { get; set; }
        public bool AllowOffers { get; set; }
        public string Category { get; set; }
        public DateTime CloseDate { get; set; }
        public string DeliveryType { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int ListingID { get; set; }
        public string ListingName { get; set; }
        public bool New { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int UserID { get; set; }
    }
}
