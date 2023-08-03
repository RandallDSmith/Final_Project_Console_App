using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Final_Project_Console_App.CardInfo;

namespace Final_Project_Console_App
{
    public class BasicInfo
    {
       // public BasicInfo() { }
        public string? cardId { get; set; }
        public string? name { get; set; }
        public string? cardNumber { get; set; }
        public string? setNumber { get; set; }
        public string? setId { get; set; }
        public string? set { get; set; }
        public string? series { get; set; }
        public string? variant { get; set; }
        public string? superType { get; set; }
        public List<string>? types { get; set; }
        public List<string>? subTypes { get; set; }
        public string? rarity { get; set; }
        public List<string>? pokemon { get; set; }
        public string? artist { get; set; }
        public MinSoldPrice? minSoldPrice { get; set; }
        public LowSoldPrice? lowSoldPrice { get; set; }
        public SoldPrice? soldPrice { get; set; }
        public HighSoldPrice? highSoldPrice { get; set; }
        public MaxSoldPrice? maxSoldPrice { get; set; }
        public int? soldVolume { get; set; }
        public DateTime? soldLastUpdatedAt { get; set; }
        public MinListingPrice? minListingPrice { get; set; }
        public LowListingPrice? lowListingPrice { get; set; }
        public ListingPrice? listingPrice { get; set; }
        public HighListingPrice? highListingPrice { get; set; }
        public MaxListingPrice? maxListingPrice { get; set; }
        public int? listingVolume { get; set; }
        public DateTime? listingLastUpdatedAt { get; set; }
        public Prices? prices { get; set; }

       
    }
}
