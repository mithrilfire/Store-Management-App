using MarketOtomasyonu.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class marketDurumRapor : UserControl
    {
        public marketDurumRapor()
        {
            InitializeComponent();
            DataGridGoster();
        }

        private void DataGridGoster()
        {
            List<MarketDurum> list = new List<MarketDurum>();

            using (var db = new MarketDBContext())
            {
                //aylik olarak borclari al
                //aylik olarak karlari al
                //aylik olarak net geliri hesapla

                /*var satislar = db.satislar.GroupBy(k => new { k.Tarih.Month, k.Tarih.Year });

                var borclar = db.tedarikciBorclar.GroupBy(tb => new { tb.Tarih.Month, tb.Tarih.Year });

                var gelirler = satislar.Select(s => new { Tutar=s.Sum(gs => gs.Tutar), Ay = s.Key.Month, Yil = s.Key.Year });
                var giderler = borclar.Select(b => new { Borc= b.Sum(gb => gb.BorcTutari + gb.TedarikciOdemes.Sum(to => to.Tutar)), Ay=b.Key.Month, Yil=b.Key.Year });

                var yoo = gelirler.Join(giderler, ge => new { ge.Ay, ge.Yil }, gi => new { gi.Ay, gi.Yil }, (satis, brc) => new { satis.Tutar, brc.Borc, satis.Ay, satis.Yil })
                    .Select(s => new MarketDurum(){
                        Ay = s.Ay,
                        Yil = s.Yil,
                        Gelir = s.Tutar,
                        Borc = s.Borc,
                        Kar = s.Tutar - s.Borc
                    });

                marketKarDat.DataSource = yoo.Select(l => new { l.Gelir, l.Borc, l.Kar }).ToList();*/
            }
        }
    }

    internal class MarketDurum
    {
        public float Gelir;
        public float Borc;
        public float Kar;

        public int Yil;
        public int Ay;
    }
}
