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

namespace MarketOtomasyonu.UserControls
{
    public partial class Stoklar : UserControl
    {
        private int tedId;
        public Stoklar()
        {
            InitializeComponent();
            GetFromDB();
            TedarikciGetFromDB();

        }

        void GetFromDB()
        {
            using (var db = new MarketDBContext())
            {
                var stoklar = db.stoklar.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = stoklar;
                dataGridView1.DataSource = src;
            }
        }

        void TedarikciGetFromDB()
        {
            using (var db = new MarketDBContext())
            {
                var tedarikci = db.tedarikciler.ToList();
                BindingSource src = new BindingSource();
                src.DataSource = tedarikci;
                tedarikciDataGrid.DataSource = src;
                tedarikciDataGrid.Columns[0].Visible = false;
                tedarikciDataGrid.Columns[2].Visible = false;
            }
        }

        private void stokListeleBtn_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(stoklarTxtBox.Text, out id))
            {
                uyariLbl.Text = "Ürünü aramak için geçerli bir Id girilmelidir!";
                uyariLbl.Visible = true;
                return;
            }

            using (var db = new MarketDBContext())
            {
                var stok = from st in db.stoklar
                            where st.UrunId == id
                            select st;
                dataGridView1.DataSource = stok.ToList();

            }
            

        }

        private void stokEkleBtn_Click(object sender, EventArgs e)
        {
            using (var db = new MarketDBContext())
            {
                if (!db.tedarikciler.Any(t => t.TedarikciId == tedId))
                {
                    return;
                }
            }

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string? filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        float toplamBorc = 0;
                        int irsaliyeNo = 0;
                        string? line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] items = line.Split(',');

                            Models.Urun? yeniurun = UrunOlustur(items);

                            if (yeniurun != null) 
                            {
                                urunEkle(yeniurun);
                            }

                            Models.Stok? yenistok = StokOlustur(items);

                            if (yenistok != null)
                            {
                                StokEkle(yenistok);
                                toplamBorc += yenistok.Adet * yenistok.GirdiBirimFiyati;
                                irsaliyeNo = yenistok.IrsaliyeId;

                            }
                        }
                        Models.TedarikciBorc yeniborc = new Models.TedarikciBorc();
                        yeniborc.BorcTutari = toplamBorc;
                        yeniborc.TedarikciId = tedId;
                        yeniborc.IrsaliyeNo = irsaliyeNo;

                        using (var db = new MarketDBContext())
                        {
                            db.tedarikciBorclar.Add(yeniborc);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }

        private  Models.Urun? UrunOlustur(string[] items)
        {
            Models.Urun yeniurun = new Models.Urun();

            int urunKodu;
            if (!int.TryParse(items[1], out urunKodu))
                return null;
            yeniurun.UrunId = urunKodu;

            int barkod;
            if (!int.TryParse(items[2], out barkod))
                return null;
            yeniurun.Barkod = barkod;

            yeniurun.Adi = items[3];


            float bFiyat;
            if (!float.TryParse(items[5], CultureInfo.InvariantCulture.NumberFormat, out bFiyat))
                return null;
            yeniurun.BirimFiyati = bFiyat;

            return yeniurun;
        }

        private Models.Stok? StokOlustur(string[] items)
        {
            Models.Stok yenistok = new Models.Stok();


            int irsaliye;
            if (!int.TryParse(items[0], out irsaliye))
                return null;
            yenistok.IrsaliyeId = irsaliye;

            int urunKodu;
            if (!int.TryParse(items[1], out urunKodu))
                return null;
            yenistok.UrunId = urunKodu;

            int adet;
            if (!int.TryParse(items[6], out adet))
                return null;
            yenistok.Adet = adet;

            float bGFiyat;
            if (!float.TryParse(items[4], CultureInfo.InvariantCulture.NumberFormat, out bGFiyat))
                return null;
            yenistok.GirdiBirimFiyati = bGFiyat;

            yenistok.TedarikciId = tedId;

            return yenistok;
        }
        
        private void StokEkle(Stok yenistok)
        {
            using (var db = new MarketDBContext())
            {

                db.stoklar.Add(yenistok);

                db.SaveChanges();
            }
        }

        private void urunEkle(Urun yeniurun)
        {
            using (var db = new MarketDBContext())
            {
                if (db.urunler.Any(u => u.UrunId == yeniurun.UrunId))
                {
                    Models.Urun varolanurun = db.urunler.
                        Where(u => u.UrunId == yeniurun.UrunId).
                        First();
                    varolanurun.BirimFiyati = yeniurun.BirimFiyati;
                }
                else
                {
                    db.urunler.Add(yeniurun);
                }
                db.SaveChanges();
            }
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            stoklarTxtBox.Clear();
            GetFromDB();
        }

        private void tedarikciDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tedId = (int)tedarikciDataGrid[0, e.RowIndex].Value;
                 
        }

    }
}
