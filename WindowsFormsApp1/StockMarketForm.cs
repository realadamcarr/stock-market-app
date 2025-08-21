using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Form1;

namespace WindowsFormsApp1
{
    public partial class StockMarketForm : Form
    {
        private User currentUser;
        private MarketType currentMarket;
        private Random random = new Random();
        private List<Stock> stockList = new List<Stock>();
        private List<User> allUsers = new List<User>();

        public StockMarketForm(User user, MarketType market)
        {
            InitializeComponent();
            currentUser = user;
            currentMarket = market;

            this.Text = $"Welcome, {user.Username}! | Balance: €{user.Balance:N2}";
        }

        private void StockMarketForm_Load(object sender, EventArgs e)
        {
            stockList.Add(new Stock("FNTX", "Fantasia Tech", "Tech", 120.50m));
            stockList.Add(new Stock("DRGN", "Dragon Industries", "Energy", 88.30m));
            stockList.Add(new Stock("SHDW", "Shadow Health", "Healthcare", 152.75m));

            dgvStocks.DataSource = null;
            dgvStocks.DataSource = stockList;

            // Add current user and a few fake ones for leaderboard
            allUsers.Add(currentUser);

            User u1 = new User("Alice", "alice@email.com", "pass");
            u1.Portfolio["FNTX"] = 30;
            u1.Balance = 8000;

            User u2 = new User("Bob", "bob@email.com", "pass");
            u2.Portfolio["DRGN"] = 40;
            u2.Balance = 7000;

            User u3 = new User("Charlie", "charlie@email.com", "pass");
            u3.Portfolio["SHDW"] = 20;
            u3.Balance = 9000;

            allUsers.Add(u1);
            allUsers.Add(u2);
            allUsers.Add(u3);


        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (dgvStocks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a stock.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            Stock selectedStock = (Stock)dgvStocks.SelectedRows[0].DataBoundItem;
            decimal totalCost = selectedStock.CurrentPrice * quantity;

            if (totalCost > currentUser.Balance)
            {
                MessageBox.Show("Insufficient balance.");
                return;
            }

            // Deduct balance
            currentUser.Balance -= totalCost;

            // Update portfolio
            if (currentUser.Portfolio.ContainsKey(selectedStock.Symbol))
                currentUser.Portfolio[selectedStock.Symbol] += quantity;
            else
                currentUser.Portfolio[selectedStock.Symbol] = quantity;

            // Update form title to show new balance
            this.Text = $"Welcome, {currentUser.Username}! | Balance: €{currentUser.Balance:N2}";

            MessageBox.Show($"Bought {quantity} shares of {selectedStock.Symbol} for €{totalCost:N2}");
            RefreshPortfolioGrid();

        }
        private void RefreshPortfolioGrid()
        {
            List<PortfolioItem> items = new List<PortfolioItem>();

            foreach (var entry in currentUser.Portfolio)
            {
                items.Add(new PortfolioItem(entry.Key, entry.Value));
            }

            dgvPortfolio.DataSource = null;
            dgvPortfolio.DataSource = items;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (dgvPortfolio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a stock from your portfolio.");
                return;
            }

            if (!int.TryParse(txtSellQuantity.Text, out int quantityToSell) || quantityToSell <= 0)
            {
                MessageBox.Show("Please enter a valid quantity to sell.");
                return;
            }

            string selectedSymbol = ((PortfolioItem)dgvPortfolio.SelectedRows[0].DataBoundItem).Symbol;

            if (!currentUser.Portfolio.ContainsKey(selectedSymbol))
            {
                MessageBox.Show("You do not own this stock.");
                return;
            }

            int ownedQuantity = currentUser.Portfolio[selectedSymbol];
            if (quantityToSell > ownedQuantity)
            {
                MessageBox.Show($"You only own {ownedQuantity} shares.");
                return;
            }

            // Find the stock to get current price
            Stock stock = stockList.Find(s => s.Symbol == selectedSymbol);
            if (stock == null)
            {
                MessageBox.Show("Stock not found.");
                return;
            }

            decimal totalSale = stock.CurrentPrice * quantityToSell;
            currentUser.Balance += totalSale;

            // Update or remove from portfolio
            currentUser.Portfolio[selectedSymbol] -= quantityToSell;
            if (currentUser.Portfolio[selectedSymbol] <= 0)
                currentUser.Portfolio.Remove(selectedSymbol);

            // Update balance display
            this.Text = $"Welcome, {currentUser.Username}! | Balance: €{currentUser.Balance:N2}";

            // Refresh portfolio view
            RefreshPortfolioGrid();

            MessageBox.Show($"Sold {quantityToSell} shares of {selectedSymbol} for €{totalSale:N2}");
        }

        private void marketTimer_Tick(object sender, EventArgs e)
        {
            foreach (var stock in stockList)
            {
                decimal percentChange;

                if (currentMarket == MarketType.Bull)
                    percentChange = (decimal)(random.Next(1, 8)) / 100m; // +1% to +7%
                else
                    percentChange = -(decimal)(random.Next(1, 8)) / 100m; // -1% to -7%

                stock.CurrentPrice += stock.CurrentPrice * percentChange;
                stock.CurrentPrice = Math.Round(stock.CurrentPrice, 2);
                stock.PriceHistory.Add(new PriceHistoryEntry(DateTime.Now, stock.CurrentPrice));

            }

            dgvStocks.DataSource = null;
            dgvStocks.DataSource = stockList;

            if (random.Next(0, 100) < 5)
            {
                TriggerBlackSwanEvent();
            }

            RefreshLeaderboard();
        }

        private void TriggerBlackSwanEvent()
        {
            string[] sectors = { "Tech", "Energy", "Healthcare" };
            string chosenSector = sectors[random.Next(sectors.Length)];
            int direction = random.Next(2) == 0 ? 1 : -1;
            decimal magnitude = direction * 0.5m; // ±50%

            foreach (var stock in stockList)
            {
                if (stock.Sector == chosenSector)
                {
                    stock.CurrentPrice += stock.CurrentPrice * magnitude;
                    stock.CurrentPrice = Math.Max(1, Math.Round(stock.CurrentPrice, 2)); // prevent negatives
                }
            }

            string eventMessage = direction > 0
                ? $"📈 BLACK SWAN EVENT! Boom in {chosenSector} sector! Prices up 50%!"
                : $"📉 BLACK SWAN EVENT! Crash in {chosenSector} sector! Prices down 50%!";

            MessageBox.Show(eventMessage, "Black Swan Event", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RefreshLeaderboard()
        {
            List<LeaderboardItem> rankings = new List<LeaderboardItem>();

            foreach (var user in allUsers)
            {
                decimal portfolioValue = 0;

                foreach (var holding in user.Portfolio)
                {
                    Stock stock = stockList.Find(s => s.Symbol == holding.Key);
                    if (stock != null)
                    {
                        portfolioValue += holding.Value * stock.CurrentPrice;
                    }
                }

                decimal netWorth = user.Balance + portfolioValue;
                rankings.Add(new LeaderboardItem(user.Username, Math.Round(netWorth, 2)));
            }

            var top5 = rankings.OrderByDescending(r => r.NetWorth).Take(5).ToList();

            dgvLeaderboard.DataSource = null;
            dgvLeaderboard.DataSource = top5;
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            if (dgvStocks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a stock to view history.");
                return;
            }

            Stock selectedStock = (Stock)dgvStocks.SelectedRows[0].DataBoundItem;

            string history = string.Join(Environment.NewLine,
                selectedStock.PriceHistory.Select(h => $"{h.Timestamp:G} → €{h.Price:N2}"));

            MessageBox.Show(history, $"Price History for {selectedStock.Symbol}");
        }
    }
}
