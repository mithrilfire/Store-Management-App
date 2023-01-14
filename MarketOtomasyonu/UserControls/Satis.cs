using MarketOtomasyonu.Forms;
using MarketOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketOtomasyonu.UserControls
{
    public partial class Satis : UserControl
    {

        List<Fis> fis;
        int musId;
        public Satis()
        {
            InitializeComponent();
            fis = new List<Fis>();
            GetFromDB();
            SatisGetFromDB();

        }
        void GetFromDB()
        {
                var list = new BindingList<Fis>(fis);
                var source = new BindingSource(list, null);
                dataGridView1.DataSource = fis.Select(Fis => new { Fis.barkod, Fis.urunAdi, Fis.urunAdeti }).ToList();
        }

        void MusteriGetFromDB()
        {
            using (var db = new MarketDBContext())
            {
                var musteriler = db.musteriler.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = musteriler;
                dataGridView3.DataSource = src;
            }
        }

        void SatisGetFromDB()
        {
            using (var db = new MarketDBContext())
            {
                var satislar = db.satislar.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = satislar;
                dataGridView2.DataSource = src;
            }
        }

        private void ClearInputs()
        {
            barkodTxtBox.Text = string.Empty;
            urunAdetiTxtBox.Text = string.Empty;
            musAdiTxtBox.Text = string.Empty;
            musSoyAdiTxtBox.Text = string.Empty;
        }

        private void urunleriEkle_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                Fis fis = new Fis();

                int ad;

                if (int.TryParse(barkodTxtBox.Text, out ad))
                {
                    fis.barkod = ad;

                    Models.Urun urun = db.urunler.
                    Where(u => u.Barkod == ad).
                    First();

                    fis.urunAdi = urun.Adi;
                }
                else
                {
                    return;
                }
                if (int.TryParse(urunAdetiTxtBox.Text, out ad))
                {
                    fis.urunAdeti = ad;
                }
                else
                {
                    return;
                }

                this.fis.Add(fis);
            }

            GetFromDB();
            ClearInputs();
        }

        private void urunleriCikar_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (veresiyeChckBox.Checked)
            {
                veresiyePanel.Enabled = true;
            }
            else
            {
                veresiyePanel.Enabled = false;
                ClearInputs();
            }
        }

        private void musEkleLbl_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                Models.Musteri musteri = new Models.Musteri();

                musteri.Adi = musAdiTxtBox.Text;
                musteri.Soyadi = musSoyAdiTxtBox.Text;
                db.musteriler.Add(musteri);
                db.SaveChanges();
            }
            MusteriGetFromDB();
        }

        private void musAraLbl_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                if (musAdiTxtBox.Text != "" && musSoyAdiTxtBox.Text != "")
                {
                    var musteriad = db.musteriler.Where(m => m.Adi == musAdiTxtBox.Text && m.Soyadi == musSoyAdiTxtBox.Text);
                    dataGridView3.DataSource = musteriad.ToList();
                }
                else if (musAdiTxtBox.Text != "" && musSoyAdiTxtBox.Text == "")
                {
                    var musteriad = db.musteriler.Where(m => m.Adi == musAdiTxtBox.Text);
                    dataGridView3.DataSource = musteriad.ToList();
                }
                else if (musAdiTxtBox.Text == "" && musSoyAdiTxtBox.Text != "")
                {
                    var musterisoyad = db.musteriler.Where(m => m.Soyadi == musSoyAdiTxtBox.Text);
                    dataGridView3.DataSource = musterisoyad.ToList();
                }
                else
                {

                    GetFromDB();
                }
            }
        }

        private void satBtn_Click(object sender, EventArgs e)
        {
            DateTime tarihSaat = DateTime.Now;
            //Fis fis = new Fis();
            using (var db = new MarketDBContext())
            {
                Models.Satis satis = new Models.Satis();
                Models.Urun urun = new Models.Urun();
                Models.Stok stok = new Models.Stok();

                foreach (var item in fis)
                {
                    satis.Barkod = item.barkod;
                    satis.Adet = item.urunAdeti;
                    satis.Tarih = tarihSaat.ToString();
                    satis.Tutar = item.urunAdeti * db.urunler.First(u => u.Barkod == item.barkod).BirimFiyati;

                    db.satislar.Add(satis);
                    db.SaveChanges();
                
                    if (veresiyeChckBox.Checked)
                    {
                        Models.Veresiye veresiye = new Models.Veresiye();
                        
                        veresiye.SatisId = satis.SatisId;
                        veresiye.KalanBorc = satis.Tutar;
                        veresiye.MusteriId = musId;
                        
                        db.veresiyeler.Add(veresiye);
                        db.SaveChanges();
                        satis.VeresiyeId = veresiye.VeresiyeId;
                        db.SaveChanges();
                    }
                    
                }

                if (stok.Adet <= 10)
                {
                    MessageBox.Show("Stok Sayısı Azalıyor!", "Uyarı!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 
                }
            }

            GetFromDB();
            ClearInputs();
            SatisGetFromDB();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            musId = (int)dataGridView3[0, e.RowIndex].Value;
        }
    }

    public class Fis : UserControl
    {

        public int barkod { get; set; }
        public int urunAdeti { get; set; }
        public string urunAdi { get; set; }
    }
}
