using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    public class Musteri
    {
        // Birincil Anahtar
        public int MusteriId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        // Veritabanindan Gizli
        /*public float ToplamSatis => Veresiyes.Select(v => v.Satis).Sum(s => s.Tutar);
        public float ToplamOdeme => Veresiyes.Select(v => v.ToplamOdeme).Sum();
        public float ToplamKalan => Veresiyes.Sum(v => v.KalanBorc);*/

        // Navigasyon Nesnesi
        public virtual List<Veresiye> Veresiyes { get; private set; }
    }
}
