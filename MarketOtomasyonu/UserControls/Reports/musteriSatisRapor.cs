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

namespace MarketOtomasyonu.UserControls.Reports
{
    public partial class musteriSatisRapor : UserControl
    {
        public musteriSatisRapor()
        {
            InitializeComponent();
            musteriSatisLbx_Ciz();

        }

        private void musteriSatisLbx_Ciz()
        {
            using (var db = new MarketDBContext())
            {
                var musteriler = db.musteriler.Select(m => $"{m.MusteriId}: {m.Adi} {m.Soyadi}");
                
                musteriSatisLbx.DataSource = musteriler.ToList();
            }

            label2.Visible = false;
        }

        private void musteriSatisLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (musteriSatisLbx.SelectedValue ==null)
                return;

            var musteriBilgileri = musteriSatisLbx.SelectedValue.ToString().Split(":");
            int id;
            
            if (!int.TryParse(musteriBilgileri[0], out id))
            {
                return;
            }

            using (var db = new MarketDBContext())
            {
                var musteri = db.musteriler.Where(m => m.MusteriId == id).First();

                musteriBorcAdiLbl.Text = musteri.Adi;
                musteriBorcBorcLbl.Text = musteri.Veresiyes.Sum(v => v.KalanBorc).ToString();

                var satislar = db.veresiyeler.Where(v => v.MusteriId == id)
                    .GroupBy(v => v.Satis.Barkod);

                var aa = satislar.Select(s => new { 
                    Adi=db.urunler.First(u=>u.Barkod==s.Key).Adi ,
                    SatisMiktari=s.Count(), 
                    ToplamTutar=s.Sum(a=>a.Satis.Tutar) });

                musteriBorcDat.DataSource = aa.Select(a=> new {a.Adi, a.SatisMiktari, a.ToplamTutar}).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                if (textBox1.Text == string.Empty)
                {
                    musteriSatisLbx_Ciz();
                    return;
                }


                var musteriler = db.musteriler.Where(m=>m.Adi == textBox1.Text || m.Soyadi == textBox1.Text)
                    .Select(m => $"{m.MusteriId}: {m.Adi} {m.Soyadi}");

                label2.Text = textBox1.Text;
                label2.Visible = true;

                musteriSatisLbx.DataSource = musteriler.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriSatisLbx_Ciz();
            textBox1.Clear();
        }
    }
}
