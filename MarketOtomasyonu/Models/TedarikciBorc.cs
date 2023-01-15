using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    public class TedarikciBorc
    {
        // Birincil Anahtar
        public int TedarikciBorcId { get; set; }

        public int IrsaliyeNo { get; set; }
        public float BorcTutari { get; set; }
        public DateTime Tarih { get; set; }

        // Yabanci Anahtar
        public int TedarikciId { get; set; }

        // Navigasyon Nesnesi
        public virtual Tedarikci Tedarikci { get; set; }
        public virtual List<TedarikciOdeme> TedarikciOdemes { get; set; }
    }
}
