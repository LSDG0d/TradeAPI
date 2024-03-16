
namespace TradeAPI
{
    partial class Form1
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
            this.labelBinance = new System.Windows.Forms.Label();
            this.labelBybit = new System.Windows.Forms.Label();
            this.labelBitget = new System.Windows.Forms.Label();
            this.labelKucoin = new System.Windows.Forms.Label();
            this.comboBoxCoin = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBinance
            // 
            this.labelBinance.AutoSize = true;
            this.labelBinance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBinance.Location = new System.Drawing.Point(12, 9);
            this.labelBinance.Name = "labelBinance";
            this.labelBinance.Size = new System.Drawing.Size(89, 23);
            this.labelBinance.TabIndex = 0;
            this.labelBinance.Text = "Binance: ";
            // 
            // labelBybit
            // 
            this.labelBybit.AutoSize = true;
            this.labelBybit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBybit.Location = new System.Drawing.Point(12, 32);
            this.labelBybit.Name = "labelBybit";
            this.labelBybit.Size = new System.Drawing.Size(67, 23);
            this.labelBybit.TabIndex = 1;
            this.labelBybit.Text = "Bybit: ";
            // 
            // labelBitget
            // 
            this.labelBitget.AutoSize = true;
            this.labelBitget.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBitget.Location = new System.Drawing.Point(12, 55);
            this.labelBitget.Name = "labelBitget";
            this.labelBitget.Size = new System.Drawing.Size(74, 23);
            this.labelBitget.TabIndex = 2;
            this.labelBitget.Text = "Bitget: ";
            // 
            // labelKucoin
            // 
            this.labelKucoin.AutoSize = true;
            this.labelKucoin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKucoin.Location = new System.Drawing.Point(12, 78);
            this.labelKucoin.Name = "labelKucoin";
            this.labelKucoin.Size = new System.Drawing.Size(80, 23);
            this.labelKucoin.TabIndex = 3;
            this.labelKucoin.Text = "Kucoin: ";
            // 
            // comboBoxCoin
            // 
            this.comboBoxCoin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxCoin.FormattingEnabled = true;
            this.comboBoxCoin.Items.AddRange(new object[] {
            "BTCUSDT",
            "ETHUSDT",
            "SOLUSDT",
            "FDUSDUSDT",
            "ETHUSDC",
            "USDCUSDT"});
            this.comboBoxCoin.Location = new System.Drawing.Point(285, 9);
            this.comboBoxCoin.Name = "comboBoxCoin";
            this.comboBoxCoin.Size = new System.Drawing.Size(121, 31);
            this.comboBoxCoin.TabIndex = 4;
            this.comboBoxCoin.Text = "BTCUSDT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxCoin);
            this.panel1.Controls.Add(this.labelBinance);
            this.panel1.Controls.Add(this.labelKucoin);
            this.panel1.Controls.Add(this.labelBybit);
            this.panel1.Controls.Add(this.labelBitget);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 131);
            this.panel1.TabIndex = 5;
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 5000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 131);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "TradeAPI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBinance;
        private System.Windows.Forms.Label labelBybit;
        private System.Windows.Forms.Label labelBitget;
        private System.Windows.Forms.Label labelKucoin;
        private System.Windows.Forms.ComboBox comboBoxCoin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerUpdate;
    }
}

