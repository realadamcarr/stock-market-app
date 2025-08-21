namespace WindowsFormsApp1
{
    partial class StockMarketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvStocks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.dgvPortfolio = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtSellQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.marketTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dgvLeaderboard = new System.Windows.Forms.DataGridView();
            this.btnViewHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfolio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStocks
            // 
            this.dgvStocks.AllowUserToAddRows = false;
            this.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStocks.Location = new System.Drawing.Point(12, 12);
            this.dgvStocks.Name = "dgvStocks";
            this.dgvStocks.ReadOnly = true;
            this.dgvStocks.RowHeadersWidth = 51;
            this.dgvStocks.RowTemplate.Height = 24;
            this.dgvStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStocks.Size = new System.Drawing.Size(615, 392);
            this.dgvStocks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(666, 80);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(666, 123);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy Stock";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // dgvPortfolio
            // 
            this.dgvPortfolio.AllowUserToAddRows = false;
            this.dgvPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPortfolio.Location = new System.Drawing.Point(791, 42);
            this.dgvPortfolio.Name = "dgvPortfolio";
            this.dgvPortfolio.ReadOnly = true;
            this.dgvPortfolio.RowHeadersWidth = 51;
            this.dgvPortfolio.RowTemplate.Height = 24;
            this.dgvPortfolio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPortfolio.Size = new System.Drawing.Size(478, 392);
            this.dgvPortfolio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Portfolio";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(666, 320);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 8;
            this.btnSell.Text = "Sell Stock";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // txtSellQuantity
            // 
            this.txtSellQuantity.Location = new System.Drawing.Point(666, 277);
            this.txtSellQuantity.Name = "txtSellQuantity";
            this.txtSellQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtSellQuantity.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(663, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity to Sell";
            // 
            // marketTimer
            // 
            this.marketTimer.Enabled = true;
            this.marketTimer.Interval = 5000;
            this.marketTimer.Tick += new System.EventHandler(this.marketTimer_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1335, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Top 5 traders";
            // 
            // dgvLeaderboard
            // 
            this.dgvLeaderboard.AllowUserToAddRows = false;
            this.dgvLeaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaderboard.Location = new System.Drawing.Point(1338, 42);
            this.dgvLeaderboard.Name = "dgvLeaderboard";
            this.dgvLeaderboard.ReadOnly = true;
            this.dgvLeaderboard.RowHeadersWidth = 51;
            this.dgvLeaderboard.RowTemplate.Height = 24;
            this.dgvLeaderboard.Size = new System.Drawing.Size(465, 392);
            this.dgvLeaderboard.TabIndex = 10;
            // 
            // btnViewHistory
            // 
            this.btnViewHistory.Location = new System.Drawing.Point(666, 381);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new System.Drawing.Size(92, 43);
            this.btnViewHistory.TabIndex = 11;
            this.btnViewHistory.Text = "View Price History";
            this.btnViewHistory.UseVisualStyleBackColor = true;
            this.btnViewHistory.Click += new System.EventHandler(this.btnViewHistory_Click);
            // 
            // StockMarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 500);
            this.Controls.Add(this.btnViewHistory);
            this.Controls.Add(this.dgvLeaderboard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.txtSellQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPortfolio);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStocks);
            this.Name = "StockMarketForm";
            this.Text = "StockMarketForm";
            this.Load += new System.EventHandler(this.StockMarketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortfolio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaderboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dgvPortfolio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.TextBox txtSellQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer marketTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvLeaderboard;
        private System.Windows.Forms.Button btnViewHistory;
    }
}