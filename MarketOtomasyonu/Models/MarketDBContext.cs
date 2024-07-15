using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
//using Microsoft.EntityFrameworkCore.Proxies;

namespace MarketOtomasyonu.Models
{
    public class MarketDBContext : DbContext
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

        public string DbPath { get; }

        public MarketDBContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "marketmanagement.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlite($"Data Source={DbPath}");
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

            modelBuilder.Entity<Stok>()
                .HasOne(s => s.Urun)
                .WithMany(u => u.Stoks);

            modelBuilder.Entity<Urun>()
                .HasMany(u => u.Stoks)
                .WithOne(s => s.Urun)
                .HasForeignKey( s => s.UrunId );

            /*modelBuilder.Entity<Musteri>().Ignore(m => m.ToplamOdeme);
            modelBuilder.Entity<Musteri>().Ignore(m => m.ToplamSatis);
            modelBuilder.Entity<Musteri>().Ignore(m => m.ToplamKalan);

            modelBuilder.Entity<Veresiye>().Ignore(v => v.ToplamOdeme);*/
            //modelBuilder.Entity<Veresiye>().Ignore(v => v.Tutar);
        }
    }
}
