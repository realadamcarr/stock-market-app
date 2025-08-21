using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public enum MarketType { Bull, Bear }
        private MarketType selectedMarket;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter both username and email.");
                return;
            }

            User newUser = new User(username, email, password);

            StockMarketForm marketForm = new StockMarketForm(newUser, selectedMarket);
            marketForm.Show();

            // Hide the registration form
            this.Hide();

            DialogResult result = MessageBox.Show("Start in Bull Market? (Yes = Bull, No = Bear)",
        "Market Type", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Cancel)
                return;

            selectedMarket = result == DialogResult.Yes ? MarketType.Bull : MarketType.Bear;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
