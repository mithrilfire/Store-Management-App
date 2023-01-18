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
            this.stokPanel = new System.Windows.Forms.Panel();
            this.tedarikciDataGrid = new System.Windows.Forms.DataGridView();
            this.tedarikciLbl = new System.Windows.Forms.Label();
            this.temizleBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uyariLbl = new System.Windows.Forms.Label();
            this.stokEkleBtn = new System.Windows.Forms.Button();
            this.stokAraLbl = new System.Windows.Forms.Label();
            this.stokListeleBtn = new System.Windows.Forms.Button();
            this.urunKoduLbl = new System.Windows.Forms.Label();
            this.stoklarTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.stokPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(793, 714);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // stokPanel
            // 
            this.stokPanel.Controls.Add(this.tedarikciDataGrid);
            this.stokPanel.Controls.Add(this.tedarikciLbl);
            this.stokPanel.Controls.Add(this.temizleBtn);
            this.stokPanel.Controls.Add(this.panel1);
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
            // tedarikciDataGrid
            // 
            this.tedarikciDataGrid.AllowUserToAddRows = false;
            this.tedarikciDataGrid.AllowUserToDeleteRows = false;
            this.tedarikciDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tedarikciDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciDataGrid.Location = new System.Drawing.Point(19, 402);
            this.tedarikciDataGrid.Name = "tedarikciDataGrid";
            this.tedarikciDataGrid.ReadOnly = true;
            this.tedarikciDataGrid.RowTemplate.Height = 25;
            this.tedarikciDataGrid.Size = new System.Drawing.Size(292, 197);
            this.tedarikciDataGrid.TabIndex = 20;
            this.tedarikciDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tedarikciDataGrid_CellClick);
            // 
            // tedarikciLbl
            // 
            this.tedarikciLbl.AutoSize = true;
            this.tedarikciLbl.BackColor = System.Drawing.Color.Transparent;
            this.tedarikciLbl.Location = new System.Drawing.Point(132, 371);
            this.tedarikciLbl.Name = "tedarikciLbl";
            this.tedarikciLbl.Size = new System.Drawing.Size(66, 15);
            this.tedarikciLbl.TabIndex = 19;
            this.tedarikciLbl.Text = "Tedarikçiler";
            // 
            // temizleBtn
            // 
            this.temizleBtn.Location = new System.Drawing.Point(182, 254);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(82, 24);
            this.temizleBtn.TabIndex = 18;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.UseVisualStyleBackColor = true;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uyariLbl);
            this.panel1.Location = new System.Drawing.Point(10, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 54);
            this.panel1.TabIndex = 17;
            // 
            // uyariLbl
            // 
            this.uyariLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uyariLbl.ForeColor = System.Drawing.Color.Red;
            this.uyariLbl.Location = new System.Drawing.Point(0, 0);
            this.uyariLbl.Name = "uyariLbl";
            this.uyariLbl.Size = new System.Drawing.Size(311, 54);
            this.uyariLbl.TabIndex = 16;
            this.uyariLbl.Text = "Uyarı";
            this.uyariLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uyariLbl.Visible = false;
            // 
            // stokEkleBtn
            // 
            this.stokEkleBtn.Location = new System.Drawing.Point(110, 605);
            this.stokEkleBtn.Name = "stokEkleBtn";
            this.stokEkleBtn.Size = new System.Drawing.Size(110, 42);
            this.stokEkleBtn.TabIndex = 15;
            this.stokEkleBtn.Text = "Stok Ekle";
            this.stokEkleBtn.UseVisualStyleBackColor = true;
            this.stokEkleBtn.Click += new System.EventHandler(this.stokEkleBtn_Click);
            // 
            // stokAraLbl
            // 
            this.stokAraLbl.AutoSize = true;
            this.stokAraLbl.BackColor = System.Drawing.Color.Transparent;
            this.stokAraLbl.Location = new System.Drawing.Point(140, 148);
            this.stokAraLbl.Name = "stokAraLbl";
            this.stokAraLbl.Size = new System.Drawing.Size(51, 15);
            this.stokAraLbl.TabIndex = 11;
            this.stokAraLbl.Text = "Stok Ara";
            // 
            // stokListeleBtn
            // 
            this.stokListeleBtn.Location = new System.Drawing.Point(71, 254);
            this.stokListeleBtn.Name = "stokListeleBtn";
            this.stokListeleBtn.Size = new System.Drawing.Size(82, 24);
            this.stokListeleBtn.TabIndex = 14;
            this.stokListeleBtn.Text = "Listele";
            this.stokListeleBtn.UseVisualStyleBackColor = true;
            this.stokListeleBtn.Click += new System.EventHandler(this.stokListeleBtn_Click);
            // 
            // urunKoduLbl
            // 
            this.urunKoduLbl.AutoSize = true;
            this.urunKoduLbl.BackColor = System.Drawing.Color.Transparent;
            this.urunKoduLbl.Location = new System.Drawing.Point(48, 201);
            this.urunKoduLbl.Name = "urunKoduLbl";
            this.urunKoduLbl.Size = new System.Drawing.Size(64, 15);
            this.urunKoduLbl.TabIndex = 12;
            this.urunKoduLbl.Text = "Ürün Kodu";
            // 
            // stoklarTxtBox
            // 
            this.stoklarTxtBox.Location = new System.Drawing.Point(123, 197);
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
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView1;
        private Panel stokPanel;
        private Button stokEkleBtn;
        private Label stokAraLbl;
        private Button stokListeleBtn;
        private Label urunKoduLbl;
        private TextBox stoklarTxtBox;
        private Label uyariLbl;
        private Button temizleBtn;
        private Panel panel1;
        private DataGridView tedarikciDataGrid;
        private Label tedarikciLbl;
    }
}
