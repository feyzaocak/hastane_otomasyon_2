using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace hastane_otomasyon_2.Data.efCore
{
    public class IdentityContext : IdentityDbContext<IdentityUser>
    {

        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }
    }
}

