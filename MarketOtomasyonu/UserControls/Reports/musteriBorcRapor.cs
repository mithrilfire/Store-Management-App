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

namespace MarketOtomasyonu.UserControls.Reports
{
    public partial class musteriBorcRapor : UserControl
    {
        public musteriBorcRapor()
        {
            InitializeComponent();

            using (var db = new MarketDBContext())
            {
                var borclar = db.musteriler.Select(m => new
                {
                    m.Adi,
                    m.Soyadi,
                    ToplamSatis=m.Veresiyes.Select(v => v.Satis).Sum(s => s.Tutar),
                    //ToplamOdeme=m.Veresiyes.Select(v => v.VeresiyeOdemes).Sum(vo=>vo.Sum(voo=>voo.Tutar)),
                    ToplamKalan=m.Veresiyes.Sum(v => v.KalanBorc)
                });

                dataGridView1.DataSource = borclar.ToList();
            }
        }
    }
}
