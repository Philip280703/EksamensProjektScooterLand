using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EksamensProjektScooterLandBlazor.Client.Pages;
using EksamensProjektScooterLandBlazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace EksamensProjektScooterLandBlazor.Server.DataAccess
{
    public class MyDbContext : DbContext
    {
        // connectionString til den relationelle database EF skal gemme i.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" -- DatabaseServerNavnHer -- ;TrustServerCertificate=true;Trusted_Connection=True");
        }

        // EF komponenter
        public DbSet<Kunde> Kunder { get; set; }
        public DbSet<Medarbejder> Medarbejdere { get; set; }
        public DbSet<Mekaniker> Mekanikere { get; set; }
        public DbSet<Ordre> Ordrer { get; set; }
        public DbSet<OrdreLinje> OrdreLinjer { get; set; }
        public DbSet<PostNummerOgBy> PostNummerOgByer { get; set; }
        public DbSet<Produkt> Produkter { get; set; }
        public DbSet<ScooterBrand> ScooterBrands { get; set; }
        public DbSet<ScooterLeje> ScooterLejer { get; set; }
        public DbSet<Ydelse> Ydelser { get; set; }


    }
}
