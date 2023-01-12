namespace MarketOtomasyonu.UserControls
{
    partial class Musteriler
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
            this.musteridatagrid = new System.Windows.Forms.DataGridView();
            this.araBtn = new System.Windows.Forms.Button();
            this.musSoyadiTxtbox = new System.Windows.Forms.TextBox();
            this.musSoyadiLbl = new System.Windows.Forms.Label();
            this.musAdiTxtbox = new System.Windows.Forms.TextBox();
            this.musAdiLbl = new System.Windows.Forms.Label();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.duzenleBtn = new System.Windows.Forms.Button();
            this.kaldirBtn = new System.Windows.Forms.Button();
            this.uyariLbl = new System.Windows.Forms.Label();
            this.temizleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.musteridatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // musteridatagrid
            // 
            this.musteridatagrid.AllowUserToAddRows = false;
            this.musteridatagrid.AllowUserToDeleteRows = false;
            this.musteridatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.musteridatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteridatagrid.Location = new System.Drawing.Point(55, 55);
            this.musteridatagrid.Name = "musteridatagrid";
            this.musteridatagrid.ReadOnly = true;
            this.musteridatagrid.RowTemplate.Height = 25;
            this.musteridatagrid.Size = new System.Drawing.Size(702, 626);
            this.musteridatagrid.TabIndex = 0;
            this.musteridatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteridatagrid_CellClick);
            // 
            // araBtn
            // 
            this.araBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.araBtn.Location = new System.Drawing.Point(877, 354);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(90, 30);
            this.araBtn.TabIndex = 9;
            this.araBtn.Text = "Ara";
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // musSoyadiTxtbox
            // 
            this.musSoyadiTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musSoyadiTxtbox.Location = new System.Drawing.Point(982, 304);
            this.musSoyadiTxtbox.Name = "musSoyadiTxtbox";
            this.musSoyadiTxtbox.Size = new System.Drawing.Size(120, 29);
            this.musSoyadiTxtbox.TabIndex = 8;
            // 
            // musSoyadiLbl
            // 
            this.musSoyadiLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musSoyadiLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.musSoyadiLbl.Location = new System.Drawing.Point(842, 307);
            this.musSoyadiLbl.Name = "musSoyadiLbl";
            this.musSoyadiLbl.Size = new System.Drawing.Size(125, 20);
            this.musSoyadiLbl.TabIndex = 7;
            this.musSoyadiLbl.Text = "Müşteri Soyadı :";
            this.musSoyadiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // musAdiTxtbox
            // 
            this.musAdiTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musAdiTxtbox.Location = new System.Drawing.Point(982, 254);
            this.musAdiTxtbox.Name = "musAdiTxtbox";
            this.musAdiTxtbox.Size = new System.Drawing.Size(120, 29);
            this.musAdiTxtbox.TabIndex = 11;
            // 
            // musAdiLbl
            // 
            this.musAdiLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musAdiLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.musAdiLbl.Location = new System.Drawing.Point(842, 257);
            this.musAdiLbl.Name = "musAdiLbl";
            this.musAdiLbl.Size = new System.Drawing.Size(125, 20);
            this.musAdiLbl.TabIndex = 10;
            this.musAdiLbl.Text = "Müşteri Adı :";
            this.musAdiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekleBtn.Location = new System.Drawing.Point(996, 354);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(90, 30);
            this.ekleBtn.TabIndex = 12;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // duzenleBtn
            // 
            this.duzenleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duzenleBtn.Location = new System.Drawing.Point(877, 406);
            this.duzenleBtn.Name = "duzenleBtn";
            this.duzenleBtn.Size = new System.Drawing.Size(90, 30);
            this.duzenleBtn.TabIndex = 13;
            this.duzenleBtn.Text = "Düzenle";
            this.duzenleBtn.UseVisualStyleBackColor = true;
            this.duzenleBtn.Click += new System.EventHandler(this.duzenleBtn_Click);
            // 
            // kaldirBtn
            // 
            this.kaldirBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kaldirBtn.Location = new System.Drawing.Point(996, 406);
            this.kaldirBtn.Name = "kaldirBtn";
            this.kaldirBtn.Size = new System.Drawing.Size(90, 30);
            this.kaldirBtn.TabIndex = 14;
            this.kaldirBtn.Text = "Kaldır";
            this.kaldirBtn.UseVisualStyleBackColor = true;
            this.kaldirBtn.Click += new System.EventHandler(this.kaldirBtn_Click);
            // 
            // uyariLbl
            // 
            this.uyariLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uyariLbl.ForeColor = System.Drawing.Color.Red;
            this.uyariLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.uyariLbl.Location = new System.Drawing.Point(809, 212);
            this.uyariLbl.Name = "uyariLbl";
            this.uyariLbl.Size = new System.Drawing.Size(302, 20);
            this.uyariLbl.TabIndex = 24;
            this.uyariLbl.Text = "Uyarı";
            this.uyariLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uyariLbl.Visible = false;
            // 
            // temizleBtn
            // 
            this.temizleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temizleBtn.Location = new System.Drawing.Point(936, 456);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(90, 30);
            this.temizleBtn.TabIndex = 25;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.UseVisualStyleBackColor = true;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.temizleBtn);
            this.Controls.Add(this.uyariLbl);
            this.Controls.Add(this.kaldirBtn);
            this.Controls.Add(this.duzenleBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.musAdiTxtbox);
            this.Controls.Add(this.musAdiLbl);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.musSoyadiTxtbox);
            this.Controls.Add(this.musSoyadiLbl);
            this.Controls.Add(this.musteridatagrid);
            this.Name = "Musteriler";
            this.Size = new System.Drawing.Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)(this.musteridatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView musteridatagrid;
        private Button araBtn;
        private TextBox musSoyadiTxtbox;
        private Label musSoyadiLbl;
        private TextBox musAdiTxtbox;
        private Label musAdiLbl;
        private Button ekleBtn;
        private Button duzenleBtn;
        private Button kaldirBtn;
        private Label uyariLbl;
        private Button temizleBtn;
    }
}
