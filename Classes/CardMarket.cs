using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project_Console_App.Classes
{
    public class CardMarket
    {
        public string? currencyCode { get; set; }
        public string? currencyCodeUsed { get; set; }
        public DateTime? lastUpdatedAt { get; set; }
        public LowPrice? lowPrice { get; set; }
        public AverageSellPrice? averageSellPrice { get; set; }
        public TrendPrice? trendPrice { get; set; }
        public AverageOneDay? averageOneDay { get; set; }
        public AverageSevenDay? averageSevenDay { get; set; }
        public AverageThirtyDay? averageThirtyDay { get; set; }

    }
}
