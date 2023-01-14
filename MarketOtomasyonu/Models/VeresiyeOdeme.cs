using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    public class VeresiyeOdeme
    {
        // Birincil Anahtar
        public int VeresiyeOdemeId { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public float Tutar { get; set; }
        
        // Yabanci Anahtar
        public int VeresiyeId { get; set; }

        // Navigasyon Nesnesi
        public virtual Veresiye Veresiye { get; set; }
    }
}
