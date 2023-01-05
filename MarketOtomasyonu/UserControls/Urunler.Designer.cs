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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAdeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uKodu,
            this.uAdi,
            this.barkod,
            this.uBFiyati,
            this.uAdeti});
            this.dataGridView1.Location = new System.Drawing.Point(24, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(793, 684);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(966, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(859, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(953, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uKodu
            // 
            this.uKodu.HeaderText = "Ürün Kodu";
            this.uKodu.Name = "uKodu";
            this.uKodu.Width = 150;
            // 
            // uAdi
            // 
            this.uAdi.HeaderText = "Ürün Adı";
            this.uAdi.Name = "uAdi";
            this.uAdi.Width = 150;
            // 
            // barkod
            // 
            this.barkod.HeaderText = "Barkod";
            this.barkod.Name = "barkod";
            this.barkod.Width = 150;
            // 
            // uBFiyati
            // 
            this.uBFiyati.HeaderText = "Ürün Birim Fiyatı";
            this.uBFiyati.Name = "uBFiyati";
            this.uBFiyati.Width = 150;
            // 
            // uAdeti
            // 
            this.uAdeti.HeaderText = "Ürün Adeti";
            this.uAdeti.Name = "uAdeti";
            this.uAdeti.Width = 150;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Urunler";
            this.Size = new System.Drawing.Size(1171, 736);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn uKodu;
        private DataGridViewTextBoxColumn uAdi;
        private DataGridViewTextBoxColumn barkod;
        private DataGridViewTextBoxColumn uBFiyati;
        private DataGridViewTextBoxColumn uAdeti;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
    }
}
