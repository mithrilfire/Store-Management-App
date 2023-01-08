using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    internal class Veresiye
    {
        // Birincil Anahtar
        public int VeresiyeId { get; set; }
        public float KalanBorc { get; set; }

        // Yabanci Anahtarlar
        public int SatisId { get; set; }
        public int MusteriId { get; set; }
        
        // Navigasyon Nesneleri
        public Satis Satis { get; set; }
        public Musteri Musteri { get; set; }
        public List<VeresiyeOdeme> VeresiyeOdemes { get; private set;}
    }
}
