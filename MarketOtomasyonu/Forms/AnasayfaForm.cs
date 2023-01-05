using MarketOtomasyonu.UserControls;
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

        enum Sayfalar
        {
            Anasayfa,
            Urunler,
            Stoklar,
            Satis,
            Musteriler,
            MusteriBorclar,
            Personel,
            Tedarikci,
            MarketBorclari,
            Raporlar
        }

        public AnasayfaForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            icerikpanel.Controls.Clear();
            icerikpanel.Controls.Add(new Anasayfa());
            label1.Text = "Anasayfa";
        }

        private void kapatbutton_MouseEnter(object sender, EventArgs e)
        {
            kapatbutton.BackColor = Color.Red;
        }

        private void kapatbutton_MouseLeave(object sender, EventArgs e)
        {
            kapatbutton.BackColor = Color.FromArgb(53, 102, 144);
        }

        private void baslikpanel_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void baslikpanel_MouseUp(object sender, MouseEventArgs e)
        {

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

        private void urunlerbutton_Click(object sender, EventArgs e)
        {
            var urunler = new Urunler();
            UpdateView(urunler);
        }

        private void UpdateView(UserControl page)
        {
            icerikpanel.Controls.Clear();
            icerikpanel.Controls.Add(page);

            label1.Text = "PageName";
        }

        private void marketbbutton_Click(object sender, EventArgs e)
        {
            var borclar = new MarketBorclar();
            UpdateView(borclar);
        }
    }
}
