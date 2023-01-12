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
    public partial class Musteriler : UserControl
    {
        public Musteriler()
        {
            InitializeComponent();
            GetFromDB();
        }

        void GetFromDB()
        {
            using (var db = new MarketDBContext())
            {
                var musteri = db.musteriler.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = musteri;
                musteridatagrid.DataSource = src;
            }
        }
        int musid;
        private void musteridatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)musteridatagrid[0, e.RowIndex].Value;

            using (var db = new MarketDBContext())
            {
                Models.Musteri musteri = db.musteriler.Where(m => m.MusteriId == id).First();
                musAdiTxtbox.Text = musteri.Adi;
                musSoyadiTxtbox.Text = musteri.Soyadi;
                musid = musteri.MusteriId;
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                Models.Musteri musteri = new Models.Musteri();

                musteri.Adi = musAdiTxtbox.Text;
                musteri.Soyadi = musSoyadiTxtbox.Text;
                db.musteriler.Add(musteri);
                db.SaveChanges();
            }
            GetFromDB();
        }

        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                var musteriler = db.musteriler.Where(m => m.MusteriId == musid);

                if (musteriler.Any())
                {
                    Models.Musteri musteri = musteriler.First();

                    musteri.Adi = musAdiTxtbox.Text;
                    musteri.Soyadi = musSoyadiTxtbox.Text;
                }

                db.SaveChanges();
            }

            GetFromDB();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                if (musAdiTxtbox.Text != "" && musSoyadiTxtbox.Text != "")
                {
                    var musteriad = db.musteriler.Where(m => m.Adi == musAdiTxtbox.Text && m.Soyadi == musSoyadiTxtbox.Text);
                    musteridatagrid.DataSource = musteriad.ToList();
                }
                else if (musAdiTxtbox.Text != "" && musSoyadiTxtbox.Text == "")
                {
                    var musteriad = db.musteriler.Where(m => m.Adi == musAdiTxtbox.Text);
                    musteridatagrid.DataSource = musteriad.ToList();
                }
                else if (musAdiTxtbox.Text == "" && musSoyadiTxtbox.Text != "")
                {
                    var musterisoyad = db.musteriler.Where(m => m.Soyadi == musSoyadiTxtbox.Text);
                    musteridatagrid.DataSource = musterisoyad.ToList();
                }
                else
                {
                    GetFromDB();
                }
            }
        }

        private void kaldirBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                var musteriler = db.musteriler.Where(m => m.MusteriId == musid);

                if (musteriler.Any())
                {
                    db.musteriler.Remove(musteriler.First());
                }
                else
                {
                    uyariLbl.Text = "Bu Id ile eşleşen herhangi bir kullanıcı bulunamadı.";
                    uyariLbl.Visible = true;
                    return;
                }

                db.SaveChanges();
            }

            GetFromDB();
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            GetFromDB();
            musAdiTxtbox.Clear();
            musSoyadiTxtbox.Clear();
        }
    }
}
