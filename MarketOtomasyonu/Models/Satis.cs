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
        [Key]
        public int SatisId { get; set; }
        [Required]
        public int Barkod { get; set; }
        [Required]
        public int Adet { get; set; }
        // todo tarihi sistemden cek
        public string Tarih { get; set; }
        [Required]
        public float Tutar { get; set; }

        [ForeignKey(nameof(Veresiye))]
        public int? VeresiyeId { get; set; }

        public virtual Veresiye Veresiye { get; set; }
    }
}
