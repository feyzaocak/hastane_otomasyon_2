using Microsoft.EntityFrameworkCore;
using hastane_otomasyon_2.Data.Entity;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace hastane_otomasyon_2.Data.efCore
{
    public class HastaneContext : DbContext
    {
        public HastaneContext(DbContextOptions<HastaneContext>options): base (options)
        {

        }
        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
        public DbSet<Alan> Alans { get; set; }


       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source: hastane.db");
        }*/
    }
}

