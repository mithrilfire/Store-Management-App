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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.musSoyadiTxtbox = new System.Windows.Forms.TextBox();
            this.musSoyadiLbl = new System.Windows.Forms.Label();
            this.musAdiTxtbox = new System.Windows.Forms.TextBox();
            this.musAdiLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(702, 626);
            this.dataGridView1.TabIndex = 0;
            // 
            // listeleBtn
            // 
            this.listeleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listeleBtn.Location = new System.Drawing.Point(919, 175);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(90, 30);
            this.listeleBtn.TabIndex = 9;
            this.listeleBtn.Text = "Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            // 
            // musSoyadiTxtbox
            // 
            this.musSoyadiTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musSoyadiTxtbox.Location = new System.Drawing.Point(969, 125);
            this.musSoyadiTxtbox.Name = "musSoyadiTxtbox";
            this.musSoyadiTxtbox.Size = new System.Drawing.Size(120, 29);
            this.musSoyadiTxtbox.TabIndex = 8;
            // 
            // musSoyadiLbl
            // 
            this.musSoyadiLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musSoyadiLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.musSoyadiLbl.Location = new System.Drawing.Point(829, 128);
            this.musSoyadiLbl.Name = "musSoyadiLbl";
            this.musSoyadiLbl.Size = new System.Drawing.Size(125, 20);
            this.musSoyadiLbl.TabIndex = 7;
            this.musSoyadiLbl.Text = "Müşteri Soyadı :";
            this.musSoyadiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // musAdiTxtbox
            // 
            this.musAdiTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musAdiTxtbox.Location = new System.Drawing.Point(969, 75);
            this.musAdiTxtbox.Name = "musAdiTxtbox";
            this.musAdiTxtbox.Size = new System.Drawing.Size(120, 29);
            this.musAdiTxtbox.TabIndex = 11;
            // 
            // musAdiLbl
            // 
            this.musAdiLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musAdiLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.musAdiLbl.Location = new System.Drawing.Point(829, 78);
            this.musAdiLbl.Name = "musAdiLbl";
            this.musAdiLbl.Size = new System.Drawing.Size(125, 20);
            this.musAdiLbl.TabIndex = 10;
            this.musAdiLbl.Text = "Müşteri Adı :";
            this.musAdiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.musAdiTxtbox);
            this.Controls.Add(this.musAdiLbl);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.musSoyadiTxtbox);
            this.Controls.Add(this.musSoyadiLbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Musteriler";
            this.Size = new System.Drawing.Size(1171, 736);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button listeleBtn;
        private TextBox musSoyadiTxtbox;
        private Label musSoyadiLbl;
        private TextBox musAdiTxtbox;
        private Label musAdiLbl;
    }
}
