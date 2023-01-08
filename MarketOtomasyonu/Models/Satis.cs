using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    internal class Satis
    {
        // Birincil Anahtar
        public int SatisId { get; set; }
        public int Barkod { get; set; }
        public int Adet { get; set; }
        public string Tarih { get; set; }
        public float Tutar { get; set; }
        
        // Yabanci Anahtar
        public int? VeresiyeId { get; set; }

        // Navigasyon Nesnesi
        public virtual Veresiye Veresiye { get; set; }
    }
}
