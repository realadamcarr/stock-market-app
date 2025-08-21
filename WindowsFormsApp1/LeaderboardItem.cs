using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class LeaderboardItem
    {
        public string Username { get; set; }
        public decimal NetWorth { get; set; }

        public LeaderboardItem(string username, decimal netWorth)
        {
            Username = username;
            NetWorth = netWorth;
        }

    }
}
