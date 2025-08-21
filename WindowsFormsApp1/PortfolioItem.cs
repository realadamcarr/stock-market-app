using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class PortfolioItem
    {
        public string Symbol { get; set; }
        public int Quantity { get; set; }

        public PortfolioItem(string symbol, int quantity)
        {
            Symbol = symbol;
            Quantity = quantity;
        }
    }
}

