using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    public class TedarikciOdeme
    {
        // Birincil Anahtar
        public int TedarikciOdemeId { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public float Tutar { get; set; }

        // Yabanci Anahtar
        public int TedarikciBorcId { get; set; }

        // Navigasyon Nesnesi
        public virtual TedarikciBorc TedarikciBorc { get; set; }
    }
}
