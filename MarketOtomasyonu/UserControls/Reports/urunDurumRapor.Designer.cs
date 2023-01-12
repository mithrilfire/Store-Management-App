namespace MarketOtomasyonu.UserControls.Reports
{
    partial class urunDurumRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunDurumRapor));
            this.label9 = new System.Windows.Forms.Label();
            this.urunKarAraPnl = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.urunKarBaslikPnl = new System.Windows.Forms.Panel();
            this.urunKarBaslikLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.urunKarTbc = new System.Windows.Forms.TabControl();
            this.urunKarRaporTbp = new System.Windows.Forms.TabPage();
            this.urunKarDat = new System.Windows.Forms.DataGridView();
            this.urunKarAy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKarGelir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKarBorc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKarNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKarGrafikTbp = new System.Windows.Forms.TabPage();
            this.urunKarPch = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.urunKarCch = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.urunKarAraPnl.SuspendLayout();
            this.urunKarBaslikPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.urunKarTbc.SuspendLayout();
            this.urunKarRaporTbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunKarDat)).BeginInit();
            this.urunKarGrafikTbp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(410, 48);
            this.label9.TabIndex = 26;
            this.label9.Text = "Ürün Seçim";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urunKarAraPnl
            // 
            this.urunKarAraPnl.Controls.Add(this.label9);
            this.urunKarAraPnl.Controls.Add(this.label7);
            this.urunKarAraPnl.Controls.Add(this.label2);
            this.urunKarAraPnl.Controls.Add(this.label6);
            this.urunKarAraPnl.Controls.Add(this.listBox1);
            this.urunKarAraPnl.Controls.Add(this.label5);
            this.urunKarAraPnl.Controls.Add(this.textBox1);
            this.urunKarAraPnl.Controls.Add(this.label4);
            this.urunKarAraPnl.Controls.Add(this.button1);
            this.urunKarAraPnl.Controls.Add(this.label3);
            this.urunKarAraPnl.Controls.Add(this.button2);
            this.urunKarAraPnl.Controls.Add(this.label1);
            this.urunKarAraPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.urunKarAraPnl.Location = new System.Drawing.Point(8, 68);
            this.urunKarAraPnl.Margin = new System.Windows.Forms.Padding(0);
            this.urunKarAraPnl.Name = "urunKarAraPnl";
            this.urunKarAraPnl.Padding = new System.Windows.Forms.Padding(8);
            this.urunKarAraPnl.Size = new System.Drawing.Size(432, 618);
            this.urunKarAraPnl.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(158, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(125, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ürün adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(89, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Stok:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Çikolata",
            "Elma",
            "Pasta",
            "Ekmek",
            "Süt",
            "Sucuk",
            "Reçel",
            "Armut",
            "Pirinç"});
            this.listBox1.Location = new System.Drawing.Point(71, 124);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(290, 259);
            this.listBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(158, 449);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ürün Adı";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Ürün adı";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(89, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ürün:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(89, 402);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Gösterilecek Ürün";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(338, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(71, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // urunKarBaslikPnl
            // 
            this.urunKarBaslikPnl.Controls.Add(this.urunKarBaslikLbl);
            this.urunKarBaslikPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.urunKarBaslikPnl.Location = new System.Drawing.Point(8, 8);
            this.urunKarBaslikPnl.Name = "urunKarBaslikPnl";
            this.urunKarBaslikPnl.Size = new System.Drawing.Size(1120, 60);
            this.urunKarBaslikPnl.TabIndex = 8;
            // 
            // urunKarBaslikLbl
            // 
            this.urunKarBaslikLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunKarBaslikLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunKarBaslikLbl.Location = new System.Drawing.Point(0, 0);
            this.urunKarBaslikLbl.Name = "urunKarBaslikLbl";
            this.urunKarBaslikLbl.Size = new System.Drawing.Size(1120, 60);
            this.urunKarBaslikLbl.TabIndex = 15;
            this.urunKarBaslikLbl.Text = "Ürün Kar Zarar Durumu Raporu";
            this.urunKarBaslikLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.urunKarTbc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(440, 68);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(688, 618);
            this.panel1.TabIndex = 9;
            // 
            // urunKarTbc
            // 
            this.urunKarTbc.Controls.Add(this.urunKarRaporTbp);
            this.urunKarTbc.Controls.Add(this.urunKarGrafikTbp);
            this.urunKarTbc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunKarTbc.Location = new System.Drawing.Point(8, 8);
            this.urunKarTbc.Name = "urunKarTbc";
            this.urunKarTbc.SelectedIndex = 0;
            this.urunKarTbc.Size = new System.Drawing.Size(672, 602);
            this.urunKarTbc.TabIndex = 10;
            // 
            // urunKarRaporTbp
            // 
            this.urunKarRaporTbp.Controls.Add(this.urunKarDat);
            this.urunKarRaporTbp.Location = new System.Drawing.Point(4, 24);
            this.urunKarRaporTbp.Name = "urunKarRaporTbp";
            this.urunKarRaporTbp.Padding = new System.Windows.Forms.Padding(8);
            this.urunKarRaporTbp.Size = new System.Drawing.Size(664, 574);
            this.urunKarRaporTbp.TabIndex = 0;
            this.urunKarRaporTbp.Text = "12 Aylık Rapor";
            this.urunKarRaporTbp.UseVisualStyleBackColor = true;
            // 
            // urunKarDat
            // 
            this.urunKarDat.AllowUserToAddRows = false;
            this.urunKarDat.AllowUserToDeleteRows = false;
            this.urunKarDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunKarDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunKarDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKarAy,
            this.urunKarGelir,
            this.urunKarBorc,
            this.urunKarNet});
            this.urunKarDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urunKarDat.Location = new System.Drawing.Point(8, 8);
            this.urunKarDat.Name = "urunKarDat";
            this.urunKarDat.ReadOnly = true;
            this.urunKarDat.RowTemplate.Height = 25;
            this.urunKarDat.Size = new System.Drawing.Size(648, 558);
            this.urunKarDat.TabIndex = 4;
            // 
            // urunKarAy
            // 
            this.urunKarAy.HeaderText = "Ay";
            this.urunKarAy.Name = "urunKarAy";
            this.urunKarAy.ReadOnly = true;
            // 
            // urunKarGelir
            // 
            this.urunKarGelir.HeaderText = "Gelir";
            this.urunKarGelir.Name = "urunKarGelir";
            this.urunKarGelir.ReadOnly = true;
            // 
            // urunKarBorc
            // 
            this.urunKarBorc.HeaderText = "Borç";
            this.urunKarBorc.Name = "urunKarBorc";
            this.urunKarBorc.ReadOnly = true;
            // 
            // urunKarNet
            // 
            this.urunKarNet.HeaderText = "Net Gelir";
            this.urunKarNet.Name = "urunKarNet";
            this.urunKarNet.ReadOnly = true;
            // 
            // urunKarGrafikTbp
            // 
            this.urunKarGrafikTbp.Controls.Add(this.urunKarCch);
            this.urunKarGrafikTbp.Controls.Add(this.urunKarPch);
            this.urunKarGrafikTbp.Location = new System.Drawing.Point(4, 24);
            this.urunKarGrafikTbp.Name = "urunKarGrafikTbp";
            this.urunKarGrafikTbp.Padding = new System.Windows.Forms.Padding(8);
            this.urunKarGrafikTbp.Size = new System.Drawing.Size(664, 574);
            this.urunKarGrafikTbp.TabIndex = 1;
            this.urunKarGrafikTbp.Text = "Grafikler";
            this.urunKarGrafikTbp.UseVisualStyleBackColor = true;
            // 
            // urunKarPch
            // 
            this.urunKarPch.Dock = System.Windows.Forms.DockStyle.Top;
            this.urunKarPch.InitialRotation = 0D;
            this.urunKarPch.IsClockwise = true;
            this.urunKarPch.Location = new System.Drawing.Point(8, 8);
            this.urunKarPch.MaxAngle = 360D;
            this.urunKarPch.Name = "urunKarPch";
            this.urunKarPch.Size = new System.Drawing.Size(648, 172);
            this.urunKarPch.TabIndex = 1;
            this.urunKarPch.Total = null;
            // 
            // urunKarCch
            // 
            this.urunKarCch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.urunKarCch.Location = new System.Drawing.Point(8, 186);
            this.urunKarCch.Name = "urunKarCch";
            this.urunKarCch.Size = new System.Drawing.Size(648, 380);
            this.urunKarCch.TabIndex = 0;
            // 
            // urunDurumRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.urunKarAraPnl);
            this.Controls.Add(this.urunKarBaslikPnl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "urunDurumRapor";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1136, 694);
            this.urunKarAraPnl.ResumeLayout(false);
            this.urunKarAraPnl.PerformLayout();
            this.urunKarBaslikPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.urunKarTbc.ResumeLayout(false);
            this.urunKarRaporTbp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urunKarDat)).EndInit();
            this.urunKarGrafikTbp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label9;
        private Panel urunKarAraPnl;
        private Label label7;
        private Label label2;
        private Label label6;
        private ListBox listBox1;
        private Label label5;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private Label label3;
        private Button button2;
        private Label label1;
        private Panel urunKarBaslikPnl;
        private Label urunKarBaslikLbl;
        private Panel panel1;
        private TabControl urunKarTbc;
        private TabPage urunKarRaporTbp;
        private DataGridView urunKarDat;
        private DataGridViewTextBoxColumn urunKarAy;
        private DataGridViewTextBoxColumn urunKarGelir;
        private DataGridViewTextBoxColumn urunKarBorc;
        private DataGridViewTextBoxColumn urunKarNet;
        private TabPage urunKarGrafikTbp;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart urunKarCch;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart urunKarPch;
    }
}
