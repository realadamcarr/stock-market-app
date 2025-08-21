using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Stock
    {
        public string Symbol { get; set; }
        public string CompanyName { get; set; }
        public string Sector { get; set; }
        public decimal CurrentPrice { get; set; }
        public List<PriceHistoryEntry> PriceHistory { get; set; } = new List<PriceHistoryEntry>();
        public Stock(string symbol, string companyName, string sector, decimal price)
        {
            Symbol = symbol;
            CompanyName = companyName;
            Sector = sector;
            CurrentPrice = price;

            PriceHistory.Add(new PriceHistoryEntry(DateTime.Now, price));
        }
    }
}

