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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YoneticiCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AdiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.per_yon_ckb = new System.Windows.Forms.CheckBox();
            this.per_pass_txt = new System.Windows.Forms.TextBox();
            this.per_pass_lbl = new System.Windows.Forms.Label();
            this.per_nick_txt = new System.Windows.Forms.TextBox();
            this.per_nick_lbl = new System.Windows.Forms.Label();
            this.per_soy_txt = new System.Windows.Forms.TextBox();
            this.per_soy_lbl = new System.Windows.Forms.Label();
            this.per_ad_txt = new System.Windows.Forms.TextBox();
            this.per_ad_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCol,
            this.YoneticiCol,
            this.AdiCol,
            this.SoyCol,
            this.UsernameCol,
            this.PassCol});
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(750, 736);
            this.dataGridView1.TabIndex = 0;
            // 
            // IdCol
            // 
            this.IdCol.HeaderText = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.ReadOnly = true;
            // 
            // YoneticiCol
            // 
            this.YoneticiCol.HeaderText = "Yönetici";
            this.YoneticiCol.Name = "YoneticiCol";
            this.YoneticiCol.ReadOnly = true;
            // 
            // AdiCol
            // 
            this.AdiCol.FillWeight = 150F;
            this.AdiCol.HeaderText = "Adı";
            this.AdiCol.Name = "AdiCol";
            this.AdiCol.ReadOnly = true;
            // 
            // SoyCol
            // 
            this.SoyCol.FillWeight = 150F;
            this.SoyCol.HeaderText = "Soyadı";
            this.SoyCol.Name = "SoyCol";
            this.SoyCol.ReadOnly = true;
            // 
            // UsernameCol
            // 
            this.UsernameCol.FillWeight = 150F;
            this.UsernameCol.HeaderText = "Kullanıcı Adı";
            this.UsernameCol.Name = "UsernameCol";
            this.UsernameCol.ReadOnly = true;
            // 
            // PassCol
            // 
            this.PassCol.FillWeight = 150F;
            this.PassCol.HeaderText = "Şifre";
            this.PassCol.Name = "PassCol";
            this.PassCol.ReadOnly = true;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(34, 329);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(75, 23);
            this.ekleBtn.TabIndex = 9;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(155, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uyarı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // per_yon_ckb
            // 
            this.per_yon_ckb.AutoSize = true;
            this.per_yon_ckb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.per_yon_ckb.Location = new System.Drawing.Point(165, 277);
            this.per_yon_ckb.Name = "per_yon_ckb";
            this.per_yon_ckb.Size = new System.Drawing.Size(70, 19);
            this.per_yon_ckb.TabIndex = 8;
            this.per_yon_ckb.Text = "Yönetici";
            this.per_yon_ckb.UseVisualStyleBackColor = true;
            // 
            // per_pass_txt
            // 
            this.per_pass_txt.Location = new System.Drawing.Point(165, 236);
            this.per_pass_txt.Name = "per_pass_txt";
            this.per_pass_txt.Size = new System.Drawing.Size(100, 23);
            this.per_pass_txt.TabIndex = 7;
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
            // per_nick_txt
            // 
            this.per_nick_txt.Location = new System.Drawing.Point(165, 196);
            this.per_nick_txt.Name = "per_nick_txt";
            this.per_nick_txt.Size = new System.Drawing.Size(100, 23);
            this.per_nick_txt.TabIndex = 5;
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
            // per_soy_txt
            // 
            this.per_soy_txt.Location = new System.Drawing.Point(225, 156);
            this.per_soy_txt.Name = "per_soy_txt";
            this.per_soy_txt.Size = new System.Drawing.Size(100, 23);
            this.per_soy_txt.TabIndex = 3;
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
            // per_ad_txt
            // 
            this.per_ad_txt.Location = new System.Drawing.Point(58, 156);
            this.per_ad_txt.Name = "per_ad_txt";
            this.per_ad_txt.Size = new System.Drawing.Size(107, 23);
            this.per_ad_txt.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kaldır";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ekleBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.per_yon_ckb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.per_pass_txt);
            this.panel1.Controls.Add(this.per_soy_lbl);
            this.panel1.Controls.Add(this.per_pass_lbl);
            this.panel1.Controls.Add(this.per_ad_txt);
            this.panel1.Controls.Add(this.per_nick_txt);
            this.panel1.Controls.Add(this.per_soy_txt);
            this.panel1.Controls.Add(this.per_nick_lbl);
            this.panel1.Controls.Add(this.per_ad_lbl);
            this.panel1.Location = new System.Drawing.Point(796, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(348, 736);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(71, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Personel Kayıt İşlemleri";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 14;
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Personel";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdCol;
        private DataGridViewCheckBoxColumn YoneticiCol;
        private DataGridViewTextBoxColumn AdiCol;
        private DataGridViewTextBoxColumn SoyCol;
        private DataGridViewTextBoxColumn UsernameCol;
        private DataGridViewTextBoxColumn PassCol;
        private Button ekleBtn;
        private Label label1;
        private CheckBox per_yon_ckb;
        private TextBox per_pass_txt;
        private Label per_pass_lbl;
        private TextBox per_nick_txt;
        private Label per_nick_lbl;
        private TextBox per_soy_txt;
        private Label per_soy_lbl;
        private TextBox per_ad_txt;
        private Label per_ad_lbl;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}
