namespace MarketOtomasyonu.Forms
{
    partial class AnasayfaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaForm));
            kapatBtn = new Button();
            menuPnl = new Panel();
            raporBtn = new Button();
            marketBorcBtn = new Button();
            musteriBtn = new Button();
            musteriBorcBtn = new Button();
            tedarikciBtn = new Button();
            personelBtn = new Button();
            satisBtn = new Button();
            stoklarBtn = new Button();
            urunlerBtn = new Button();
            anasayfaBtn = new Button();
            userPnl = new Panel();
            personelAdiLbl = new Label();
            pictureBox1 = new PictureBox();
            baslikPnl = new Panel();
            baslikLbl = new Label();
            icerikPnl = new Panel();
            menuPnl.SuspendLayout();
            userPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            baslikPnl.SuspendLayout();
            SuspendLayout();
            // 
            // kapatBtn
            // 
            kapatBtn.BackgroundImage = (Image)resources.GetObject("kapatBtn.BackgroundImage");
            kapatBtn.BackgroundImageLayout = ImageLayout.Center;
            kapatBtn.Dock = DockStyle.Right;
            kapatBtn.FlatAppearance.BorderSize = 0;
            kapatBtn.FlatStyle = FlatStyle.Flat;
            kapatBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            kapatBtn.ForeColor = Color.WhiteSmoke;
            kapatBtn.Location = new Point(1352, 0);
            kapatBtn.Margin = new Padding(0);
            kapatBtn.Name = "kapatBtn";
            kapatBtn.Size = new Size(48, 32);
            kapatBtn.TabIndex = 0;
            kapatBtn.UseVisualStyleBackColor = true;
            kapatBtn.Click += kapatbutton_Click;
            kapatBtn.MouseEnter += kapatbutton_MouseEnter;
            kapatBtn.MouseLeave += kapatbutton_MouseLeave;
            // 
            // menuPnl
            // 
            menuPnl.BackColor = Color.FromArgb(37, 39, 56);
            menuPnl.Controls.Add(raporBtn);
            menuPnl.Controls.Add(marketBorcBtn);
            menuPnl.Controls.Add(musteriBtn);
            menuPnl.Controls.Add(musteriBorcBtn);
            menuPnl.Controls.Add(tedarikciBtn);
            menuPnl.Controls.Add(personelBtn);
            menuPnl.Controls.Add(satisBtn);
            menuPnl.Controls.Add(stoklarBtn);
            menuPnl.Controls.Add(urunlerBtn);
            menuPnl.Controls.Add(anasayfaBtn);
            menuPnl.Controls.Add(userPnl);
            menuPnl.Dock = DockStyle.Left;
            menuPnl.Location = new Point(0, 32);
            menuPnl.Name = "menuPnl";
            menuPnl.Size = new Size(240, 768);
            menuPnl.TabIndex = 0;
            // 
            // raporBtn
            // 
            raporBtn.Dock = DockStyle.Top;
            raporBtn.FlatAppearance.BorderSize = 0;
            raporBtn.FlatStyle = FlatStyle.Flat;
            raporBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            raporBtn.ForeColor = Color.WhiteSmoke;
            raporBtn.Image = (Image)resources.GetObject("raporBtn.Image");
            raporBtn.ImageAlign = ContentAlignment.MiddleLeft;
            raporBtn.Location = new Point(0, 632);
            raporBtn.Name = "raporBtn";
            raporBtn.Padding = new Padding(16, 0, 0, 0);
            raporBtn.Size = new Size(240, 56);
            raporBtn.TabIndex = 9;
            raporBtn.Text = "Raporlar";
            raporBtn.TextAlign = ContentAlignment.MiddleLeft;
            raporBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            raporBtn.UseVisualStyleBackColor = true;
            raporBtn.Click += menubutton_Click;
            // 
            // marketBorcBtn
            // 
            marketBorcBtn.Dock = DockStyle.Top;
            marketBorcBtn.FlatAppearance.BorderSize = 0;
            marketBorcBtn.FlatStyle = FlatStyle.Flat;
            marketBorcBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            marketBorcBtn.ForeColor = Color.WhiteSmoke;
            marketBorcBtn.Image = (Image)resources.GetObject("marketBorcBtn.Image");
            marketBorcBtn.ImageAlign = ContentAlignment.MiddleLeft;
            marketBorcBtn.Location = new Point(0, 576);
            marketBorcBtn.Name = "marketBorcBtn";
            marketBorcBtn.Padding = new Padding(16, 0, 0, 0);
            marketBorcBtn.Size = new Size(240, 56);
            marketBorcBtn.TabIndex = 8;
            marketBorcBtn.Text = "Market Borçları";
            marketBorcBtn.TextAlign = ContentAlignment.MiddleLeft;
            marketBorcBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            marketBorcBtn.UseVisualStyleBackColor = true;
            marketBorcBtn.Click += menubutton_Click;
            // 
            // musteriBtn
            // 
            musteriBtn.Dock = DockStyle.Top;
            musteriBtn.FlatAppearance.BorderSize = 0;
            musteriBtn.FlatStyle = FlatStyle.Flat;
            musteriBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            musteriBtn.ForeColor = Color.WhiteSmoke;
            musteriBtn.Image = (Image)resources.GetObject("musteriBtn.Image");
            musteriBtn.ImageAlign = ContentAlignment.MiddleLeft;
            musteriBtn.Location = new Point(0, 520);
            musteriBtn.Name = "musteriBtn";
            musteriBtn.Padding = new Padding(16, 0, 0, 0);
            musteriBtn.Size = new Size(240, 56);
            musteriBtn.TabIndex = 7;
            musteriBtn.Text = "Müşteriler";
            musteriBtn.TextAlign = ContentAlignment.MiddleLeft;
            musteriBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            musteriBtn.UseVisualStyleBackColor = true;
            musteriBtn.Click += menubutton_Click;
            // 
            // musteriBorcBtn
            // 
            musteriBorcBtn.Dock = DockStyle.Top;
            musteriBorcBtn.FlatAppearance.BorderSize = 0;
            musteriBorcBtn.FlatStyle = FlatStyle.Flat;
            musteriBorcBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            musteriBorcBtn.ForeColor = Color.WhiteSmoke;
            musteriBorcBtn.Image = (Image)resources.GetObject("musteriBorcBtn.Image");
            musteriBorcBtn.ImageAlign = ContentAlignment.MiddleLeft;
            musteriBorcBtn.Location = new Point(0, 464);
            musteriBorcBtn.Name = "musteriBorcBtn";
            musteriBorcBtn.Padding = new Padding(16, 0, 0, 0);
            musteriBorcBtn.Size = new Size(240, 56);
            musteriBorcBtn.TabIndex = 6;
            musteriBorcBtn.Text = "Müşteri Borçlar";
            musteriBorcBtn.TextAlign = ContentAlignment.MiddleLeft;
            musteriBorcBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            musteriBorcBtn.UseVisualStyleBackColor = true;
            musteriBorcBtn.Click += menubutton_Click;
            // 
            // tedarikciBtn
            // 
            tedarikciBtn.Dock = DockStyle.Top;
            tedarikciBtn.FlatAppearance.BorderSize = 0;
            tedarikciBtn.FlatStyle = FlatStyle.Flat;
            tedarikciBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tedarikciBtn.ForeColor = Color.WhiteSmoke;
            tedarikciBtn.Image = (Image)resources.GetObject("tedarikciBtn.Image");
            tedarikciBtn.ImageAlign = ContentAlignment.MiddleLeft;
            tedarikciBtn.Location = new Point(0, 408);
            tedarikciBtn.Name = "tedarikciBtn";
            tedarikciBtn.Padding = new Padding(16, 0, 0, 0);
            tedarikciBtn.Size = new Size(240, 56);
            tedarikciBtn.TabIndex = 5;
            tedarikciBtn.Text = "Tedarikçi";
            tedarikciBtn.TextAlign = ContentAlignment.MiddleLeft;
            tedarikciBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            tedarikciBtn.UseVisualStyleBackColor = true;
            tedarikciBtn.Click += menubutton_Click;
            // 
            // personelBtn
            // 
            personelBtn.Dock = DockStyle.Top;
            personelBtn.FlatAppearance.BorderSize = 0;
            personelBtn.FlatStyle = FlatStyle.Flat;
            personelBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            personelBtn.ForeColor = Color.WhiteSmoke;
            personelBtn.Image = (Image)resources.GetObject("personelBtn.Image");
            personelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            personelBtn.Location = new Point(0, 352);
            personelBtn.Name = "personelBtn";
            personelBtn.Padding = new Padding(16, 0, 0, 0);
            personelBtn.Size = new Size(240, 56);
            personelBtn.TabIndex = 4;
            personelBtn.Text = "Personel";
            personelBtn.TextAlign = ContentAlignment.MiddleLeft;
            personelBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            personelBtn.UseVisualStyleBackColor = true;
            personelBtn.Click += menubutton_Click;
            // 
            // satisBtn
            // 
            satisBtn.Dock = DockStyle.Top;
            satisBtn.FlatAppearance.BorderSize = 0;
            satisBtn.FlatStyle = FlatStyle.Flat;
            satisBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            satisBtn.ForeColor = Color.WhiteSmoke;
            satisBtn.Image = (Image)resources.GetObject("satisBtn.Image");
            satisBtn.ImageAlign = ContentAlignment.MiddleLeft;
            satisBtn.Location = new Point(0, 296);
            satisBtn.Name = "satisBtn";
            satisBtn.Padding = new Padding(16, 0, 0, 0);
            satisBtn.Size = new Size(240, 56);
            satisBtn.TabIndex = 3;
            satisBtn.Text = "Satış";
            satisBtn.TextAlign = ContentAlignment.MiddleLeft;
            satisBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            satisBtn.UseVisualStyleBackColor = true;
            satisBtn.Click += menubutton_Click;
            // 
            // stoklarBtn
            // 
            stoklarBtn.Dock = DockStyle.Top;
            stoklarBtn.FlatAppearance.BorderSize = 0;
            stoklarBtn.FlatStyle = FlatStyle.Flat;
            stoklarBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            stoklarBtn.ForeColor = Color.WhiteSmoke;
            stoklarBtn.Image = (Image)resources.GetObject("stoklarBtn.Image");
            stoklarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            stoklarBtn.Location = new Point(0, 240);
            stoklarBtn.Name = "stoklarBtn";
            stoklarBtn.Padding = new Padding(16, 0, 0, 0);
            stoklarBtn.Size = new Size(240, 56);
            stoklarBtn.TabIndex = 2;
            stoklarBtn.Text = "Stoklar";
            stoklarBtn.TextAlign = ContentAlignment.MiddleLeft;
            stoklarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            stoklarBtn.UseVisualStyleBackColor = true;
            stoklarBtn.Click += menubutton_Click;
            // 
            // urunlerBtn
            // 
            urunlerBtn.Dock = DockStyle.Top;
            urunlerBtn.FlatAppearance.BorderSize = 0;
            urunlerBtn.FlatStyle = FlatStyle.Flat;
            urunlerBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            urunlerBtn.ForeColor = Color.WhiteSmoke;
            urunlerBtn.Image = (Image)resources.GetObject("urunlerBtn.Image");
            urunlerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            urunlerBtn.Location = new Point(0, 184);
            urunlerBtn.Name = "urunlerBtn";
            urunlerBtn.Padding = new Padding(16, 0, 0, 0);
            urunlerBtn.Size = new Size(240, 56);
            urunlerBtn.TabIndex = 1;
            urunlerBtn.Text = "Ürünler";
            urunlerBtn.TextAlign = ContentAlignment.MiddleLeft;
            urunlerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            urunlerBtn.UseVisualStyleBackColor = true;
            urunlerBtn.Click += menubutton_Click;
            // 
            // anasayfaBtn
            // 
            anasayfaBtn.Dock = DockStyle.Top;
            anasayfaBtn.FlatAppearance.BorderSize = 0;
            anasayfaBtn.FlatStyle = FlatStyle.Flat;
            anasayfaBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            anasayfaBtn.ForeColor = Color.WhiteSmoke;
            anasayfaBtn.Image = (Image)resources.GetObject("anasayfaBtn.Image");
            anasayfaBtn.ImageAlign = ContentAlignment.MiddleLeft;
            anasayfaBtn.Location = new Point(0, 128);
            anasayfaBtn.Name = "anasayfaBtn";
            anasayfaBtn.Padding = new Padding(16, 0, 0, 0);
            anasayfaBtn.Size = new Size(240, 56);
            anasayfaBtn.TabIndex = 10;
            anasayfaBtn.Text = "Anasayfa";
            anasayfaBtn.TextAlign = ContentAlignment.MiddleLeft;
            anasayfaBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            anasayfaBtn.UseVisualStyleBackColor = true;
            anasayfaBtn.Click += menubutton_Click;
            // 
            // userPnl
            // 
            userPnl.Controls.Add(personelAdiLbl);
            userPnl.Controls.Add(pictureBox1);
            userPnl.Dock = DockStyle.Top;
            userPnl.Location = new Point(0, 0);
            userPnl.Name = "userPnl";
            userPnl.Padding = new Padding(0, 16, 0, 0);
            userPnl.Size = new Size(240, 128);
            userPnl.TabIndex = 11;
            // 
            // personelAdiLbl
            // 
            personelAdiLbl.Dock = DockStyle.Top;
            personelAdiLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            personelAdiLbl.ForeColor = Color.WhiteSmoke;
            personelAdiLbl.Location = new Point(0, 80);
            personelAdiLbl.Name = "personelAdiLbl";
            personelAdiLbl.Size = new Size(240, 32);
            personelAdiLbl.TabIndex = 1;
            personelAdiLbl.Text = "Alperen Tellioğlu";
            personelAdiLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 64);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // baslikPnl
            // 
            baslikPnl.BackColor = Color.FromArgb(22, 20, 44);
            baslikPnl.Controls.Add(kapatBtn);
            baslikPnl.Controls.Add(baslikLbl);
            baslikPnl.Dock = DockStyle.Top;
            baslikPnl.Location = new Point(0, 0);
            baslikPnl.Name = "baslikPnl";
            baslikPnl.Size = new Size(1400, 32);
            baslikPnl.TabIndex = 0;
            // 
            // baslikLbl
            // 
            baslikLbl.Dock = DockStyle.Fill;
            baslikLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baslikLbl.ForeColor = Color.WhiteSmoke;
            baslikLbl.Location = new Point(0, 0);
            baslikLbl.Name = "baslikLbl";
            baslikLbl.Size = new Size(1400, 32);
            baslikLbl.TabIndex = 1;
            baslikLbl.Text = "Market Otomasyonu";
            baslikLbl.TextAlign = ContentAlignment.MiddleCenter;
            baslikLbl.MouseDown += label1_MouseDown;
            baslikLbl.MouseMove += label1_MouseMove;
            baslikLbl.MouseUp += label1_MouseUp;
            // 
            // icerikPnl
            // 
            icerikPnl.Dock = DockStyle.Fill;
            icerikPnl.Location = new Point(240, 32);
            icerikPnl.Name = "icerikPnl";
            icerikPnl.Size = new Size(1160, 768);
            icerikPnl.TabIndex = 1;
            // 
            // AnasayfaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 800);
            Controls.Add(icerikPnl);
            Controls.Add(menuPnl);
            Controls.Add(baslikPnl);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AnasayfaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnasayfaForm";
            menuPnl.ResumeLayout(false);
            userPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            baslikPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button kapatBtn;
        private Panel menuPnl;
        private Panel baslikPnl;
        private Button urunlerBtn;
        private Button musteriBorcBtn;
        private Button tedarikciBtn;
        private Button personelBtn;
        private Button satisBtn;
        private Button stoklarBtn;
        private Button raporBtn;
        private Button marketBorcBtn;
        private Button musteriBtn;
        private Panel icerikPnl;
        private Label baslikLbl;
        private Button anasayfaBtn;
        private Panel userPnl;
        private Label personelAdiLbl;
        private PictureBox pictureBox1;
    }
}