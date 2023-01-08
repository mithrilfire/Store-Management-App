using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    internal class TedarikciBorc
    {
        // Birincil Anahtar
        public int TedarikciBorcId { get; set; }
        public int IrsaliyeNo { get; set; }
        public float BorcTutari { get; set; }

        // Yabanci Anahtar
        public int TedarikciId { get; set; }

        // Navigasyon Nesnesi
        public Tedarikci Tedarikci { get; set; }
        public List<TedarikciOdeme> TedarikciOdemes { get; set; }
    }
}
