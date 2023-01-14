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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=MarketDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rubri\source\repos\MarketOtomasyonu\MarketOtomasyonu\Data\MarketDatabase.mdf;Integrated Security=True");
            //optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Database=MarketDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rubri\\source\\repos\\MarketOtomasyonu\\MarketOtomasyonu\\Data\\MarketDatabase.mdf;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Urun>().Property( u => u.UrunId ).ValueGeneratedNever();
            modelBuilder.Entity<Stok>().HasKey( s => new { s.UrunId, s.IrsaliyeId } );

            modelBuilder.Entity<Stok>().HasOne(s => s.Tedarikci)
                .WithMany(t => t.Stoks)
                .HasForeignKey(s => s.TedarikciId)
                .IsRequired();

            modelBuilder.Entity<Satis>().HasOne(s => s.Veresiye)
                .WithOne(v => v.Satis)
                .HasForeignKey<Satis>(s => s.VeresiyeId)
                .IsRequired(false);

            modelBuilder.Entity<TedarikciBorc>().HasOne(tb => tb.Tedarikci)
                .WithMany(t => t.tedarikciBorcs)
                .HasForeignKey(tb => tb.TedarikciId)
                .IsRequired();
        }
    }
}
