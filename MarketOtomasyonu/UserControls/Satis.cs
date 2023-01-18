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
using System.Collections.Generic;

namespace MarketOtomasyonu.UserControls
{
    public partial class Satis : UserControl
    {

        List<Fis> fis;
        int musId;
        float toplamtutar = 0;
        int tempbarkod;
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
                dataGridView1.DataSource = fis.Select(Fis => new { Fis.barkod, Fis.urunAdi, Fis.urunAdeti, Fis.tutar}).ToList();
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
                dataGridView2.Columns["Veresiye"].Visible = false;
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
                Models.Urun urun;
                if (int.TryParse(barkodTxtBox.Text, out ad))
                {
                    fis.barkod = ad;

                    urun = db.urunler.
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
                var stoklar = db.stoklar.Where(s => s.Urun.Barkod == fis.barkod && s.Adet > 0);
                if (!stoklar.Any())
                {
                    MessageBox.Show("Stoklarda ürün bulunmamaktadır!", "Hata!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (stoklar.Sum(s => s.Adet) < fis.urunAdeti)
                {
                    MessageBox.Show("Stoklarda yeterli ürün bulunmamaktadır!", "Hata!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                fis.tutar = fis.urunAdeti * urun.BirimFiyati;
                toplamtutar += fis.tutar;
                tBorcViewLbl.Text = toplamtutar.ToString();
                
                this.fis.Add(fis);

            }

            GetFromDB();
            ClearInputs();

        }

        private void urunleriCikar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                fis.RemoveAt(item.Index);
                GetFromDB();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (veresiyeChckBox.Checked)
            {
                veresiyePanel.Enabled = true;
                MusteriGetFromDB();
            }
            else
            {
                veresiyePanel.Enabled = false;
                ClearInputs();
                dataGridView3.Rows.Clear();
                dataGridView3.Columns.Clear();
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
            using (var db = new MarketDBContext())
            {
                Models.Satis satis;
                List<Models.Satis> satislar = new List<Models.Satis>();

                List<string> azalan = new List<string>();
                foreach (var item in fis)
                {
                    satis = new Models.Satis();
                    var stoklar = db.stoklar.Where(s => s.Urun.Barkod == item.barkod && s.Adet > 0);

                    satis.Barkod = item.barkod;
                    satis.Adet = item.urunAdeti;
                    satis.Tarih = tarihSaat;
                    satis.Tutar = item.urunAdeti * db.urunler.First(u => u.Barkod == item.barkod).BirimFiyati;

                    int toplamAdet = item.urunAdeti;
                    foreach (var stok in stoklar)
                    {
                        if (stok.Adet > toplamAdet)
                        {
                            stok.Adet -= toplamAdet;
                            break;
                        }
                        else
                        {
                            toplamAdet -= stok.Adet;
                            stok.Adet = 0;
                        }
                    }
                    if (stoklar.Sum(s=> s.Adet) < 11)
                    {
                        azalan.Add(item.urunAdi);
                    }
                    db.satislar.Add(satis);
                    db.SaveChanges();

                    satislar.Add(satis);
                }


                if (veresiyeChckBox.Checked)
                {
                    Models.Veresiye veresiye;

                    foreach (var item in fis)
                    {
                        veresiye = new Models.Veresiye();
                        satis = satislar.First(s => s.Barkod == item.barkod);

                        veresiye.SatisId = satis.SatisId;
                        veresiye.KalanBorc = satis.Tutar;
                        veresiye.MusteriId = musId;

                        db.veresiyeler.Add(veresiye);
                        db.SaveChanges();
                        satis.VeresiyeId = veresiye.VeresiyeId;
                        db.SaveChanges();
                    
                    }
                }
                string azalanurunler = "";
                foreach (var azalanurun in azalan)
                {
                    azalanurunler += azalanurun + ", ";
                }
                if (azalan.Count() > 0) 
                {
                    MessageBox.Show($"{azalanurunler} stokları azalıyor!", "Uyarı!",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
                
            }
            
       fis.Clear();
            GetFromDB();
            ClearInputs();
            SatisGetFromDB();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            musId = (int)dataGridView3[0, e.RowIndex].Value;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
        }
    }

    public class Fis : UserControl
    {

        public int barkod { get; set; }
        public int urunAdeti { get; set; }
        public string urunAdi { get; set; }
        public float tutar { get; set; }
    }
}
