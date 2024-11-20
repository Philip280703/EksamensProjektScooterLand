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
            optionsBuilder.UseSqlServer("Server=ucl2024.database.windows.net; Database=ScooterLandDB; User Id=Camacho; Password=sologsommer2022+");
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


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Kunde>()
				   .HasOne(k => k.ScooterBrand)           // A Kunde has one ScooterBrand
				   .WithMany(sb => sb.KundeListe)             // A ScooterBrand has many Kunder
				   .HasForeignKey(k => k.ScooterBrandID)  // The foreign key is ScooterBrandID in Kunde
				   .OnDelete(DeleteBehavior.Restrict);    // Prevent cascade delete

			// Configure Kunde - Mekaniker relationship
			modelBuilder.Entity<Kunde>()
				.HasOne(k => k.Mekaniker)
				.WithMany() // If Mekaniker doesn't have a navigation property for Kunde
				.HasForeignKey(k => k.PreferetMekanikerCprNummer)
				.OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

			// Configure Kunde - PostNummerOgBy relationship
			modelBuilder.Entity<Kunde>()
				.HasOne(k => k.PostNummerOgBy)
				.WithMany() // If PostNummerOgBy doesn't have a navigation property for Kunde
				.HasForeignKey(k => k.PostNummer)
				.OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete
		}


	}
}
