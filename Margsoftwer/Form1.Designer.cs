namespace Margsoftwer
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayGrossProfitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(884, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "VJ Softwer";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem,
            this.purchasToolStripMenuItem,
            this.receiptToolStripMenuItem,
            this.paymentToolStripMenuItem,
            this.ledgerACToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.salesBookToolStripMenuItem,
            this.todayGrossProfitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // purchasToolStripMenuItem
            // 
            this.purchasToolStripMenuItem.Name = "purchasToolStripMenuItem";
            this.purchasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.purchasToolStripMenuItem.Text = "Purchas";
            this.purchasToolStripMenuItem.Click += new System.EventHandler(this.purchasToolStripMenuItem_Click);
            // 
            // receiptToolStripMenuItem
            // 
            this.receiptToolStripMenuItem.Name = "receiptToolStripMenuItem";
            this.receiptToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.receiptToolStripMenuItem.Text = "Receipt";
            this.receiptToolStripMenuItem.Click += new System.EventHandler(this.receiptToolStripMenuItem_Click);
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            this.paymentToolStripMenuItem.Click += new System.EventHandler(this.paymentToolStripMenuItem_Click);
            // 
            // ledgerACToolStripMenuItem
            // 
            this.ledgerACToolStripMenuItem.Name = "ledgerACToolStripMenuItem";
            this.ledgerACToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.ledgerACToolStripMenuItem.Text = "Ledger A/C";
            this.ledgerACToolStripMenuItem.Click += new System.EventHandler(this.ledgerACToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // salesBookToolStripMenuItem
            // 
            this.salesBookToolStripMenuItem.Name = "salesBookToolStripMenuItem";
            this.salesBookToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.salesBookToolStripMenuItem.Text = "SalesBook";
            this.salesBookToolStripMenuItem.Click += new System.EventHandler(this.salesBookToolStripMenuItem_Click);
            // 
            // todayGrossProfitToolStripMenuItem
            // 
            this.todayGrossProfitToolStripMenuItem.Name = "todayGrossProfitToolStripMenuItem";
            this.todayGrossProfitToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.todayGrossProfitToolStripMenuItem.Text = "Today Gross Profit";
            this.todayGrossProfitToolStripMenuItem.Click += new System.EventHandler(this.todayGrossProfitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayGrossProfitToolStripMenuItem;

    }
}

