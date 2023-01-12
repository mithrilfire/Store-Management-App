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
            this.urunKarBaslikLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.urunKarBaslikPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunKarBaslikPnl
            // 
            this.urunKarBaslikPnl.Controls.Add(this.urunKarBaslikLbl);
            this.urunKarBaslikPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.urunKarBaslikPnl.Location = new System.Drawing.Point(8, 8);
            this.urunKarBaslikPnl.Name = "urunKarBaslikPnl";
            this.urunKarBaslikPnl.Size = new System.Drawing.Size(1120, 60);
            this.urunKarBaslikPnl.TabIndex = 9;
            // 
            // urunKarBaslikLbl
            // 
            this.urunKarBaslikLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunKarBaslikLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunKarBaslikLbl.Location = new System.Drawing.Point(0, 0);
            this.urunKarBaslikLbl.Name = "urunKarBaslikLbl";
            this.urunKarBaslikLbl.Size = new System.Drawing.Size(1120, 60);
            this.urunKarBaslikLbl.TabIndex = 15;
            this.urunKarBaslikLbl.Text = "Market Kar Zarar Durumu Raporu";
            this.urunKarBaslikLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(416, 618);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(384, 586);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pieChart1);
            this.panel2.Controls.Add(this.cartesianChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(424, 68);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16);
            this.panel2.Size = new System.Drawing.Size(704, 618);
            this.panel2.TabIndex = 11;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pieChart1.InitialRotation = 0D;
            this.pieChart1.IsClockwise = true;
            this.pieChart1.Location = new System.Drawing.Point(16, 16);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.pieChart1.MaxAngle = 360D;
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(672, 202);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.Total = null;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cartesianChart1.Location = new System.Drawing.Point(16, 229);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(672, 373);
            this.cartesianChart1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel urunKarBaslikPnl;
        private Label urunKarBaslikLbl;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}
