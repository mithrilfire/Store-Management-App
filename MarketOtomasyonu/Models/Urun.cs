using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    public class Urun
    {
        // Birincil Anahtar
        public int UrunId { get; set; }
        public string Adi { get; set; }
        public int Barkod { get; set; }
        public float BirimFiyati { get; set; }
    }
}
