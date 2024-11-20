﻿// <auto-generated />
using System;
using EksamensProjektScooterLandBlazor.Server.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241120102214_scooterbrandtomekanikerfixing")]
    partial class scooterbrandtomekanikerfixing
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Kunde", b =>
                {
                    b.Property<int>("KundeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KundeID"));

                    b.Property<string>("Efternavn")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fornavn")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("HusNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placering")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostNummer")
                        .HasColumnType("int");

                    b.Property<string>("PreferetMekanikerCprNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ScooterBrandID")
                        .HasColumnType("int");

                    b.Property<string>("TelefonNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VejNavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KundeID");

                    b.HasIndex("PostNummer");

                    b.HasIndex("PreferetMekanikerCprNummer");

                    b.ToTable("Kunder");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Medarbejder", b =>
                {
                    b.Property<string>("CprNummer")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adgangskode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Efternavn")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Fornavn")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Rolle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CprNummer");

                    b.ToTable("Medarbejdere");

                    b.HasDiscriminator().HasValue("Medarbejder");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Ordre", b =>
                {
                    b.Property<int>("OrdreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdreID"));

                    b.Property<double?>("BetalingsSum")
                        .HasColumnType("float");

                    b.Property<int?>("KundeiD")
                        .HasColumnType("int");

                    b.Property<int?>("MedarbejderCpr")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalgsDato")
                        .HasColumnType("datetime2");

                    b.Property<double?>("SamletPris")
                        .HasColumnType("float");

                    b.Property<string>("medarbejderCprNummer")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrdreID");

                    b.HasIndex("KundeiD");

                    b.HasIndex("medarbejderCprNummer");

                    b.ToTable("Ordrer");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.OrdreLinje", b =>
                {
                    b.Property<int>("OrdreLinjeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdreLinjeID"));

                    b.Property<int>("Antal")
                        .HasColumnType("int");

                    b.Property<int>("OrdreID")
                        .HasColumnType("int");

                    b.Property<int?>("ProduktID")
                        .HasColumnType("int");

                    b.Property<int?>("RabatProcent")
                        .HasColumnType("int");

                    b.Property<int?>("ScooterLejeID")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int?>("YdelseID")
                        .HasColumnType("int");

                    b.HasKey("OrdreLinjeID");

                    b.HasIndex("OrdreID");

                    b.HasIndex("ProduktID");

                    b.HasIndex("ScooterLejeID");

                    b.HasIndex("YdelseID");

                    b.ToTable("OrdreLinjer");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.PostNummerOgBy", b =>
                {
                    b.Property<int>("Postnummer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Postnummer"));

                    b.Property<string>("ByNavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Postnummer");

                    b.ToTable("PostNummerOgByer");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Produkt", b =>
                {
                    b.Property<int>("ProduktID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProduktID"));

                    b.Property<string>("ProduktNavn")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("ProduktPris")
                        .HasColumnType("float");

                    b.HasKey("ProduktID");

                    b.ToTable("Produkter");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.ScooterBrand", b =>
                {
                    b.Property<int>("ScooterBrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScooterBrandID"));

                    b.Property<string>("ScooterBrandNavn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScooterBrandID");

                    b.ToTable("ScooterBrands");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.ScooterLeje", b =>
                {
                    b.Property<int>("ScooterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScooterID"));

                    b.Property<int?>("AntalDage")
                        .HasColumnType("int");

                    b.Property<double>("DagsLejePris")
                        .HasColumnType("float");

                    b.Property<double>("ForsikringPrKm")
                        .HasColumnType("float");

                    b.Property<int?>("KmTalDifference")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool?>("Ledig")
                        .HasColumnType("bit");

                    b.Property<double?>("Pris")
                        .HasColumnType("float");

                    b.Property<double>("SelvRisiko")
                        .HasColumnType("float");

                    b.HasKey("ScooterID");

                    b.ToTable("ScooterLejer");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Ydelse", b =>
                {
                    b.Property<int>("YdelseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YdelseID"));

                    b.Property<double>("EstimeretTid")
                        .HasColumnType("float");

                    b.Property<double>("Pris")
                        .HasColumnType("float");

                    b.Property<string>("YdelseNavn")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("YdelseID");

                    b.ToTable("Ydelser");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Mekaniker", b =>
                {
                    b.HasBaseType("EksamensProjektScooterLandBlazor.Shared.Models.Medarbejder");

                    b.Property<int>("ScooterBrandId")
                        .HasColumnType("int");

                    b.HasIndex("ScooterBrandId");

                    b.HasDiscriminator().HasValue("Mekaniker");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Kunde", b =>
                {
                    b.HasOne("EksamensProjektScooterLandBlazor.Shared.Models.PostNummerOgBy", "PostNummerOgBy")
                        .WithMany()
                        .HasForeignKey("PostNummer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EksamensProjektScooterLandBlazor.Shared.Models.Mekaniker", "Mekaniker")
                        .WithMany()
                        .HasForeignKey("PreferetMekanikerCprNummer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mekaniker");

                    b.Navigation("PostNummerOgBy");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Ordre", b =>
                {
                    b.HasOne("EksamensProjektScooterLandBlazor.Shared.Models.Kunde", "kunde")
                        .WithMany()
                        .HasForeignKey("KundeiD");

                    b.HasOne("EksamensProjektScooterLandBlazor.Shared.Models.Medarbejder", "medarbejder")
                        .WithMany()
                        .HasForeignKey("medarbejderCprNummer");

                    b.Navigation("kunde");

                    b.Navigation("medarbejder");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.OrdreLinje", b =>
                {
                    b.HasOne("EksamensProjektScooterLandBlazor.Shared.Models.Ordre", "ordre")
                        .WithMany("ordreLinjer")
                        .HasForeignKey("OrdreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EksamensProjektScooterLandBlazor.Shared.Models.Produkt", "produkt")
                        .WithMany()
                        .HasForeignKey("ProduktID");

                    b.HasOne("EksamensProjektScooterLandBlazor.Shared.Models.ScooterLeje", "scooterLeje")
                        .WithMany()
                        .HasForeignKey("ScooterLejeID");

                    b.HasOne("EksamensProjektScooterLandBlazor.Shared.Models.Ydelse", "ydelse")
                        .WithMany()
                        .HasForeignKey("YdelseID");

                    b.Navigation("ordre");

                    b.Navigation("produkt");

                    b.Navigation("scooterLeje");

                    b.Navigation("ydelse");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Mekaniker", b =>
                {
                    b.HasOne("EksamensProjektScooterLandBlazor.Shared.Models.ScooterBrand", "scooterBrand")
                        .WithMany()
                        .HasForeignKey("ScooterBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("scooterBrand");
                });

            modelBuilder.Entity("EksamensProjektScooterLandBlazor.Shared.Models.Ordre", b =>
                {
                    b.Navigation("ordreLinjer");
                });
#pragma warning restore 612, 618
        }
    }
}
