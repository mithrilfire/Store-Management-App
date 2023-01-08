using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    internal class Stok
    {
        // Birlesik Anahtar
        public int UrunId { get; set; }
        public int IrsaliyeId { get; set; }

        public float GirdiBirimFiyati { get; set; }
        public int Adet { get; set; }
        
        // Yabanci Anahtar
        public int TedarikciId { get; set; }

        // Navigasyon Nesnesi
        public Tedarikci Tedarikci { get; set; }
    }
}
