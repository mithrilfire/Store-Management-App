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
    public partial class Urunler : UserControl
    {
        public Urunler()
        {
            InitializeComponent();
            GetFromDB();
        }

        void GetFromDB()
        {
            using (var db = new MarketDBContext())
            {
                var urunler = db.urunler.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = urunler;
                dataGridView1.DataSource = src;
            }
        }

        private void urunListeleBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                var urun = db.urunler.Where(u => u.Adi == urunlerTxtBox.Text);
                dataGridView1.DataSource = urun.ToList();
                if (urunlerTxtBox.Text == "")
                {
                    GetFromDB();
                }

            }
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            urunlerTxtBox.Clear();
            GetFromDB();
        }
    }
}
