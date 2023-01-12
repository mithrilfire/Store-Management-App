namespace MarketOtomasyonu.UserControls
{
    partial class Satis
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisAdeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.veresiyePanel = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.musAraLbl = new System.Windows.Forms.Button();
            this.musEkleLbl = new System.Windows.Forms.Button();
            this.musSoyAdiTxtBox = new System.Windows.Forms.TextBox();
            this.musSoyadLbl = new System.Windows.Forms.Label();
            this.musAdiTxtBox = new System.Windows.Forms.TextBox();
            this.musAdiLbl = new System.Windows.Forms.Label();
            this.veresiyeChckBox = new System.Windows.Forms.CheckBox();
            this.tBorcViewLbl = new System.Windows.Forms.Label();
            this.toplamBorcLbl = new System.Windows.Forms.Label();
            this.urunAdetiTxtBox = new System.Windows.Forms.TextBox();
            this.barkodTxtBox = new System.Windows.Forms.TextBox();
            this.urunAdetiLbl = new System.Windows.Forms.Label();
            this.barkodLbl = new System.Windows.Forms.Label();
            this.urunEkleLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.urunleriEkle = new System.Windows.Forms.Button();
            this.urunleriCikar = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.veresiyePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage3.Size = new System.Drawing.Size(1114, 676);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Satış Kayıtları";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNo,
            this.dataGridViewTextBoxColumn1,
            this.satisAdeti,
            this.sTarihi,
            this.sTutar});
            this.dataGridView2.Location = new System.Drawing.Point(11, 11);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1092, 654);
            this.dataGridView2.TabIndex = 0;
            // 
            // sNo
            // 
            this.sNo.HeaderText = "Satış No";
            this.sNo.Name = "sNo";
            this.sNo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Barkod";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // satisAdeti
            // 
            this.satisAdeti.HeaderText = "Satış Adeti";
            this.satisAdeti.Name = "satisAdeti";
            this.satisAdeti.ReadOnly = true;
            // 
            // sTarihi
            // 
            this.sTarihi.HeaderText = "Satış Tarihi";
            this.sTarihi.Name = "sTarihi";
            this.sTarihi.ReadOnly = true;
            // 
            // sTutar
            // 
            this.sTutar.HeaderText = "Satış Tutarı";
            this.sTutar.Name = "sTutar";
            this.sTutar.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.urunleriCikar);
            this.tabPage1.Controls.Add(this.urunleriEkle);
            this.tabPage1.Controls.Add(this.veresiyePanel);
            this.tabPage1.Controls.Add(this.veresiyeChckBox);
            this.tabPage1.Controls.Add(this.tBorcViewLbl);
            this.tabPage1.Controls.Add(this.toplamBorcLbl);
            this.tabPage1.Controls.Add(this.urunAdetiTxtBox);
            this.tabPage1.Controls.Add(this.barkodTxtBox);
            this.tabPage1.Controls.Add(this.urunAdetiLbl);
            this.tabPage1.Controls.Add(this.barkodLbl);
            this.tabPage1.Controls.Add(this.urunEkleLbl);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8);
            this.tabPage1.Size = new System.Drawing.Size(1114, 676);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Perakende Satış";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // veresiyePanel
            // 
            this.veresiyePanel.Controls.Add(this.dataGridView3);
            this.veresiyePanel.Controls.Add(this.musAraLbl);
            this.veresiyePanel.Controls.Add(this.musEkleLbl);
            this.veresiyePanel.Controls.Add(this.musSoyAdiTxtBox);
            this.veresiyePanel.Controls.Add(this.musSoyadLbl);
            this.veresiyePanel.Controls.Add(this.musAdiTxtBox);
            this.veresiyePanel.Controls.Add(this.musAdiLbl);
            this.veresiyePanel.Enabled = false;
            this.veresiyePanel.Location = new System.Drawing.Point(691, 215);
            this.veresiyePanel.Name = "veresiyePanel";
            this.veresiyePanel.Padding = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.veresiyePanel.Size = new System.Drawing.Size(343, 394);
            this.veresiyePanel.TabIndex = 12;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(23, 114);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(297, 207);
            this.dataGridView3.TabIndex = 14;
            // 
            // musAraLbl
            // 
            this.musAraLbl.Location = new System.Drawing.Point(190, 353);
            this.musAraLbl.Name = "musAraLbl";
            this.musAraLbl.Size = new System.Drawing.Size(130, 33);
            this.musAraLbl.TabIndex = 13;
            this.musAraLbl.Text = "Müşteri Ara";
            this.musAraLbl.UseVisualStyleBackColor = true;
            this.musAraLbl.Click += new System.EventHandler(this.musAraLbl_Click);
            // 
            // musEkleLbl
            // 
            this.musEkleLbl.Location = new System.Drawing.Point(23, 353);
            this.musEkleLbl.Name = "musEkleLbl";
            this.musEkleLbl.Size = new System.Drawing.Size(130, 33);
            this.musEkleLbl.TabIndex = 12;
            this.musEkleLbl.Text = "Müşteri Ekle";
            this.musEkleLbl.UseVisualStyleBackColor = true;
            this.musEkleLbl.Click += new System.EventHandler(this.musEkleLbl_Click);
            // 
            // musSoyAdiTxtBox
            // 
            this.musSoyAdiTxtBox.Location = new System.Drawing.Point(172, 58);
            this.musSoyAdiTxtBox.Name = "musSoyAdiTxtBox";
            this.musSoyAdiTxtBox.Size = new System.Drawing.Size(100, 23);
            this.musSoyAdiTxtBox.TabIndex = 11;
            // 
            // musSoyadLbl
            // 
            this.musSoyadLbl.AutoSize = true;
            this.musSoyadLbl.BackColor = System.Drawing.Color.DarkGray;
            this.musSoyadLbl.Location = new System.Drawing.Point(64, 61);
            this.musSoyadLbl.Name = "musSoyadLbl";
            this.musSoyadLbl.Size = new System.Drawing.Size(85, 15);
            this.musSoyadLbl.TabIndex = 10;
            this.musSoyadLbl.Text = "Müşteri Soyadı";
            // 
            // musAdiTxtBox
            // 
            this.musAdiTxtBox.Location = new System.Drawing.Point(172, 20);
            this.musAdiTxtBox.Name = "musAdiTxtBox";
            this.musAdiTxtBox.Size = new System.Drawing.Size(100, 23);
            this.musAdiTxtBox.TabIndex = 8;
            // 
            // musAdiLbl
            // 
            this.musAdiLbl.AutoSize = true;
            this.musAdiLbl.BackColor = System.Drawing.Color.DarkGray;
            this.musAdiLbl.Location = new System.Drawing.Point(64, 20);
            this.musAdiLbl.Name = "musAdiLbl";
            this.musAdiLbl.Size = new System.Drawing.Size(68, 15);
            this.musAdiLbl.TabIndex = 6;
            this.musAdiLbl.Text = "Müşteri Adı";
            // 
            // veresiyeChckBox
            // 
            this.veresiyeChckBox.AutoSize = true;
            this.veresiyeChckBox.Location = new System.Drawing.Point(739, 190);
            this.veresiyeChckBox.Name = "veresiyeChckBox";
            this.veresiyeChckBox.Size = new System.Drawing.Size(95, 19);
            this.veresiyeChckBox.TabIndex = 3;
            this.veresiyeChckBox.Text = "Veresiye Satış";
            this.veresiyeChckBox.UseVisualStyleBackColor = true;
            this.veresiyeChckBox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tBorcViewLbl
            // 
            this.tBorcViewLbl.AutoSize = true;
            this.tBorcViewLbl.BackColor = System.Drawing.Color.DarkGray;
            this.tBorcViewLbl.Location = new System.Drawing.Point(826, 154);
            this.tBorcViewLbl.Name = "tBorcViewLbl";
            this.tBorcViewLbl.Size = new System.Drawing.Size(97, 15);
            this.tBorcViewLbl.TabIndex = 11;
            this.tBorcViewLbl.Text = "                              ";
            // 
            // toplamBorcLbl
            // 
            this.toplamBorcLbl.AutoSize = true;
            this.toplamBorcLbl.BackColor = System.Drawing.Color.DarkGray;
            this.toplamBorcLbl.Location = new System.Drawing.Point(739, 154);
            this.toplamBorcLbl.Name = "toplamBorcLbl";
            this.toplamBorcLbl.Size = new System.Drawing.Size(73, 15);
            this.toplamBorcLbl.TabIndex = 10;
            this.toplamBorcLbl.Text = "Toplam Borç";
            // 
            // urunAdetiTxtBox
            // 
            this.urunAdetiTxtBox.Location = new System.Drawing.Point(824, 111);
            this.urunAdetiTxtBox.Name = "urunAdetiTxtBox";
            this.urunAdetiTxtBox.Size = new System.Drawing.Size(100, 23);
            this.urunAdetiTxtBox.TabIndex = 9;
            // 
            // barkodTxtBox
            // 
            this.barkodTxtBox.Location = new System.Drawing.Point(824, 73);
            this.barkodTxtBox.Name = "barkodTxtBox";
            this.barkodTxtBox.Size = new System.Drawing.Size(100, 23);
            this.barkodTxtBox.TabIndex = 7;
            // 
            // urunAdetiLbl
            // 
            this.urunAdetiLbl.AutoSize = true;
            this.urunAdetiLbl.BackColor = System.Drawing.Color.DarkGray;
            this.urunAdetiLbl.Location = new System.Drawing.Point(739, 115);
            this.urunAdetiLbl.Name = "urunAdetiLbl";
            this.urunAdetiLbl.Size = new System.Drawing.Size(64, 15);
            this.urunAdetiLbl.TabIndex = 5;
            this.urunAdetiLbl.Text = "Ürün Adeti";
            // 
            // barkodLbl
            // 
            this.barkodLbl.AutoSize = true;
            this.barkodLbl.BackColor = System.Drawing.Color.DarkGray;
            this.barkodLbl.Location = new System.Drawing.Point(739, 77);
            this.barkodLbl.Name = "barkodLbl";
            this.barkodLbl.Size = new System.Drawing.Size(44, 15);
            this.barkodLbl.TabIndex = 4;
            this.barkodLbl.Text = "Barkod";
            // 
            // urunEkleLbl
            // 
            this.urunEkleLbl.AutoSize = true;
            this.urunEkleLbl.BackColor = System.Drawing.Color.DarkGray;
            this.urunEkleLbl.Location = new System.Drawing.Point(803, 24);
            this.urunEkleLbl.Name = "urunEkleLbl";
            this.urunEkleLbl.Size = new System.Drawing.Size(57, 15);
            this.urunEkleLbl.TabIndex = 1;
            this.urunEkleLbl.Text = "Ürün Ekle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(591, 654);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(19, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1122, 704);
            this.tabControl1.TabIndex = 1;
            // 
            // urunleriEkle
            // 
            this.urunleriEkle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.urunleriEkle.BackgroundImage = global::MarketOtomasyonu.Properties.Resources.left_arrow;
            this.urunleriEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.urunleriEkle.FlatAppearance.BorderSize = 0;
            this.urunleriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunleriEkle.Location = new System.Drawing.Point(618, 87);
            this.urunleriEkle.Name = "urunleriEkle";
            this.urunleriEkle.Size = new System.Drawing.Size(30, 30);
            this.urunleriEkle.TabIndex = 14;
            this.urunleriEkle.UseVisualStyleBackColor = false;
            this.urunleriEkle.Click += new System.EventHandler(this.urunleriEkle_Click);
            // 
            // urunleriCikar
            // 
            this.urunleriCikar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.urunleriCikar.BackgroundImage = global::MarketOtomasyonu.Properties.Resources.right_arrow;
            this.urunleriCikar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.urunleriCikar.FlatAppearance.BorderSize = 0;
            this.urunleriCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urunleriCikar.Location = new System.Drawing.Point(618, 139);
            this.urunleriCikar.Name = "urunleriCikar";
            this.urunleriCikar.Size = new System.Drawing.Size(30, 30);
            this.urunleriCikar.TabIndex = 15;
            this.urunleriCikar.UseVisualStyleBackColor = false;
            this.urunleriCikar.Click += new System.EventHandler(this.urunleriCikar_Click);
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Satis";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(1160, 768);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.veresiyePanel.ResumeLayout(false);
            this.veresiyePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private TabPage tabPage1;
        private CheckBox veresiyeChckBox;
        private Label urunEkleLbl;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TextBox urunAdetiTxtBox;
        private TextBox musAdiTxtBox;
        private TextBox barkodTxtBox;
        private Label musAdiLbl;
        private Label urunAdetiLbl;
        private Label barkodLbl;
        private Label tBorcViewLbl;
        private Label toplamBorcLbl;
        private Panel veresiyePanel;
        private TextBox musSoyAdiTxtBox;
        private Label musSoyadLbl;
        private Button musEkleLbl;
        private DataGridViewTextBoxColumn sNo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn satisAdeti;
        private DataGridViewTextBoxColumn sTarihi;
        private DataGridViewTextBoxColumn sTutar;
        private Button musAraLbl;
        private DataGridView dataGridView3;
        private Button urunleriCikar;
        private Button urunleriEkle;
    }
}
