namespace MarketOtomasyonu.UserControls.Reports
{
    partial class marketTrendRapor
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
            this.marketTrendBaslikPnl = new System.Windows.Forms.Panel();
            this.marketTrendBaslikLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gosterBtn = new System.Windows.Forms.Button();
            this.bitisDtp = new System.Windows.Forms.DateTimePicker();
            this.baslangicDtp = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trendCch = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.marketTrendBaslikPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // marketTrendBaslikPnl
            // 
            this.marketTrendBaslikPnl.Controls.Add(this.marketTrendBaslikLbl);
            this.marketTrendBaslikPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.marketTrendBaslikPnl.Location = new System.Drawing.Point(8, 8);
            this.marketTrendBaslikPnl.Name = "marketTrendBaslikPnl";
            this.marketTrendBaslikPnl.Size = new System.Drawing.Size(1120, 60);
            this.marketTrendBaslikPnl.TabIndex = 3;
            // 
            // marketTrendBaslikLbl
            // 
            this.marketTrendBaslikLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marketTrendBaslikLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marketTrendBaslikLbl.Location = new System.Drawing.Point(0, 0);
            this.marketTrendBaslikLbl.Name = "marketTrendBaslikLbl";
            this.marketTrendBaslikLbl.Size = new System.Drawing.Size(1120, 60);
            this.marketTrendBaslikLbl.TabIndex = 0;
            this.marketTrendBaslikLbl.Text = "Market Satış Trendi Raporu";
            this.marketTrendBaslikLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gosterBtn);
            this.panel1.Controls.Add(this.bitisDtp);
            this.panel1.Controls.Add(this.baslangicDtp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 62);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç:";
            // 
            // gosterBtn
            // 
            this.gosterBtn.Location = new System.Drawing.Point(760, 20);
            this.gosterBtn.Name = "gosterBtn";
            this.gosterBtn.Size = new System.Drawing.Size(75, 23);
            this.gosterBtn.TabIndex = 2;
            this.gosterBtn.Text = "Göster";
            this.gosterBtn.UseVisualStyleBackColor = true;
            this.gosterBtn.Click += new System.EventHandler(this.gosterBtn_Click);
            // 
            // bitisDtp
            // 
            this.bitisDtp.Location = new System.Drawing.Point(572, 20);
            this.bitisDtp.Name = "bitisDtp";
            this.bitisDtp.Size = new System.Drawing.Size(158, 23);
            this.bitisDtp.TabIndex = 1;
            // 
            // baslangicDtp
            // 
            this.baslangicDtp.Location = new System.Drawing.Point(330, 20);
            this.baslangicDtp.Name = "baslangicDtp";
            this.baslangicDtp.Size = new System.Drawing.Size(158, 23);
            this.baslangicDtp.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.trendCch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(8, 130);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(16);
            this.panel2.Size = new System.Drawing.Size(1120, 556);
            this.panel2.TabIndex = 5;
            // 
            // trendCch
            // 
            this.trendCch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trendCch.Location = new System.Drawing.Point(16, 16);
            this.trendCch.Name = "trendCch";
            this.trendCch.Size = new System.Drawing.Size(1088, 524);
            this.trendCch.TabIndex = 0;
            // 
            // marketTrendRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.marketTrendBaslikPnl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "marketTrendRapor";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1136, 694);
            this.marketTrendBaslikPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel marketTrendBaslikPnl;
        private Label marketTrendBaslikLbl;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button gosterBtn;
        private DateTimePicker bitisDtp;
        private DateTimePicker baslangicDtp;
        private Panel panel2;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart trendCch;
    }
}
