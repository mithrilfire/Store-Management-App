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
    public partial class Tedarikci : UserControl
    {
        public Tedarikci()
        {
            InitializeComponent();
            GetFromDB();
        }

        void GetFromDB()
        {
            using (var db = new MarketDBContext())
            {
                var tedarikci = db.tedarikciler.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = tedarikci;
                tedarikciDataGrid.DataSource = src;
            }
        }

        int tedid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)tedarikciDataGrid[0, e.RowIndex].Value;

            using (var db = new MarketDBContext())
            {
                Models.Tedarikci tedarikci = db.tedarikciler.
                    Where(t => t.TedarikciId == id).
                    First();
                tedarikciTxtbox.Text = tedarikci.Adi;
                tedarikçiAdresTxtbox.Text = tedarikci.Adres;
                tedid = tedarikci.TedarikciId;
            }
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                Models.Tedarikci tedarikci = new Models.Tedarikci();

                tedarikci.Adi = tedarikciTxtbox.Text;
                tedarikci.Adres = tedarikçiAdresTxtbox.Text;
                db.tedarikciler.Add(tedarikci);
                db.SaveChanges();
            }
            GetFromDB();
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                var tedarikci = db.tedarikciler.Where(t => t.Adi == araTxtbox.Text);
                tedarikciDataGrid.DataSource = tedarikci.ToList();
                if (araTxtbox.Text == "" )
                {
                    GetFromDB();
                }
                
            }
            

        }

        private void duzenleBtn_Click(object sender, EventArgs e)
        {

            using (var db = new MarketDBContext())
            {
                var tedarikciler = db.tedarikciler.Where(t => t.TedarikciId == tedid);

                if (tedarikciler.Any())
                {
                    Models.Tedarikci tedarikci = tedarikciler.First();

                    tedarikci.Adi = tedarikciTxtbox.Text;
                    tedarikci.Adres = tedarikçiAdresTxtbox.Text;
                }

                db.SaveChanges();
            }

            GetFromDB();
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            GetFromDB();
            araTxtbox.Clear();
            tedarikciTxtbox.Clear();
            tedarikçiAdresTxtbox.Clear();
        }
    }
}
