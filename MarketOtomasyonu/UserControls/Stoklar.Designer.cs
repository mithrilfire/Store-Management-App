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
            dataGridView1 = new DataGridView();
            stokPanel = new Panel();
            tedarikciDataGrid = new DataGridView();
            tedarikciLbl = new Label();
            temizleBtn = new Button();
            panel1 = new Panel();
            uyariLbl = new Label();
            stokEkleBtn = new Button();
            stokAraLbl = new Label();
            stokListeleBtn = new Button();
            urunKoduLbl = new Label();
            stoklarTxtBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            stokPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tedarikciDataGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(793, 714);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // stokPanel
            // 
            stokPanel.Controls.Add(tedarikciDataGrid);
            stokPanel.Controls.Add(tedarikciLbl);
            stokPanel.Controls.Add(temizleBtn);
            stokPanel.Controls.Add(panel1);
            stokPanel.Controls.Add(stokEkleBtn);
            stokPanel.Controls.Add(stokAraLbl);
            stokPanel.Controls.Add(stokListeleBtn);
            stokPanel.Controls.Add(urunKoduLbl);
            stokPanel.Controls.Add(stoklarTxtBox);
            stokPanel.Location = new Point(818, 14);
            stokPanel.Name = "stokPanel";
            stokPanel.Size = new Size(330, 712);
            stokPanel.TabIndex = 6;
            // 
            // tedarikciDataGrid
            // 
            tedarikciDataGrid.AllowUserToAddRows = false;
            tedarikciDataGrid.AllowUserToDeleteRows = false;
            tedarikciDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tedarikciDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tedarikciDataGrid.Location = new Point(19, 402);
            tedarikciDataGrid.Name = "tedarikciDataGrid";
            tedarikciDataGrid.ReadOnly = true;
            tedarikciDataGrid.RowTemplate.Height = 25;
            tedarikciDataGrid.Size = new Size(292, 197);
            tedarikciDataGrid.TabIndex = 20;
            tedarikciDataGrid.CellClick += tedarikciDataGrid_CellClick;
            // 
            // tedarikciLbl
            // 
            tedarikciLbl.AutoSize = true;
            tedarikciLbl.BackColor = Color.Transparent;
            tedarikciLbl.Location = new Point(132, 371);
            tedarikciLbl.Name = "tedarikciLbl";
            tedarikciLbl.Size = new Size(66, 15);
            tedarikciLbl.TabIndex = 19;
            tedarikciLbl.Text = "Tedarikçiler";
            // 
            // temizleBtn
            // 
            temizleBtn.Location = new Point(182, 254);
            temizleBtn.Name = "temizleBtn";
            temizleBtn.Size = new Size(82, 24);
            temizleBtn.TabIndex = 18;
            temizleBtn.Text = "Temizle";
            temizleBtn.UseVisualStyleBackColor = true;
            temizleBtn.Click += temizleBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(uyariLbl);
            panel1.Location = new Point(10, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 54);
            panel1.TabIndex = 17;
            // 
            // uyariLbl
            // 
            uyariLbl.Dock = DockStyle.Fill;
            uyariLbl.ForeColor = Color.Red;
            uyariLbl.Location = new Point(0, 0);
            uyariLbl.Name = "uyariLbl";
            uyariLbl.Size = new Size(311, 54);
            uyariLbl.TabIndex = 16;
            uyariLbl.Text = "Uyarı";
            uyariLbl.TextAlign = ContentAlignment.MiddleCenter;
            uyariLbl.Visible = false;
            // 
            // stokEkleBtn
            // 
            stokEkleBtn.Location = new Point(110, 605);
            stokEkleBtn.Name = "stokEkleBtn";
            stokEkleBtn.Size = new Size(110, 42);
            stokEkleBtn.TabIndex = 15;
            stokEkleBtn.Text = "Stok Ekle";
            stokEkleBtn.UseVisualStyleBackColor = true;
            stokEkleBtn.Click += stokEkleBtn_Click;
            // 
            // stokAraLbl
            // 
            stokAraLbl.AutoSize = true;
            stokAraLbl.BackColor = Color.Transparent;
            stokAraLbl.Location = new Point(140, 148);
            stokAraLbl.Name = "stokAraLbl";
            stokAraLbl.Size = new Size(51, 15);
            stokAraLbl.TabIndex = 11;
            stokAraLbl.Text = "Stok Ara";
            // 
            // stokListeleBtn
            // 
            stokListeleBtn.Location = new Point(71, 254);
            stokListeleBtn.Name = "stokListeleBtn";
            stokListeleBtn.Size = new Size(82, 24);
            stokListeleBtn.TabIndex = 14;
            stokListeleBtn.Text = "Listele";
            stokListeleBtn.UseVisualStyleBackColor = true;
            stokListeleBtn.Click += stokListeleBtn_Click;
            // 
            // urunKoduLbl
            // 
            urunKoduLbl.AutoSize = true;
            urunKoduLbl.BackColor = Color.Transparent;
            urunKoduLbl.Location = new Point(48, 201);
            urunKoduLbl.Name = "urunKoduLbl";
            urunKoduLbl.Size = new Size(64, 15);
            urunKoduLbl.TabIndex = 12;
            urunKoduLbl.Text = "Ürün Kodu";
            // 
            // stoklarTxtBox
            // 
            stoklarTxtBox.Location = new Point(123, 197);
            stoklarTxtBox.Name = "stoklarTxtBox";
            stoklarTxtBox.Size = new Size(117, 23);
            stoklarTxtBox.TabIndex = 13;
            // 
            // Stoklar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(stokPanel);
            Controls.Add(dataGridView1);
            Name = "Stoklar";
            Padding = new Padding(8);
            Size = new Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            stokPanel.ResumeLayout(false);
            stokPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tedarikciDataGrid).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
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
