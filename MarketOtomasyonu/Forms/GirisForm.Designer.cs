namespace MarketOtomasyonu.Forms
{
    partial class GirisForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            girisBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cikisBtn = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // girisBtn
            // 
            girisBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            girisBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            girisBtn.Location = new Point(100, 300);
            girisBtn.Name = "girisBtn";
            girisBtn.Size = new Size(100, 32);
            girisBtn.TabIndex = 0;
            girisBtn.Text = "Giriş";
            girisBtn.UseVisualStyleBackColor = true;
            girisBtn.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "admin";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "admin";
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(43, 182);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(86, 222);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(68, 68);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 5;
            label3.Text = "Personel Girişi";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cikisBtn
            // 
            cikisBtn.Dock = DockStyle.Right;
            cikisBtn.FlatAppearance.BorderSize = 0;
            cikisBtn.FlatStyle = FlatStyle.Flat;
            cikisBtn.ForeColor = Color.WhiteSmoke;
            cikisBtn.Image = (Image)resources.GetObject("cikisBtn.Image");
            cikisBtn.Location = new Point(268, 0);
            cikisBtn.Margin = new Padding(0);
            cikisBtn.Name = "cikisBtn";
            cikisBtn.Size = new Size(32, 32);
            cikisBtn.TabIndex = 6;
            cikisBtn.UseVisualStyleBackColor = true;
            cikisBtn.Click += button2_Click;
            cikisBtn.MouseEnter += button2_MouseEnter;
            cikisBtn.MouseLeave += button2_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 20, 44);
            panel1.Controls.Add(cikisBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 32);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 39, 56);
            ClientSize = new Size(300, 400);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(girisBtn);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GirisForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button girisBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button cikisBtn;
        private Panel panel1;
    }
}