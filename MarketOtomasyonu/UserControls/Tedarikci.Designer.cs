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
            this.listeleBtn = new System.Windows.Forms.Button();
            this.tedarikciNoTxtbox = new System.Windows.Forms.TextBox();
            this.tedarikciNoLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tedarikciTxtbox
            // 
            this.tedarikciTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikciTxtbox.Location = new System.Drawing.Point(969, 75);
            this.tedarikciTxtbox.Name = "tedarikciTxtbox";
            this.tedarikciTxtbox.Size = new System.Drawing.Size(120, 29);
            this.tedarikciTxtbox.TabIndex = 17;
            // 
            // tedarikciLbl
            // 
            this.tedarikciLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikciLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tedarikciLbl.Location = new System.Drawing.Point(829, 78);
            this.tedarikciLbl.Name = "tedarikciLbl";
            this.tedarikciLbl.Size = new System.Drawing.Size(125, 20);
            this.tedarikciLbl.TabIndex = 16;
            this.tedarikciLbl.Text = "Tedarikçi Adı :";
            this.tedarikciLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listeleBtn
            // 
            this.listeleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listeleBtn.Location = new System.Drawing.Point(919, 175);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(90, 30);
            this.listeleBtn.TabIndex = 15;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            // 
            // tedarikciNoTxtbox
            // 
            this.tedarikciNoTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikciNoTxtbox.Location = new System.Drawing.Point(969, 125);
            this.tedarikciNoTxtbox.Name = "tedarikciNoTxtbox";
            this.tedarikciNoTxtbox.Size = new System.Drawing.Size(120, 29);
            this.tedarikciNoTxtbox.TabIndex = 14;
            // 
            // tedarikciNoLbl
            // 
            this.tedarikciNoLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tedarikciNoLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tedarikciNoLbl.Location = new System.Drawing.Point(829, 128);
            this.tedarikciNoLbl.Name = "tedarikciNoLbl";
            this.tedarikciNoLbl.Size = new System.Drawing.Size(125, 20);
            this.tedarikciNoLbl.TabIndex = 13;
            this.tedarikciNoLbl.Text = "Tedarikçi No :";
            this.tedarikciNoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(702, 626);
            this.dataGridView1.TabIndex = 12;
            // 
            // Tedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tedarikciTxtbox);
            this.Controls.Add(this.tedarikciLbl);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.tedarikciNoTxtbox);
            this.Controls.Add(this.tedarikciNoLbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Tedarikci";
            this.Size = new System.Drawing.Size(1171, 736);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tedarikciTxtbox;
        private Label tedarikciLbl;
        private Button listeleBtn;
        private TextBox tedarikciNoTxtbox;
        private Label tedarikciNoLbl;
        private DataGridView dataGridView1;
    }
}
