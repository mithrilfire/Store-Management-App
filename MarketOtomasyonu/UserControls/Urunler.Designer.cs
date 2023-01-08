namespace MarketOtomasyonu.UserControls
{
    partial class Urunler
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
            this.uKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAdeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunPanel = new System.Windows.Forms.Panel();
            this.urunListeleBtn = new System.Windows.Forms.Button();
            this.urunlerTxtBox = new System.Windows.Forms.TextBox();
            this.urunAdiLbl = new System.Windows.Forms.Label();
            this.urunAraLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.urunPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uKodu,
            this.uAdi,
            this.barkod,
            this.uBFiyati,
            this.uAdeti});
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(786, 714);
            this.dataGridView1.TabIndex = 0;
            // 
            // uKodu
            // 
            this.uKodu.HeaderText = "Ürün Kodu";
            this.uKodu.Name = "uKodu";
            this.uKodu.ReadOnly = true;
            // 
            // uAdi
            // 
            this.uAdi.HeaderText = "Ürün Adı";
            this.uAdi.Name = "uAdi";
            this.uAdi.ReadOnly = true;
            // 
            // barkod
            // 
            this.barkod.HeaderText = "Barkod";
            this.barkod.Name = "barkod";
            this.barkod.ReadOnly = true;
            // 
            // uBFiyati
            // 
            this.uBFiyati.HeaderText = "Ürün Birim Fiyatı";
            this.uBFiyati.Name = "uBFiyati";
            // 
            // uAdeti
            // 
            this.uAdeti.HeaderText = "Ürün Adeti";
            this.uAdeti.Name = "uAdeti";
            this.uAdeti.ReadOnly = true;
            // 
            // urunPanel
            // 
            this.urunPanel.Controls.Add(this.urunListeleBtn);
            this.urunPanel.Controls.Add(this.urunlerTxtBox);
            this.urunPanel.Controls.Add(this.urunAdiLbl);
            this.urunPanel.Controls.Add(this.urunAraLbl);
            this.urunPanel.Location = new System.Drawing.Point(803, 11);
            this.urunPanel.Name = "urunPanel";
            this.urunPanel.Size = new System.Drawing.Size(347, 714);
            this.urunPanel.TabIndex = 1;
            // 
            // urunListeleBtn
            // 
            this.urunListeleBtn.Location = new System.Drawing.Point(156, 383);
            this.urunListeleBtn.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.urunListeleBtn.Name = "urunListeleBtn";
            this.urunListeleBtn.Size = new System.Drawing.Size(82, 24);
            this.urunListeleBtn.TabIndex = 22;
            this.urunListeleBtn.Text = "Listele";
            this.urunListeleBtn.UseVisualStyleBackColor = true;
            // 
            // urunlerTxtBox
            // 
            this.urunlerTxtBox.Location = new System.Drawing.Point(157, 341);
            this.urunlerTxtBox.Name = "urunlerTxtBox";
            this.urunlerTxtBox.Size = new System.Drawing.Size(117, 23);
            this.urunlerTxtBox.TabIndex = 21;
            // 
            // urunAdiLbl
            // 
            this.urunAdiLbl.AutoSize = true;
            this.urunAdiLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.urunAdiLbl.Location = new System.Drawing.Point(73, 345);
            this.urunAdiLbl.Name = "urunAdiLbl";
            this.urunAdiLbl.Size = new System.Drawing.Size(54, 15);
            this.urunAdiLbl.TabIndex = 20;
            this.urunAdiLbl.Text = "Ürün Adı";
            // 
            // urunAraLbl
            // 
            this.urunAraLbl.AutoSize = true;
            this.urunAraLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.urunAraLbl.Location = new System.Drawing.Point(170, 307);
            this.urunAraLbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 16);
            this.urunAraLbl.Name = "urunAraLbl";
            this.urunAraLbl.Size = new System.Drawing.Size(54, 15);
            this.urunAraLbl.TabIndex = 19;
            this.urunAraLbl.Text = "Ürün Ara";
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.urunPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Urunler";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.urunPanel.ResumeLayout(false);
            this.urunPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Panel urunPanel;
        private Button urunListeleBtn;
        private TextBox urunlerTxtBox;
        private Label urunAdiLbl;
        private Label urunAraLbl;
        private DataGridViewTextBoxColumn uKodu;
        private DataGridViewTextBoxColumn uAdi;
        private DataGridViewTextBoxColumn barkod;
        private DataGridViewTextBoxColumn uBFiyati;
        private DataGridViewTextBoxColumn uAdeti;
    }
}
