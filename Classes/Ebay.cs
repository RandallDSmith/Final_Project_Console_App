using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project_Console_App.Classes;
using static Final_Project_Console_App.CardInfo;

namespace Final_Project_Console_App
{
    public class Ebay
    {
        public string? currencyCode { get; set; }
        public string? priceType { get; set; }
        public List<string>? currenciesUsed { get; set; }
        public DateTime? lastUpdatedAt { get; set; }
        public int? periodSizeDays { get; set; }
        public int? volume { get; set; }
        public StdDev? stdDev { get; set; }
        public MinPrice? minPrice { get; set; }
        public FirstQuartile? firstQuartile { get; set; }
        public Median? median { get; set; }
        public CardInfo.Mean? mean { get; set; }
        public ThirdQuartile? thirdQuartile { get; set; }
        public MaxPrice? maxPrice { get; set; }

    }
}
