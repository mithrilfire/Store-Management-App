using MarketOtomasyonu.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class GirisForm : Form
    {
        bool mouseDown;
        Point lastLocation;

        public GirisForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            using (var db = new MarketDBContext())
            {
                // If there is no database, create a new one and update it using migrations.
                db.Database.Migrate();

                if (db.personeller.Count() == 0)
                {
                    db.personeller.Add(new Personel() { Adi="Admin", Soyadi="1", KullaniciAdi="admin", Sifre="admin", Yonetici=true});
                    db.SaveChanges();
                }
            }

            girisBtn.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                bool sonuc = db.personeller.
                    Any(p => p.KullaniciAdi.Equals(textBox1.Text) && p.Sifre.Equals(textBox2.Text));

                if (sonuc)
                {
                    int personelId = db.personeller.
                        Where(p => p.KullaniciAdi.Equals(textBox1.Text) && p.Sifre.Equals(textBox2.Text)).
                        First().PersonelId;
                    var form = new AnasayfaForm(personelId);
                    form.Show();
                    form.Activate();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            cikisBtn.BackColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            cikisBtn.BackColor = Color.Transparent;
        }
    }
}
