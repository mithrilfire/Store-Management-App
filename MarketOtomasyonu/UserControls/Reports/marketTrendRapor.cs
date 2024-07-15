using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
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
    public partial class marketTrendRapor : UserControl
    {
        public marketTrendRapor()
        {
            InitializeComponent();
            GrafigiTanimla();

            using (var db = new MarketDBContext())
            {
                if (db.satislar.Count() != 0)
                {
                    var ilkTarih = db.satislar.OrderBy(s => s.Tarih).First().Tarih.AddDays(-1);
                    baslangicDtp.Value = ilkTarih;
                }
               
            }

            DateTime baslangic = baslangicDtp.Value;
            DateTime bitis = bitisDtp.Value;

            GrafigiGuncelle(baslangic, bitis);
        }


        private void gosterBtn_Click(object sender, EventArgs e)
        {
            DateTime baslangic = baslangicDtp.Value;
            DateTime bitis = bitisDtp.Value;

            GrafigiGuncelle(baslangic, bitis);
        }
        
        private void GrafigiGuncelle(DateTime baslangic, DateTime bitis)
        {
            using (var db = new MarketDBContext())
            {
                var tumSatislar = db.satislar
                    .Where(s => s.Tarih > baslangic && s.Tarih < bitis);

                var satislar = tumSatislar
                    .GroupBy(s => s.Tarih.DayOfYear)
                    .Select(s => new MarketTrend() { SatisSayisi = s.Count(), Gun = s.Key });
                

                trendCch.Series = new ISeries[]
                    {
                        new LineSeries<MarketTrend>
                        {
                            Name = "Satışlar",
                            Values = satislar.ToArray(),
                            Fill = null,

                            Mapping = (trend, point) =>
                            {
                                point.PrimaryValue = trend.SatisSayisi;
                                point.SecondaryValue = trend.Gun;
                            }
                        }
                    };

            }
        }

        private void GrafigiTanimla()
        {
            trendCch.XAxes = new Axis[]
            {
                    new Axis()
                    {
                        Name = "Günler",
                        MinStep = 1
                    }
            };

            trendCch.YAxes = new Axis[]
            {
                    new Axis()
                    {
                        Name = "Satış Sayısı",
                        MinStep = 1
                    }
            };
        }
    
    }

    internal class MarketTrend
    {
        public int SatisSayisi;
        public int Gun;
    }
}
