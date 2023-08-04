using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Console_App.Classes
{
    public class TcgPlayer
    {
        public string? currencyCode { get; set; }
        public string? currencyCodeUsed { get; set; }
        public DateTime? lastUpdatedAt { get; set; }
        public Low? low { get; set; }
        public Mid? mid { get; set; }
        public High? high { get; set; }
        public DirectLow? directLow { get; set; }
        public Market? market { get; set; }

    }
}
