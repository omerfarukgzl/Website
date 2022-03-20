using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G191210068_Web_Muhasebe.Models.Data
{
    public class MuhasebeDbContext: IdentityDbContext<ApplicationUser>
    {
        public MuhasebeDbContext(DbContextOptions<MuhasebeDbContext> options)
     : base(options)
        {

        }
        public DbSet<Cari> Cari { get; set; } // Cari Tablosu olsutruma
        public DbSet<Urun> Urun { get; set; } // Urun Tablosu olsutruma
        public DbSet<CariIslemler> CariIslemler { get; set; } // Islem Tablosu olsutruma
        //public object ApplicationUser { get; internal set; }
    }
}
