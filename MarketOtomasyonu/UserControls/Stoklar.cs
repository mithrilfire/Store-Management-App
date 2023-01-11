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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MarketOtomasyonu.UserControls
{
    public partial class Stoklar : UserControl

    {
        public Stoklar()
        {
            InitializeComponent();
            GetFromDB();

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
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] items = line.Split('\t');
                            int myInteger = int.Parse(items[1]);   // Here's your integer.

                            // Now let's find the path.
                            string path = null;
                            foreach (string item in items)
                            {
                                if (item.StartsWith("item\\") && item.EndsWith(".ddj"))
                                    path = item;
                            }

                            // At this point, `myInteger` and `path` contain the values we want
                            // for the current line. We can then store those values or print them,
                            // or anything else we like.
                        }
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            stoklarTxtBox.Clear();
            GetFromDB();
        }
    }
}
