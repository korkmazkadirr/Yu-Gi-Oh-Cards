using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yu_Gi_Oh_Cards.Models;
using System.Text;


namespace Yu_Gi_Oh_Cards.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Foto> Foto { get; set; }
        public DbSet<Kampanya> Kampanya { get; set; }

        public DbSet<Kategori> Kategori { get; set; }

        public DbSet<Sepet> Sepet { get; set; }

        public DbSet<Siparis> Siparis { get; set; }

        public DbSet<SiparisDetay> SiparisDetay { get; set; }

        public DbSet<Urun> Urun { get; set; }

        public DbSet<IndirimliUrunler> IndirimliUrunler { get; set; }

    }
}
