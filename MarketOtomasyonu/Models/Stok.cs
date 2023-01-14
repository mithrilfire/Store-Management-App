using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    public class Stok
    {
        // Birlesik Anahtar
        public int UrunId { get; set; }
        public int IrsaliyeId { get; set; }

        public float GirdiBirimFiyati { get; set; }
        public int Adet { get; set; }
        
        // Yabanci Anahtar
        public int TedarikciId { get; set; }

        // Navigasyon Nesnesi
        public virtual Tedarikci Tedarikci { get; set; }
    }
}
