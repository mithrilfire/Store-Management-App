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

namespace MarketOtomasyonu.UserControls
{
    public partial class Personel : UserControl
    {
        int personelId;

        public Personel(int personelId)
        {
            InitializeComponent();
            this.personelId = personelId;
            GetFromDB();
        }

        void GetFromDB()
        {
            using (var db = new MarketDBContext())
            {
                var personeller = db.personeller.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = personeller;
                personelDat.DataSource = src;

                for (int i = 0; i < personelDat.Columns.Count; i++)
                {
                    if (i < 2)
                    {
                        personelDat.Columns[i].FillWeight = 100;
                    }
                    else
                    {
                        personelDat.Columns[i].FillWeight = 150;
                    }
                }
            }
        }

        private void personelDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int id = (int)personelDat[0, e.RowIndex].Value;

            idLbl.Text = id.ToString();
            using (var db = new MarketDBContext())
            {
                Models.Personel per = db.personeller.
                    Where(p => p.PersonelId == id).
                    First();

                adTxt.Text = per.Adi;
                soyadTxt.Text = per.Soyadi;
                kullaniciAdiTxt.Text = per.KullaniciAdi;
                sifreTxt.Text = per.Sifre;
                yoneticiChk.Checked = per.Yonetici;
            }
        }

        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(idLbl.Text, out id))
            {
                uyariLbl.Text = "Personeli düzenlemek için geçerli bir Id girilmelidir.";
                uyariLbl.Visible = true;
                return;
            }

            if (id == personelId)
            {
                uyariLbl.Text = "Aktif kullanılan personel düzenlenemez.";
                uyariLbl.Visible = true;
                /*MessageBox.Show("Aktif kullanılan personel düzenlenemez.", "Hata!", 
                 * MessageBoxButtons.OK, MessageBoxIcon.Error);
                 */
                return;
            }

            using (var db = new MarketDBContext())
            {
                var personeller = db.personeller.Where(p => p.PersonelId == id);

                if (personeller.Any())
                {
                    Models.Personel personel = personeller.First();

                    personel.Adi = adTxt.Text;
                    personel.Soyadi = soyadTxt.Text;
                    personel.KullaniciAdi = kullaniciAdiTxt.Text;
                    personel.Sifre = sifreTxt.Text;
                    personel.Yonetici = yoneticiChk.Checked;

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

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                Models.Personel personel = new Models.Personel();

                personel.Adi = adTxt.Text;
                personel.Soyadi = soyadTxt.Text;
                personel.KullaniciAdi = kullaniciAdiTxt.Text;
                personel.Sifre = sifreTxt.Text.Trim();
                personel.Yonetici = yoneticiChk.Checked;

                db.personeller.Add(personel);
                db.SaveChanges();
            }

            GetFromDB();
            ClearInputs();
        }

        private void ClearInputs()
        {
            idLbl.Text = string.Empty;
            adTxt.Clear();
            soyadTxt.Clear();
            kullaniciAdiTxt.Clear();
            sifreTxt.Clear();
            yoneticiChk.Checked = false;
        }

        private void kaldirBtn_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(idLbl.Text, out id))
            {
                uyariLbl.Text = "Personeli kaldırmak için geçerli bir Id girilmelidir.";
                uyariLbl.Visible = true;
                return;
            }

            if (personelId == id)
            {
                uyariLbl.Text = "Aktif kullanılan personel kaldırılamaz.";
                uyariLbl.Visible = true;
                return;
            }

            using (var db = new MarketDBContext())
            {
                var personeller = db.personeller.Where(p => p.PersonelId == id);

                if (personeller.Any())
                {
                    db.personeller.Remove(personeller.First());
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
            ClearInputs();
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
