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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarketOtomasyonu.UserControls
{
    public partial class MarketBorclar : UserControl
    {
        public MarketBorclar()
        {
            InitializeComponent();
            GetFromDBOdeme();
            GetFromDBBorc();
        }
        int tedId;
        void GetFromDBOdeme()
        {
            using (var db = new MarketDBContext())
            {
                var tedarikciOdeme = db.tedarikciOdemeler.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = tedarikciOdeme;
                tedarikOdemeDataGrid.DataSource = src;
                tedarikOdemeDataGrid.Columns["TedarikciBorc"].Visible = false;
                
            }
        }
        void GetFromDBBorc()
        {
            using (var db = new MarketDBContext())
            {
                var tedarikciBorc = db.tedarikciBorclar.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = tedarikciBorc;
                tedarikBorcDataGrid.DataSource = src;
                tedarikBorcDataGrid.Columns["Tedarikci"].Visible = false;
            }
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                if (tedarikAdiTxtbox.Text != "")
                {
                    var tedarikciad = db.tedarikciOdemeler.Where(m => m.TedarikciBorc.Tedarikci.Adi == tedarikAdiTxtbox.Text);
                    tedarikOdemeDataGrid.DataSource = tedarikciad.ToList();

                    var tedarikciadi = db.tedarikciBorclar.Where(m => m.Tedarikci.Adi == tedarikAdiTxtbox.Text);
                    tedarikBorcDataGrid.DataSource = tedarikciadi.ToList();
                }
                else
                {
                    GetFromDBBorc();
                    GetFromDBOdeme();
                }
            }
        }

        private void tedarikBorcDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)tedarikBorcDataGrid[0, e.RowIndex].Value;

            using (var db = new MarketDBContext())
            {
                Models.TedarikciBorc tedarikciBorc = db.tedarikciBorclar.Where(m => m.TedarikciBorcId == id).First();
                tedarikciBilgiLbl.Text = tedarikciBorc.Tedarikci.Adi;
                irsaliyeNoBilgiLbl.Text = tedarikciBorc.IrsaliyeNo.ToString();
                kalanBorcBilgiLbl.Text = tedarikciBorc.BorcTutari.ToString();
                tedId = tedarikciBorc.TedarikciBorcId;
            }
        }

        private void odemeBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                var tedarikciborclar = db.tedarikciBorclar.Where(b => b.TedarikciBorcId == tedId);

                float miktar = (float)Convert.ToDouble(miktarTxtbox.Text);
                if (tedarikciborclar.Any())
                {
                    Models.TedarikciBorc tedarikciBorc = tedarikciborclar.First();
                    Models.TedarikciOdeme tedarikciOdeme = new Models.TedarikciOdeme();

                    tedarikciBorc.BorcTutari -= miktar;
                    
                    DateTime tarihSaat = DateTime.Now;
                    tedarikciOdeme.Tutar = miktar;
                    tedarikciOdeme.TedarikciBorcId = tedarikciBorc.TedarikciBorcId;
                    tedarikciOdeme.OdemeTarihi = tarihSaat;
                    db.tedarikciOdemeler.Add(tedarikciOdeme);

                }
                

                db.SaveChanges();
                GetFromDBBorc();
                GetFromDBOdeme();
            }
        }

    }
}
