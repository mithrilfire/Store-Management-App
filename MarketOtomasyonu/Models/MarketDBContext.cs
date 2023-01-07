using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Models
{
    internal class MarketDBContext : DbContext
    {
        public DbSet<Musteri> musteriler { get; set; }
        public DbSet<Personel> personeller { get; set; }
        public DbSet<Satis> satislar { get; set; }
        public DbSet<Stok> stoklar { get; set; }
        public DbSet<Tedarikci> tedarikciler { get; set; }
        public DbSet<TedarikciBorc> tedarikciBorclar { get; set; }
        public DbSet<TedarikciOdeme> tedarikciOdemeler { get; set; }
        public DbSet<Urun> urunler { get; set; }
        public DbSet<Veresiye> veresiyeler { get; set; }
        public DbSet<VeresiyeOdeme> veresiyeOdemeler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // todo connection ekle
        }
    }
}
