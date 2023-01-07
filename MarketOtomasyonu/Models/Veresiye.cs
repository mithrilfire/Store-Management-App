using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    internal class Veresiye
    {
        public int VeresiyeId { get; set; }
        public float KalanBorc { get; set; }

        public int MusteriId { get; set; }
        public Musteri Musteri { get; set; }

        public int SatisId { get; set; }
        public Satis Satis { get; set; }
    }
}
