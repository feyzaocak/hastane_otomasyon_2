using Microsoft.EntityFrameworkCore;
using hastane_otomasyon_2.Data.Abstract;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;


public class HastaneContext : DbContext
{
    public DbSet<Doktor> Doktors { get; set; }
    public DbSet<Kullanici> Kullanicis { get; set; }
    public DbSet<Randevu> Randevus { get; set; }
    public DbSet<Alan> Alans { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source: hastane.db");
    }
}
