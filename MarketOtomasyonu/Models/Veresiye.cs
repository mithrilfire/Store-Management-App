using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    public class Veresiye
    {
        // Birincil Anahtar
        public int VeresiyeId { get; set; }

        public float KalanBorc { get; set; }

        // Yabanci Anahtarlar
        public int SatisId { get; set; }
        public int MusteriId { get; set; }

        // Veritabanindan Gizli
        //public float ToplamOdeme => VeresiyeOdemes.Sum(vo=>vo.Tutar);

        // Navigasyon Nesneleri
        public virtual Satis Satis { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual List<VeresiyeOdeme> VeresiyeOdemes { get; private set;}
    }
}
