namespace MarketOtomasyonu.UserControls.Reports
{
    partial class musteriBorcRapor
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
            this.musteriBorcBaslikPnl = new System.Windows.Forms.Panel();
            this.musteriBorcBaslikLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriBorcBaslikPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // musteriBorcBaslikPnl
            // 
            this.musteriBorcBaslikPnl.Controls.Add(this.musteriBorcBaslikLbl);
            this.musteriBorcBaslikPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.musteriBorcBaslikPnl.Location = new System.Drawing.Point(8, 8);
            this.musteriBorcBaslikPnl.Name = "musteriBorcBaslikPnl";
            this.musteriBorcBaslikPnl.Size = new System.Drawing.Size(1120, 60);
            this.musteriBorcBaslikPnl.TabIndex = 2;
            // 
            // musteriBorcBaslikLbl
            // 
            this.musteriBorcBaslikLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musteriBorcBaslikLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musteriBorcBaslikLbl.Location = new System.Drawing.Point(0, 0);
            this.musteriBorcBaslikLbl.Name = "musteriBorcBaslikLbl";
            this.musteriBorcBaslikLbl.Size = new System.Drawing.Size(1120, 60);
            this.musteriBorcBaslikLbl.TabIndex = 0;
            this.musteriBorcBaslikLbl.Text = "Genel Müşteri Borç Raporu";
            this.musteriBorcBaslikLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 68);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(1120, 618);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 586);
            this.dataGridView1.TabIndex = 0;
            // 
            // musteriBorcRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.musteriBorcBaslikPnl);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "musteriBorcRapor";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(1136, 694);
            this.musteriBorcBaslikPnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel musteriBorcBaslikPnl;
        private Label musteriBorcBaslikLbl;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}
