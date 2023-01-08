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
        public Personel()
        {
            InitializeComponent();

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
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)personelDat[0, e.RowIndex].Value;

            idTxt.Text = id.ToString();
            using (var db = new MarketDBContext())
            {
                Models.Personel per = db.personeller.
                    Where(p => p.PersonelId == id).
                    First();

                adTxt.Text = per.Adi;
                soyadTxt.Text = per.Soyadi;
                kullaniciAdiTxt.Text = per.KullaniciAdi;
                sifreTxt.Text = per.Sifre;
            }
        }
    }
}
