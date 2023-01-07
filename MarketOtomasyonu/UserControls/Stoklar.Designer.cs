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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(818, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 712);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Stok Ekle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 24);
            this.button1.TabIndex = 14;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(48, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(164, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stok Ara";
            // 
            // Stoklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stoklar";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Panel panel1;
        private Button button2;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
    }
}
