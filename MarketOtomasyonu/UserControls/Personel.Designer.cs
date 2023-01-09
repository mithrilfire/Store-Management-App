namespace MarketOtomasyonu.UserControls
{
    partial class Personel
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
            this.personelDat = new System.Windows.Forms.DataGridView();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.uyariLbl = new System.Windows.Forms.Label();
            this.yoneticiChk = new System.Windows.Forms.CheckBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.per_pass_lbl = new System.Windows.Forms.Label();
            this.kullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.per_nick_lbl = new System.Windows.Forms.Label();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.per_soy_lbl = new System.Windows.Forms.Label();
            this.adTxt = new System.Windows.Forms.TextBox();
            this.per_ad_lbl = new System.Windows.Forms.Label();
            this.kaldirBtn = new System.Windows.Forms.Button();
            this.duzenleBtn = new System.Windows.Forms.Button();
            this.kayitPnl = new System.Windows.Forms.Panel();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.baslikLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personelDat)).BeginInit();
            this.kayitPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // personelDat
            // 
            this.personelDat.AllowUserToAddRows = false;
            this.personelDat.AllowUserToDeleteRows = false;
            this.personelDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personelDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelDat.Location = new System.Drawing.Point(16, 16);
            this.personelDat.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.personelDat.Name = "personelDat";
            this.personelDat.ReadOnly = true;
            this.personelDat.RowTemplate.Height = 25;
            this.personelDat.Size = new System.Drawing.Size(750, 736);
            this.personelDat.TabIndex = 0;
            this.personelDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(34, 329);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(75, 23);
            this.ekleBtn.TabIndex = 9;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // uyariLbl
            // 
            this.uyariLbl.AutoSize = true;
            this.uyariLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uyariLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.uyariLbl.Location = new System.Drawing.Point(155, 49);
            this.uyariLbl.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.uyariLbl.Name = "uyariLbl";
            this.uyariLbl.Size = new System.Drawing.Size(38, 17);
            this.uyariLbl.TabIndex = 4;
            this.uyariLbl.Text = "Uyarı";
            this.uyariLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uyariLbl.Visible = false;
            // 
            // yoneticiChk
            // 
            this.yoneticiChk.AutoSize = true;
            this.yoneticiChk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yoneticiChk.Location = new System.Drawing.Point(165, 277);
            this.yoneticiChk.Name = "yoneticiChk";
            this.yoneticiChk.Size = new System.Drawing.Size(70, 19);
            this.yoneticiChk.TabIndex = 8;
            this.yoneticiChk.Text = "Yönetici";
            this.yoneticiChk.UseVisualStyleBackColor = true;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(165, 236);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(100, 23);
            this.sifreTxt.TabIndex = 7;
            // 
            // per_pass_lbl
            // 
            this.per_pass_lbl.AutoSize = true;
            this.per_pass_lbl.Location = new System.Drawing.Point(126, 239);
            this.per_pass_lbl.Name = "per_pass_lbl";
            this.per_pass_lbl.Size = new System.Drawing.Size(33, 15);
            this.per_pass_lbl.TabIndex = 6;
            this.per_pass_lbl.Text = "Şifre:";
            // 
            // kullaniciAdiTxt
            // 
            this.kullaniciAdiTxt.Location = new System.Drawing.Point(165, 196);
            this.kullaniciAdiTxt.Name = "kullaniciAdiTxt";
            this.kullaniciAdiTxt.Size = new System.Drawing.Size(100, 23);
            this.kullaniciAdiTxt.TabIndex = 5;
            // 
            // per_nick_lbl
            // 
            this.per_nick_lbl.AutoSize = true;
            this.per_nick_lbl.Location = new System.Drawing.Point(83, 199);
            this.per_nick_lbl.Name = "per_nick_lbl";
            this.per_nick_lbl.Size = new System.Drawing.Size(76, 15);
            this.per_nick_lbl.TabIndex = 4;
            this.per_nick_lbl.Text = "Kullanıcı Adı:";
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(225, 156);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(100, 23);
            this.soyadTxt.TabIndex = 3;
            // 
            // per_soy_lbl
            // 
            this.per_soy_lbl.AutoSize = true;
            this.per_soy_lbl.Location = new System.Drawing.Point(174, 159);
            this.per_soy_lbl.Name = "per_soy_lbl";
            this.per_soy_lbl.Size = new System.Drawing.Size(45, 15);
            this.per_soy_lbl.TabIndex = 2;
            this.per_soy_lbl.Text = "Soyadı:";
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(58, 156);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(107, 23);
            this.adTxt.TabIndex = 1;
            // 
            // per_ad_lbl
            // 
            this.per_ad_lbl.AutoSize = true;
            this.per_ad_lbl.Location = new System.Drawing.Point(24, 159);
            this.per_ad_lbl.Name = "per_ad_lbl";
            this.per_ad_lbl.Size = new System.Drawing.Size(28, 15);
            this.per_ad_lbl.TabIndex = 0;
            this.per_ad_lbl.Text = "Adı:";
            // 
            // kaldirBtn
            // 
            this.kaldirBtn.Location = new System.Drawing.Point(240, 329);
            this.kaldirBtn.Name = "kaldirBtn";
            this.kaldirBtn.Size = new System.Drawing.Size(75, 23);
            this.kaldirBtn.TabIndex = 10;
            this.kaldirBtn.Text = "Kaldır";
            this.kaldirBtn.UseVisualStyleBackColor = true;
            this.kaldirBtn.Click += new System.EventHandler(this.kaldirBtn_Click);
            // 
            // duzenleBtn
            // 
            this.duzenleBtn.Location = new System.Drawing.Point(137, 329);
            this.duzenleBtn.Name = "duzenleBtn";
            this.duzenleBtn.Size = new System.Drawing.Size(75, 23);
            this.duzenleBtn.TabIndex = 11;
            this.duzenleBtn.Text = "Düzenle";
            this.duzenleBtn.UseVisualStyleBackColor = true;
            this.duzenleBtn.Click += new System.EventHandler(this.duzenleBtn_Click);
            // 
            // kayitPnl
            // 
            this.kayitPnl.Controls.Add(this.idTxt);
            this.kayitPnl.Controls.Add(this.label3);
            this.kayitPnl.Controls.Add(this.baslikLbl);
            this.kayitPnl.Controls.Add(this.ekleBtn);
            this.kayitPnl.Controls.Add(this.uyariLbl);
            this.kayitPnl.Controls.Add(this.duzenleBtn);
            this.kayitPnl.Controls.Add(this.yoneticiChk);
            this.kayitPnl.Controls.Add(this.kaldirBtn);
            this.kayitPnl.Controls.Add(this.sifreTxt);
            this.kayitPnl.Controls.Add(this.per_soy_lbl);
            this.kayitPnl.Controls.Add(this.per_pass_lbl);
            this.kayitPnl.Controls.Add(this.adTxt);
            this.kayitPnl.Controls.Add(this.kullaniciAdiTxt);
            this.kayitPnl.Controls.Add(this.soyadTxt);
            this.kayitPnl.Controls.Add(this.per_nick_lbl);
            this.kayitPnl.Controls.Add(this.per_ad_lbl);
            this.kayitPnl.Location = new System.Drawing.Point(796, 16);
            this.kayitPnl.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.kayitPnl.Name = "kayitPnl";
            this.kayitPnl.Padding = new System.Windows.Forms.Padding(8);
            this.kayitPnl.Size = new System.Drawing.Size(348, 736);
            this.kayitPnl.TabIndex = 12;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(165, 116);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(100, 23);
            this.idTxt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Id:";
            // 
            // baslikLbl
            // 
            this.baslikLbl.AutoSize = true;
            this.baslikLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.baslikLbl.Location = new System.Drawing.Point(71, 8);
            this.baslikLbl.Name = "baslikLbl";
            this.baslikLbl.Size = new System.Drawing.Size(206, 25);
            this.baslikLbl.TabIndex = 12;
            this.baslikLbl.Text = "Personel Kayıt İşlemleri";
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kayitPnl);
            this.Controls.Add(this.personelDat);
            this.Name = "Personel";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)(this.personelDat)).EndInit();
            this.kayitPnl.ResumeLayout(false);
            this.kayitPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView personelDat;
        private Button ekleBtn;
        private Label uyariLbl;
        private CheckBox yoneticiChk;
        private TextBox sifreTxt;
        private Label per_pass_lbl;
        private TextBox kullaniciAdiTxt;
        private Label per_nick_lbl;
        private TextBox soyadTxt;
        private Label per_soy_lbl;
        private TextBox adTxt;
        private Label per_ad_lbl;
        private Button kaldirBtn;
        private Button duzenleBtn;
        private Panel kayitPnl;
        private Label baslikLbl;
        private TextBox idTxt;
        private Label label3;
    }
}
