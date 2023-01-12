namespace MarketOtomasyonu.UserControls
{
    partial class MarketBorclar
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
            this.tedarikOdemeDataGrid = new System.Windows.Forms.DataGridView();
            this.tedarikBorcDataGrid = new System.Windows.Forms.DataGridView();
            this.tedarikAdiLbl = new System.Windows.Forms.Label();
            this.tedarikAdiTxtbox = new System.Windows.Forms.TextBox();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.irsaliyeNoLbl = new System.Windows.Forms.Label();
            this.tedarikciLbl = new System.Windows.Forms.Label();
            this.kalanBorcLbl = new System.Windows.Forms.Label();
            this.miktarLbl = new System.Windows.Forms.Label();
            this.tedarikciBilgiLbl = new System.Windows.Forms.Label();
            this.irsaliyeNoBilgiLbl = new System.Windows.Forms.Label();
            this.kalanBorcBilgiLbl = new System.Windows.Forms.Label();
            this.miktarTxtbox = new System.Windows.Forms.TextBox();
            this.odemeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikOdemeDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikBorcDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tedarikOdemeDataGrid
            // 
            this.tedarikOdemeDataGrid.AllowUserToAddRows = false;
            this.tedarikOdemeDataGrid.AllowUserToDeleteRows = false;
            this.tedarikOdemeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tedarikOdemeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikOdemeDataGrid.Location = new System.Drawing.Point(55, 62);
            this.tedarikOdemeDataGrid.Name = "tedarikOdemeDataGrid";
            this.tedarikOdemeDataGrid.ReadOnly = true;
            this.tedarikOdemeDataGrid.RowTemplate.Height = 25;
            this.tedarikOdemeDataGrid.Size = new System.Drawing.Size(750, 300);
            this.tedarikOdemeDataGrid.TabIndex = 0;
            // 
            // tedarikBorcDataGrid
            // 
            this.tedarikBorcDataGrid.AllowUserToAddRows = false;
            this.tedarikBorcDataGrid.AllowUserToDeleteRows = false;
            this.tedarikBorcDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tedarikBorcDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikBorcDataGrid.Location = new System.Drawing.Point(55, 445);
            this.tedarikBorcDataGrid.Name = "tedarikBorcDataGrid";
            this.tedarikBorcDataGrid.ReadOnly = true;
            this.tedarikBorcDataGrid.RowTemplate.Height = 25;
            this.tedarikBorcDataGrid.Size = new System.Drawing.Size(750, 300);
            this.tedarikBorcDataGrid.TabIndex = 1;
            this.tedarikBorcDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tedarikBorcDataGrid_CellClick);
            // 
            // tedarikAdiLbl
            // 
            this.tedarikAdiLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikAdiLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tedarikAdiLbl.Location = new System.Drawing.Point(860, 169);
            this.tedarikAdiLbl.Name = "tedarikAdiLbl";
            this.tedarikAdiLbl.Size = new System.Drawing.Size(120, 20);
            this.tedarikAdiLbl.TabIndex = 2;
            this.tedarikAdiLbl.Text = "Tedarikçi Adı :";
            this.tedarikAdiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tedarikAdiTxtbox
            // 
            this.tedarikAdiTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikAdiTxtbox.Location = new System.Drawing.Point(1000, 166);
            this.tedarikAdiTxtbox.Name = "tedarikAdiTxtbox";
            this.tedarikAdiTxtbox.Size = new System.Drawing.Size(120, 29);
            this.tedarikAdiTxtbox.TabIndex = 4;
            // 
            // listeleBtn
            // 
            this.listeleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listeleBtn.Location = new System.Drawing.Point(936, 234);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(90, 30);
            this.listeleBtn.TabIndex = 6;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // irsaliyeNoLbl
            // 
            this.irsaliyeNoLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.irsaliyeNoLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.irsaliyeNoLbl.Location = new System.Drawing.Point(854, 490);
            this.irsaliyeNoLbl.Name = "irsaliyeNoLbl";
            this.irsaliyeNoLbl.Size = new System.Drawing.Size(96, 20);
            this.irsaliyeNoLbl.TabIndex = 7;
            this.irsaliyeNoLbl.Text = "İrsaliye No :";
            this.irsaliyeNoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tedarikciLbl
            // 
            this.tedarikciLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikciLbl.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tedarikciLbl.Location = new System.Drawing.Point(854, 450);
            this.tedarikciLbl.Name = "tedarikciLbl";
            this.tedarikciLbl.Size = new System.Drawing.Size(96, 20);
            this.tedarikciLbl.TabIndex = 8;
            this.tedarikciLbl.Text = "Tedarikçi :";
            this.tedarikciLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kalanBorcLbl
            // 
            this.kalanBorcLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kalanBorcLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.kalanBorcLbl.Location = new System.Drawing.Point(854, 530);
            this.kalanBorcLbl.Name = "kalanBorcLbl";
            this.kalanBorcLbl.Size = new System.Drawing.Size(96, 20);
            this.kalanBorcLbl.TabIndex = 9;
            this.kalanBorcLbl.Text = "Kalan Borç :";
            this.kalanBorcLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // miktarLbl
            // 
            this.miktarLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miktarLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.miktarLbl.Location = new System.Drawing.Point(874, 596);
            this.miktarLbl.Name = "miktarLbl";
            this.miktarLbl.Size = new System.Drawing.Size(96, 20);
            this.miktarLbl.TabIndex = 10;
            this.miktarLbl.Text = "Miktar :";
            this.miktarLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tedarikciBilgiLbl
            // 
            this.tedarikciBilgiLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tedarikciBilgiLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikciBilgiLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tedarikciBilgiLbl.Location = new System.Drawing.Point(960, 450);
            this.tedarikciBilgiLbl.Name = "tedarikciBilgiLbl";
            this.tedarikciBilgiLbl.Size = new System.Drawing.Size(160, 20);
            this.tedarikciBilgiLbl.TabIndex = 11;
            this.tedarikciBilgiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // irsaliyeNoBilgiLbl
            // 
            this.irsaliyeNoBilgiLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.irsaliyeNoBilgiLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.irsaliyeNoBilgiLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.irsaliyeNoBilgiLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.irsaliyeNoBilgiLbl.Location = new System.Drawing.Point(960, 490);
            this.irsaliyeNoBilgiLbl.Name = "irsaliyeNoBilgiLbl";
            this.irsaliyeNoBilgiLbl.Size = new System.Drawing.Size(160, 20);
            this.irsaliyeNoBilgiLbl.TabIndex = 12;
            this.irsaliyeNoBilgiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kalanBorcBilgiLbl
            // 
            this.kalanBorcBilgiLbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.kalanBorcBilgiLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kalanBorcBilgiLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.kalanBorcBilgiLbl.Location = new System.Drawing.Point(960, 530);
            this.kalanBorcBilgiLbl.Name = "kalanBorcBilgiLbl";
            this.kalanBorcBilgiLbl.Size = new System.Drawing.Size(160, 20);
            this.kalanBorcBilgiLbl.TabIndex = 13;
            this.kalanBorcBilgiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miktarTxtbox
            // 
            this.miktarTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miktarTxtbox.Location = new System.Drawing.Point(990, 593);
            this.miktarTxtbox.Name = "miktarTxtbox";
            this.miktarTxtbox.Size = new System.Drawing.Size(120, 29);
            this.miktarTxtbox.TabIndex = 14;
            // 
            // odemeBtn
            // 
            this.odemeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odemeBtn.Location = new System.Drawing.Point(927, 649);
            this.odemeBtn.Name = "odemeBtn";
            this.odemeBtn.Size = new System.Drawing.Size(130, 30);
            this.odemeBtn.TabIndex = 15;
            this.odemeBtn.Text = "Ödeme Yap";
            this.odemeBtn.UseVisualStyleBackColor = true;
            this.odemeBtn.Click += new System.EventHandler(this.odemeBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(0, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1160, 1);
            this.label1.TabIndex = 16;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(337, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tedarikçi Borçları";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(337, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tedarikçi Ödemeleri";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MarketBorclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odemeBtn);
            this.Controls.Add(this.miktarTxtbox);
            this.Controls.Add(this.kalanBorcBilgiLbl);
            this.Controls.Add(this.irsaliyeNoBilgiLbl);
            this.Controls.Add(this.tedarikciBilgiLbl);
            this.Controls.Add(this.miktarLbl);
            this.Controls.Add(this.kalanBorcLbl);
            this.Controls.Add(this.tedarikciLbl);
            this.Controls.Add(this.irsaliyeNoLbl);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.tedarikAdiTxtbox);
            this.Controls.Add(this.tedarikAdiLbl);
            this.Controls.Add(this.tedarikBorcDataGrid);
            this.Controls.Add(this.tedarikOdemeDataGrid);
            this.Name = "MarketBorclar";
            this.Size = new System.Drawing.Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)(this.tedarikOdemeDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikBorcDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tedarikOdemeDataGrid;
        private DataGridView tedarikBorcDataGrid;
        private Label tedarikAdiLbl;
        private TextBox tedarikAdiTxtbox;
        private Button listeleBtn;
        private Label irsaliyeNoLbl;
        private Label tedarikciLbl;
        private Label kalanBorcLbl;
        private Label miktarLbl;
        private Label tedarikciBilgiLbl;
        private Label irsaliyeNoBilgiLbl;
        private Label kalanBorcBilgiLbl;
        private TextBox miktarTxtbox;
        private Button odemeBtn;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
