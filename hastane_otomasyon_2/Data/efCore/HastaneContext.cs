using hastane_otomasyon_2.Entity;
using Microsoft.EntityFrameworkCore;



namespace hastane_otomasyon_2.Data.efCore
{
    public class HastaneContext : DbContext
    {

        public DbSet<Doktor> Doktors => Set<Doktor>();
        
    }
}

