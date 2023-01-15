using MarketOtomasyonu.Models;
using MarketOtomasyonu.UserControls;
using MarketOtomasyonu.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Forms
{
    public partial class AnasayfaForm : Form
    {
        bool mouseDown;
        Point lastLocation;
        int personelId;

        public int PersonelId { get => personelId; }

        public AnasayfaForm(int personelId)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            this.personelId = personelId;
            Models.Personel activePersonel;

            using (var db = new MarketDBContext())
            {
                activePersonel = db.personeller.Where(p => p.PersonelId == personelId).First();
            }
            
            icerikPnl.Controls.Clear();
            icerikPnl.Controls.Add(new Anasayfa());
            anasayfaBtn.BackColor = Color.FromArgb(0x3c, 0x42, 0x78);

            personelAdiLbl.Text = $"{activePersonel.Adi} {activePersonel.Soyadi}";

            personelBtn.Visible = activePersonel.Yonetici;
            tedarikciBtn.Visible = activePersonel.Yonetici;
            marketBorcBtn.Visible = activePersonel.Yonetici;
            raporBtn.Visible = activePersonel.Yonetici;
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void kapatbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kapatbutton_MouseEnter(object sender, EventArgs e)
        {
            kapatBtn.BackColor = Color.Red;
        }

        private void kapatbutton_MouseLeave(object sender, EventArgs e)
        {
            kapatBtn.BackColor = Color.FromArgb(0x16, 0x14, 0x2c);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }


        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void UpdatePageView(object sender)
        {
            var page = MenuUtil.GetPage(sender, personelId);
            icerikPnl.Controls.Clear();
            icerikPnl.Controls.Add(page);
        }

        /// <summary>
        /// Menu panelindeki buttonlarin gorunumu gunceller. Aktif panelin buttonu renk degistirir, diger buttonlar ayni kalir.
        /// </summary>
        /// <param name="sender">Eventi cagiran buttonun nesnesi.</param>
        private void UpdateMenuView(object sender)
        {
            var button = (Button)sender;

            foreach (var mbutton in menuPnl.Controls.OfType<Button>())
            {
                mbutton.BackColor = Color.FromArgb(0x25, 0x27, 0x38);
            }

            button.BackColor = Color.FromArgb(0x3c, 0x42, 0x78); //#9ca2db
        }

        /// <summary>
        /// Menu panelindeki buttonlarin event handleri bu eventi kullanir. 
        /// Menu panelindeki gorunumu gunceller ve icerik paneline acilmasi istenen sayfayi getirir.
        /// </summary>
        /// <param name="sender">Eventi cagiran buttonun nesnesi.</param>
        /// <param name="e">Event argumanlari.</param>
        private void menubutton_Click(object sender, EventArgs e)
        {
            UpdatePageView(sender);
            UpdateMenuView(sender);
        }
    }
}
