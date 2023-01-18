using MarketOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketOtomasyonu.UserControls.Reports
{
    public partial class urunDurumRapor : UserControl
    {
        public urunDurumRapor()
        {
            InitializeComponent();
            urunDurumLbx_Ciz();
        }

        private void urunDurumLbx_Ciz()
        {
            using (var db = new MarketDBContext())
            {
                var urunler = db.urunler.Select(u => $"{u.UrunId}: {u.Adi}");

                urunDurumLbx.DataSource = urunler.ToList();
            }

            label2.Visible = false;
        }

        private void urunDurumLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (urunDurumLbx.SelectedValue == null)
                return;

            var musteriBilgileri = urunDurumLbx.SelectedValue.ToString().Split(":");
            int id;

            if (!int.TryParse(musteriBilgileri[0], out id))
            {
                return;
            }

            using (var db = new MarketDBContext())
            {
                var urun = db.urunler.Where(u => u.UrunId == id).First();

                urunDurumAdiLbl.Text = urun.Adi;
                urunDurumStokLbl.Text = urun.Stoks.Sum(u => u.Adet).ToString();

                int barkod = urun.Barkod;

                var satislar = db.satislar.Where(s => s.Barkod == barkod).GroupBy(s => s.Tarih.Month);
                

            }
        }

        private void urunDurumBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                if (urunDurumTxt.Text == string.Empty)
                {
                    urunDurumLbx_Ciz();
                    return;
                }

                var urunler = db.urunler.Where(u => u.Adi == urunDurumTxt.Text)
                    .Select(u => $"{u.UrunId}: {u.Adi}");

                label2.Text = urunDurumTxt.Text;
                label2.Visible = true;

                urunDurumLbx.DataSource = urunler.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunDurumLbx_Ciz();
            urunDurumTxt.Clear();
        }
    }
}
