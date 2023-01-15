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

namespace MarketOtomasyonu.UserControls
{
    public partial class MusteriBorclar : UserControl
    {
        public MusteriBorclar()
        {
            InitializeComponent();
            GetFromDBOdeme();
            GetFromDBBorc();
        }
        int musid;
        int verid;
        void GetFromDBOdeme()
        {
            using (var db = new MarketDBContext())
            {
                var veresiyeodeme = db.veresiyeOdemeler.Select(v =>new { v.VeresiyeOdemeId,v.OdemeTarihi, v.Tutar, v.VeresiyeId, v.Veresiye.Musteri.Adi, v.Veresiye.Musteri.Soyadi }).ToList();
                BindingSource src = new BindingSource();
                src.DataSource = veresiyeodeme;
                musOdemeleriDatagrid.DataSource = src;
            }
        }
        void GetFromDBBorc()
        {
            using (var db = new MarketDBContext())
            {
                var veresiye = db.veresiyeler.Where(t => t.KalanBorc > 0).Select(v => new {v.VeresiyeId,v.KalanBorc,v.SatisId,v.MusteriId,v.Musteri.Adi,v.Musteri.Soyadi}).ToList();
                BindingSource src = new BindingSource();
                src.DataSource = veresiye;
                var adlar = db.musteriler.Select(a => a.Adi);
                musBorclariDatagrid.DataSource = src;
            }
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                if (musAdiTxtbox.Text != "" && musSoyadTxtbox.Text != "")
                {
                    var musteriad = db.veresiyeOdemeler.Where(v => v.Veresiye.Musteri.Adi == musAdiTxtbox.Text && v.Veresiye.Musteri.Soyadi == musSoyadTxtbox.Text);
                    musOdemeleriDatagrid.DataSource = musteriad.ToList();
                    var musteriadi = db.veresiyeler.Where(v => v.Musteri.Adi == musAdiTxtbox.Text && v.Musteri.Soyadi == musSoyadTxtbox.Text && v.KalanBorc > 0);
                    musBorclariDatagrid.DataSource = musteriadi.ToList();
                }
                else if (musAdiTxtbox.Text != "" && musSoyadTxtbox.Text == "")
                {
                    var musteriad = db.veresiyeOdemeler.Where(v => v.Veresiye.Musteri.Adi == musAdiTxtbox.Text);
                    musOdemeleriDatagrid.DataSource = musteriad.ToList();
                    var musteriadi = db.veresiyeler.Where(v => v.Musteri.Adi == musAdiTxtbox.Text && v.KalanBorc > 0);
                    musBorclariDatagrid.DataSource = musteriadi.ToList();
                }
                else if (musAdiTxtbox.Text == "" && musSoyadTxtbox.Text != "")
                {
                    var musteriad = db.veresiyeOdemeler.Where(v => v.Veresiye.Musteri.Soyadi == musSoyadTxtbox.Text);
                    musOdemeleriDatagrid.DataSource = musteriad.ToList();
                    var musteriadi = db.veresiyeler.Where(v => v.Musteri.Soyadi == musSoyadTxtbox.Text && v.KalanBorc > 0);
                    musBorclariDatagrid.DataSource = musteriadi.ToList();
                }
                else
                {
                    GetFromDBBorc();
                    GetFromDBOdeme();
                }
            }
        }

        private void musBorclariDatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = (int)musBorclariDatagrid[0, e.RowIndex].Value;

            using (var db = new MarketDBContext())
            {
                Models.Veresiye veresiye = db.veresiyeler.Where(m => m.VeresiyeId == id).First();
                musAdıBilgiLbl.Text = veresiye.Musteri.Adi;
                musSoyadBilgiLbl.Text = veresiye.Musteri.Soyadi;
                kalanBorcBilgiLbl.Text = veresiye.KalanBorc.ToString();
                musid = veresiye.Musteri.MusteriId;
                verid = veresiye.VeresiyeId;
            }
        }

        private void odemeBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                var veresiyeler = db.veresiyeler.Where(v => v.VeresiyeId == verid);
                float miktar = (float)Convert.ToDouble(miktarTxtbox.Text);

                if (veresiyeler.Any())
                {
                    Models.Veresiye veresiye = veresiyeler.First();
                    Models.VeresiyeOdeme veresiyeOdeme = new Models.VeresiyeOdeme();
                    
                    if (miktar <= 0 || miktar >= veresiye.KalanBorc)
                    {
                        MessageBox.Show("Hatalı bir değer girdiniz. Lütfen geçerli bir değer giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    veresiye.KalanBorc -= miktar;                    
                    DateTime tarihSaat = DateTime.Now;
                    veresiyeOdeme.Tutar = miktar;
                    veresiyeOdeme.VeresiyeId = veresiye.VeresiyeId;
                    veresiyeOdeme.OdemeTarihi = tarihSaat;
                    db.veresiyeOdemeler.Add(veresiyeOdeme);
                    musAdıBilgiLbl.Text = "";
                    musSoyadBilgiLbl.Text = "";
                    kalanBorcBilgiLbl.Text = "";
                    miktarTxtbox.Text = "";
                }

                db.SaveChanges();
                GetFromDBOdeme();
                GetFromDBBorc();
            }
        }
    }
}
