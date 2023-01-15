namespace MarketOtomasyonu.UserControls.Reports
{
    partial class marketDurumRapor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.urunKarBaslikPnl = new System.Windows.Forms.Panel();
            this.marketKarBaslikLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.marketKarDat = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.marketKarPch = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.marketKarCch = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.urunKarBaslikPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marketKarDat)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunKarBaslikPnl
            // 
            this.urunKarBaslikPnl.Controls.Add(this.marketKarBaslikLbl);
            this.urunKarBaslikPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.urunKarBaslikPnl.Location = new System.Drawing.Point(8, 8);
            this.urunKarBaslikPnl.Name = "urunKarBaslikPnl";
            this.urunKarBaslikPnl.Size = new System.Drawing.Size(1120, 60);
            this.urunKarBaslikPnl.TabIndex = 9;
            // 
            // marketKarBaslikLbl
            // 
            this.marketKarBaslikLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marketKarBaslikLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marketKarBaslikLbl.Location = new System.Drawing.Point(0, 0);
            this.marketKarBaslikLbl.Name = "marketKarBaslikLbl";
            this.marketKarBaslikLbl.Size = new System.Drawing.Size(1120, 60);
            this.marketKarBaslikLbl.TabIndex = 15;
            this.marketKarBaslikLbl.Text = "Market Kar Zarar Durumu Raporu";
            this.marketKarBaslikLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.marketKarDat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(416, 618);
            this.panel1.TabIndex = 10;
            // 
            // marketKarDat
            // 
            this.marketKarDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marketKarDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marketKarDat.Location = new System.Drawing.Point(16, 16);
            this.marketKarDat.Name = "marketKarDat";
            this.marketKarDat.RowTemplate.Height = 25;
            this.marketKarDat.Size = new System.Drawing.Size(384, 586);
            this.marketKarDat.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.marketKarPch);
            this.panel2.Controls.Add(this.marketKarCch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(424, 68);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16);
            this.panel2.Size = new System.Drawing.Size(704, 618);
            this.panel2.TabIndex = 11;
            // 
            // marketKarPch
            // 
            this.marketKarPch.Dock = System.Windows.Forms.DockStyle.Top;
            this.marketKarPch.InitialRotation = 0D;
            this.marketKarPch.IsClockwise = true;
            this.marketKarPch.Location = new System.Drawing.Point(16, 16);
            this.marketKarPch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.marketKarPch.MaxAngle = 360D;
            this.marketKarPch.Name = "marketKarPch";
            this.marketKarPch.Size = new System.Drawing.Size(672, 202);
            this.marketKarPch.TabIndex = 1;
            this.marketKarPch.Total = null;
            // 
            // marketKarCch
            // 
            this.marketKarCch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.marketKarCch.Location = new System.Drawing.Point(16, 229);
            this.marketKarCch.Name = "marketKarCch";
            this.marketKarCch.Size = new System.Drawing.Size(672, 373);
            this.marketKarCch.TabIndex = 0;
            // 
            // marketDurumRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.urunKarBaslikPnl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "marketDurumRapor";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1136, 694);
            this.urunKarBaslikPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.marketKarDat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel urunKarBaslikPnl;
        private Label marketKarBaslikLbl;
        private Panel panel1;
        private Panel panel2;
        private DataGridView marketKarDat;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart marketKarPch;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart marketKarCch;
    }
}
