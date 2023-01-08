using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    internal class Tedarikci
    {
        // Birincil Anahtar
        public int TedarikciId { get; set; }
        public string Adi { get; set;  }
        public string Adres { get; set; }

        // Navigasyon Nesnesi
        public virtual List<TedarikciBorc> tedarikciBorcs { get; set; }
        public virtual List<Stok> Stoks { get; set; }
    }
}
