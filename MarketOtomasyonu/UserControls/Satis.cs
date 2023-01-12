using MarketOtomasyonu.Forms;
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

namespace MarketOtomasyonu.UserControls
{
    public partial class Satis : UserControl
    {

        List<Fis> fis;
        public Satis()
        {
            InitializeComponent();
            //GetFromDB();
            //toplamTutar();
            fis = new List<Fis>
            {
                new Fis() { urunAdi = "kek", urunAdeti = 5, barkod = 1234 }
            };
            dataGridView1.DataSource = fis.Select(Fis => new { Fis.barkod, Fis.urunAdi, Fis.urunAdeti }).ToList();

        }
        void GetFromDB()
        {
                var list = new BindingList<Fis>(fis);
                var source = new BindingSource(list, null);
                dataGridView1.DataSource = source;
        }
        private void ClearInputs()
        {
            barkodTxtBox.Text = string.Empty;
            urunAdetiTxtBox.Text = string.Empty;
            musAdiTxtBox.Text = string.Empty;
            musSoyAdiTxtBox.Text = string.Empty;
            dataGridView3.Rows.Clear();
            dataGridView3.Refresh();
        }

        private void urunleriEkle_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                Fis fis = new Fis();

                int ad;

                // Db den barkodları çekip kaşılaştırcaz. Ürün adını çekicez.
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
        private void toplamTutar()
        {
            /*using (var db = new MarketDBContext())
            {
                Models.Satis satis = new Models.Satis();

                int toplamTutar;
            

                db.satislar.Add(satis);
                db.SaveChanges();
            }*/
            
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
            GetFromDB();
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
    }

    public class Fis : UserControl
    {

        public int barkod { get; set; }
        public int urunAdeti { get; set; }
        public string urunAdi { get; set; }

        



    }
}
