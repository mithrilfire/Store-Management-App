namespace MarketOtomasyonu.UserControls
{
    partial class Tedarikci
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
            this.tedarikciTxtbox = new System.Windows.Forms.TextBox();
            this.tedarikciLbl = new System.Windows.Forms.Label();
            this.araBtn = new System.Windows.Forms.Button();
            this.tedarikciDataGrid = new System.Windows.Forms.DataGridView();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.duzenleBtn = new System.Windows.Forms.Button();
            this.tedarikciAdresLbl = new System.Windows.Forms.Label();
            this.tedarikçiAdresTxtbox = new System.Windows.Forms.TextBox();
            this.araTxtbox = new System.Windows.Forms.TextBox();
            this.uyariLbl = new System.Windows.Forms.Label();
            this.temizleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tedarikciTxtbox
            // 
            this.tedarikciTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikciTxtbox.Location = new System.Drawing.Point(939, 271);
            this.tedarikciTxtbox.Name = "tedarikciTxtbox";
            this.tedarikciTxtbox.Size = new System.Drawing.Size(171, 29);
            this.tedarikciTxtbox.TabIndex = 17;
            // 
            // tedarikciLbl
            // 
            this.tedarikciLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikciLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tedarikciLbl.Location = new System.Drawing.Point(808, 274);
            this.tedarikciLbl.Name = "tedarikciLbl";
            this.tedarikciLbl.Size = new System.Drawing.Size(125, 20);
            this.tedarikciLbl.TabIndex = 16;
            this.tedarikciLbl.Text = "Tedarikçi Adı :";
            this.tedarikciLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // araBtn
            // 
            this.araBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.araBtn.Location = new System.Drawing.Point(989, 220);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(90, 30);
            this.araBtn.TabIndex = 15;
            this.araBtn.Text = "Ara";
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // tedarikciDataGrid
            // 
            this.tedarikciDataGrid.AllowUserToAddRows = false;
            this.tedarikciDataGrid.AllowUserToDeleteRows = false;
            this.tedarikciDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tedarikciDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciDataGrid.Location = new System.Drawing.Point(55, 55);
            this.tedarikciDataGrid.Name = "tedarikciDataGrid";
            this.tedarikciDataGrid.ReadOnly = true;
            this.tedarikciDataGrid.RowTemplate.Height = 25;
            this.tedarikciDataGrid.Size = new System.Drawing.Size(702, 626);
            this.tedarikciDataGrid.TabIndex = 12;
            this.tedarikciDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ekleBtn
            // 
            this.ekleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekleBtn.Location = new System.Drawing.Point(924, 448);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(90, 30);
            this.ekleBtn.TabIndex = 18;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // duzenleBtn
            // 
            this.duzenleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duzenleBtn.Location = new System.Drawing.Point(828, 448);
            this.duzenleBtn.Name = "duzenleBtn";
            this.duzenleBtn.Size = new System.Drawing.Size(90, 30);
            this.duzenleBtn.TabIndex = 19;
            this.duzenleBtn.Text = "Düzenle";
            this.duzenleBtn.UseVisualStyleBackColor = true;
            this.duzenleBtn.Click += new System.EventHandler(this.duzenleBtn_Click);
            // 
            // tedarikciAdresLbl
            // 
            this.tedarikciAdresLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikciAdresLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tedarikciAdresLbl.Location = new System.Drawing.Point(808, 322);
            this.tedarikciAdresLbl.Name = "tedarikciAdresLbl";
            this.tedarikciAdresLbl.Size = new System.Drawing.Size(125, 20);
            this.tedarikciAdresLbl.TabIndex = 20;
            this.tedarikciAdresLbl.Text = "Tedarikçi Adres :";
            this.tedarikciAdresLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tedarikçiAdresTxtbox
            // 
            this.tedarikçiAdresTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikçiAdresTxtbox.Location = new System.Drawing.Point(939, 319);
            this.tedarikçiAdresTxtbox.Multiline = true;
            this.tedarikçiAdresTxtbox.Name = "tedarikçiAdresTxtbox";
            this.tedarikçiAdresTxtbox.Size = new System.Drawing.Size(171, 110);
            this.tedarikçiAdresTxtbox.TabIndex = 21;
            // 
            // araTxtbox
            // 
            this.araTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.araTxtbox.Location = new System.Drawing.Point(820, 220);
            this.araTxtbox.Name = "araTxtbox";
            this.araTxtbox.PlaceholderText = "Tedarikçi Adı";
            this.araTxtbox.Size = new System.Drawing.Size(144, 29);
            this.araTxtbox.TabIndex = 22;
            // 
            // uyariLbl
            // 
            this.uyariLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uyariLbl.ForeColor = System.Drawing.Color.Red;
            this.uyariLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.uyariLbl.Location = new System.Drawing.Point(808, 183);
            this.uyariLbl.Name = "uyariLbl";
            this.uyariLbl.Size = new System.Drawing.Size(302, 20);
            this.uyariLbl.TabIndex = 23;
            this.uyariLbl.Text = "Uyarı";
            this.uyariLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uyariLbl.Visible = false;
            // 
            // temizleBtn
            // 
            this.temizleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temizleBtn.Location = new System.Drawing.Point(1020, 448);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(90, 30);
            this.temizleBtn.TabIndex = 24;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.UseVisualStyleBackColor = true;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // Tedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.temizleBtn);
            this.Controls.Add(this.uyariLbl);
            this.Controls.Add(this.araTxtbox);
            this.Controls.Add(this.tedarikçiAdresTxtbox);
            this.Controls.Add(this.tedarikciAdresLbl);
            this.Controls.Add(this.duzenleBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.tedarikciTxtbox);
            this.Controls.Add(this.tedarikciLbl);
            this.Controls.Add(this.araBtn);
            this.Controls.Add(this.tedarikciDataGrid);
            this.Name = "Tedarikci";
            this.Size = new System.Drawing.Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tedarikciTxtbox;
        private Label tedarikciLbl;
        private Button araBtn;
        private DataGridView tedarikciDataGrid;
        private Button ekleBtn;
        private Button duzenleBtn;
        private Label tedarikciAdresLbl;
        private TextBox tedarikçiAdresTxtbox;
        private TextBox araTxtbox;
        private Label uyariLbl;
        private Button temizleBtn;
    }
}
