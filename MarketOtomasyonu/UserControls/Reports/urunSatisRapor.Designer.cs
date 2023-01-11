namespace MarketOtomasyonu.UserControls.Reports
{
    partial class urunSatisRapor
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
            this.urunSatisBaslikPnl = new System.Windows.Forms.Panel();
            this.urunSatisBaslikLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.urunSatisBaslikPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // urunSatisBaslikPnl
            // 
            this.urunSatisBaslikPnl.Controls.Add(this.urunSatisBaslikLbl);
            this.urunSatisBaslikPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.urunSatisBaslikPnl.Location = new System.Drawing.Point(8, 8);
            this.urunSatisBaslikPnl.Name = "urunSatisBaslikPnl";
            this.urunSatisBaslikPnl.Size = new System.Drawing.Size(1120, 60);
            this.urunSatisBaslikPnl.TabIndex = 0;
            // 
            // urunSatisBaslikLbl
            // 
            this.urunSatisBaslikLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunSatisBaslikLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunSatisBaslikLbl.Location = new System.Drawing.Point(0, 0);
            this.urunSatisBaslikLbl.Name = "urunSatisBaslikLbl";
            this.urunSatisBaslikLbl.Size = new System.Drawing.Size(1120, 60);
            this.urunSatisBaslikLbl.TabIndex = 0;
            this.urunSatisBaslikLbl.Text = "Ürün Satış Trendi Raporu";
            this.urunSatisBaslikLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(772, 618);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(740, 586);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pieChart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(780, 68);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16);
            this.panel2.Size = new System.Drawing.Size(348, 618);
            this.panel2.TabIndex = 2;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.InitialRotation = 0D;
            this.pieChart1.IsClockwise = true;
            this.pieChart1.Location = new System.Drawing.Point(16, 16);
            this.pieChart1.MaxAngle = 360D;
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(316, 586);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Total = null;
            // 
            // urunSatisRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.urunSatisBaslikPnl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "urunSatisRapor";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1136, 694);
            this.urunSatisBaslikPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel urunSatisBaslikPnl;
        private Label urunSatisBaslikLbl;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    }
}
