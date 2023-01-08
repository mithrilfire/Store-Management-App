namespace MarketOtomasyonu.UserControls
{
    partial class Stoklar
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
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irsaliyeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBGFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAdeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokPanel = new System.Windows.Forms.Panel();
            this.stokEkleBtn = new System.Windows.Forms.Button();
            this.stokAraLbl = new System.Windows.Forms.Label();
            this.stokListeleBtn = new System.Windows.Forms.Button();
            this.urunKoduLbl = new System.Windows.Forms.Label();
            this.stoklarTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.stokPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uKodu,
            this.barkod,
            this.irsaliyeNo,
            this.tNo,
            this.uBGFiyati,
            this.uAdeti});
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(793, 714);
            this.dataGridView1.TabIndex = 5;
            // 
            // uKodu
            // 
            this.uKodu.HeaderText = "Ürün Kodu";
            this.uKodu.Name = "uKodu";
            // 
            // barkod
            // 
            this.barkod.HeaderText = "Barkod";
            this.barkod.Name = "barkod";
            // 
            // irsaliyeNo
            // 
            this.irsaliyeNo.HeaderText = "İrsaliye No";
            this.irsaliyeNo.Name = "irsaliyeNo";
            // 
            // tNo
            // 
            this.tNo.HeaderText = "Tedarikçi No";
            this.tNo.Name = "tNo";
            // 
            // uBGFiyati
            // 
            this.uBGFiyati.HeaderText = "Ürün Girdi Birim Fiyatı";
            this.uBGFiyati.Name = "uBGFiyati";
            // 
            // uAdeti
            // 
            this.uAdeti.HeaderText = "Ürün Adeti";
            this.uAdeti.Name = "uAdeti";
            // 
            // stokPanel
            // 
            this.stokPanel.Controls.Add(this.stokEkleBtn);
            this.stokPanel.Controls.Add(this.stokAraLbl);
            this.stokPanel.Controls.Add(this.stokListeleBtn);
            this.stokPanel.Controls.Add(this.urunKoduLbl);
            this.stokPanel.Controls.Add(this.stoklarTxtBox);
            this.stokPanel.Location = new System.Drawing.Point(818, 14);
            this.stokPanel.Name = "stokPanel";
            this.stokPanel.Size = new System.Drawing.Size(330, 712);
            this.stokPanel.TabIndex = 6;
            // 
            // stokEkleBtn
            // 
            this.stokEkleBtn.Location = new System.Drawing.Point(122, 519);
            this.stokEkleBtn.Name = "stokEkleBtn";
            this.stokEkleBtn.Size = new System.Drawing.Size(110, 42);
            this.stokEkleBtn.TabIndex = 15;
            this.stokEkleBtn.Text = "Stok Ekle";
            this.stokEkleBtn.UseVisualStyleBackColor = true;
            // 
            // stokAraLbl
            // 
            this.stokAraLbl.AutoSize = true;
            this.stokAraLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.stokAraLbl.Location = new System.Drawing.Point(164, 148);
            this.stokAraLbl.Name = "stokAraLbl";
            this.stokAraLbl.Size = new System.Drawing.Size(51, 15);
            this.stokAraLbl.TabIndex = 11;
            this.stokAraLbl.Text = "Stok Ara";
            // 
            // stokListeleBtn
            // 
            this.stokListeleBtn.Location = new System.Drawing.Point(148, 256);
            this.stokListeleBtn.Name = "stokListeleBtn";
            this.stokListeleBtn.Size = new System.Drawing.Size(82, 24);
            this.stokListeleBtn.TabIndex = 14;
            this.stokListeleBtn.Text = "Listele";
            this.stokListeleBtn.UseVisualStyleBackColor = true;
            // 
            // urunKoduLbl
            // 
            this.urunKoduLbl.AutoSize = true;
            this.urunKoduLbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.urunKoduLbl.Location = new System.Drawing.Point(48, 201);
            this.urunKoduLbl.Name = "urunKoduLbl";
            this.urunKoduLbl.Size = new System.Drawing.Size(64, 15);
            this.urunKoduLbl.TabIndex = 12;
            this.urunKoduLbl.Text = "Ürün Kodu";
            // 
            // stoklarTxtBox
            // 
            this.stoklarTxtBox.Location = new System.Drawing.Point(131, 197);
            this.stoklarTxtBox.Name = "stoklarTxtBox";
            this.stoklarTxtBox.Size = new System.Drawing.Size(117, 23);
            this.stoklarTxtBox.TabIndex = 13;
            // 
            // Stoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stokPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stoklar";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.stokPanel.ResumeLayout(false);
            this.stokPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn uKodu;
        private DataGridViewTextBoxColumn barkod;
        private DataGridViewTextBoxColumn irsaliyeNo;
        private DataGridViewTextBoxColumn tNo;
        private DataGridViewTextBoxColumn uBGFiyati;
        private DataGridViewTextBoxColumn uAdeti;
        private Panel stokPanel;
        private Button stokEkleBtn;
        private Label stokAraLbl;
        private Button stokListeleBtn;
        private Label urunKoduLbl;
        private TextBox stoklarTxtBox;
    }
}
