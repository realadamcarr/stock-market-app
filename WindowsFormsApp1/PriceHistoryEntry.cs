using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class PriceHistoryEntry
    {
        public DateTime Timestamp { get; set; }
        public decimal Price { get; set; }

        public PriceHistoryEntry(DateTime time, decimal price)
        {
            Timestamp = time;
            Price = price;
        }
    }
}
