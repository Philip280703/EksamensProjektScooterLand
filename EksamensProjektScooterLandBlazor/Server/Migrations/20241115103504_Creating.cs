using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class Creating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostNummerOgByer",
                columns: table => new
                {
                    Postnummer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ByNavn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostNummerOgByer", x => x.Postnummer);
                });

            migrationBuilder.CreateTable(
                name: "Produkter",
                columns: table => new
                {
                    ProduktID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktNavn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProduktPris = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkter", x => x.ProduktID);
                });

            migrationBuilder.CreateTable(
                name: "ScooterBrands",
                columns: table => new
                {
                    ScooterBrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScooterBrandNavn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScooterBrands", x => x.ScooterBrandID);
                });

            migrationBuilder.CreateTable(
                name: "ScooterLejer",
                columns: table => new
                {
                    ScooterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KmTalDifference = table.Column<int>(type: "int", nullable: false),
                    Ledig = table.Column<bool>(type: "bit", nullable: false),
                    SelvRisiko = table.Column<double>(type: "float", nullable: false),
                    ForsikringPrKm = table.Column<double>(type: "float", nullable: false),
                    AntalDage = table.Column<int>(type: "int", nullable: false),
                    DagsLejePris = table.Column<double>(type: "float", nullable: false),
                    Pris = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScooterLejer", x => x.ScooterID);
                });

            migrationBuilder.CreateTable(
                name: "Ydelser",
                columns: table => new
                {
                    YdelseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YdelseNavn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EstimeretTid = table.Column<double>(type: "float", nullable: false),
                    Pris = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ydelser", x => x.YdelseID);
                });

            migrationBuilder.CreateTable(
                name: "Kunder",
                columns: table => new
                {
                    KundeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fornavn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Efternavn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ScooterBrandID = table.Column<int>(type: "int", nullable: false),
                    TelefonNummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostNummer = table.Column<int>(type: "int", nullable: false),
                    VejNavn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HusNummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Placering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferetMekanikerCprNummer = table.Column<int>(type: "int", nullable: false),
                    postNummerOgByPostnummer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunder", x => x.KundeID);
                    table.ForeignKey(
                        name: "FK_Kunder_PostNummerOgByer_postNummerOgByPostnummer",
                        column: x => x.postNummerOgByPostnummer,
                        principalTable: "PostNummerOgByer",
                        principalColumn: "Postnummer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medarbejdere",
                columns: table => new
                {
                    CprNummer = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Adgangskode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rolle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fornavn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Efternavn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    ScooterBrandIDEkspertise = table.Column<int>(type: "int", nullable: true),
                    ScooterBrandID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medarbejdere", x => x.CprNummer);
                    table.ForeignKey(
                        name: "FK_Medarbejdere_ScooterBrands_ScooterBrandID",
                        column: x => x.ScooterBrandID,
                        principalTable: "ScooterBrands",
                        principalColumn: "ScooterBrandID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ordrer",
                columns: table => new
                {
                    OrdreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalgsDato = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SamletPris = table.Column<double>(type: "float", nullable: false),
                    BetalingsSum = table.Column<double>(type: "float", nullable: false),
                    KundeiD = table.Column<int>(type: "int", nullable: false),
                    MedarbejderCpr = table.Column<int>(type: "int", nullable: false),
                    medarbejderCprNummer = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordrer", x => x.OrdreID);
                    table.ForeignKey(
                        name: "FK_Ordrer_Kunder_KundeiD",
                        column: x => x.KundeiD,
                        principalTable: "Kunder",
                        principalColumn: "KundeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ordrer_Medarbejdere_medarbejderCprNummer",
                        column: x => x.medarbejderCprNummer,
                        principalTable: "Medarbejdere",
                        principalColumn: "CprNummer");
                });

            migrationBuilder.CreateTable(
                name: "OrdreLinjer",
                columns: table => new
                {
                    OrdreLinjeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Antal = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    RabatProcent = table.Column<int>(type: "int", nullable: false),
                    YdelseID = table.Column<int>(type: "int", nullable: false),
                    ProduktID = table.Column<int>(type: "int", nullable: false),
                    ScooterLejeID = table.Column<int>(type: "int", nullable: false),
                    OrdreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdreLinjer", x => x.OrdreLinjeID);
                    table.ForeignKey(
                        name: "FK_OrdreLinjer_Ordrer_OrdreID",
                        column: x => x.OrdreID,
                        principalTable: "Ordrer",
                        principalColumn: "OrdreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdreLinjer_Produkter_ProduktID",
                        column: x => x.ProduktID,
                        principalTable: "Produkter",
                        principalColumn: "ProduktID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdreLinjer_ScooterLejer_ScooterLejeID",
                        column: x => x.ScooterLejeID,
                        principalTable: "ScooterLejer",
                        principalColumn: "ScooterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdreLinjer_Ydelser_YdelseID",
                        column: x => x.YdelseID,
                        principalTable: "Ydelser",
                        principalColumn: "YdelseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kunder_postNummerOgByPostnummer",
                table: "Kunder",
                column: "postNummerOgByPostnummer");

            migrationBuilder.CreateIndex(
                name: "IX_Medarbejdere_ScooterBrandID",
                table: "Medarbejdere",
                column: "ScooterBrandID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdreLinjer_OrdreID",
                table: "OrdreLinjer",
                column: "OrdreID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdreLinjer_ProduktID",
                table: "OrdreLinjer",
                column: "ProduktID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdreLinjer_ScooterLejeID",
                table: "OrdreLinjer",
                column: "ScooterLejeID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdreLinjer_YdelseID",
                table: "OrdreLinjer",
                column: "YdelseID");

            migrationBuilder.CreateIndex(
                name: "IX_Ordrer_KundeiD",
                table: "Ordrer",
                column: "KundeiD");

            migrationBuilder.CreateIndex(
                name: "IX_Ordrer_medarbejderCprNummer",
                table: "Ordrer",
                column: "medarbejderCprNummer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdreLinjer");

            migrationBuilder.DropTable(
                name: "Ordrer");

            migrationBuilder.DropTable(
                name: "Produkter");

            migrationBuilder.DropTable(
                name: "ScooterLejer");

            migrationBuilder.DropTable(
                name: "Ydelser");

            migrationBuilder.DropTable(
                name: "Kunder");

            migrationBuilder.DropTable(
                name: "Medarbejdere");

            migrationBuilder.DropTable(
                name: "PostNummerOgByer");

            migrationBuilder.DropTable(
                name: "ScooterBrands");
        }
    }
}
