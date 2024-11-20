using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class ReftoMekanikerInKunde : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MekanikerCprNummer",
                table: "Kunder",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostNummerOgByPostnummer",
                table: "Kunder",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kunder_MekanikerCprNummer",
                table: "Kunder",
                column: "MekanikerCprNummer");

            migrationBuilder.CreateIndex(
                name: "IX_Kunder_PostNummerOgByPostnummer",
                table: "Kunder",
                column: "PostNummerOgByPostnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Medarbejdere_MekanikerCprNummer",
                table: "Kunder",
                column: "MekanikerCprNummer",
                principalTable: "Medarbejdere",
                principalColumn: "CprNummer");

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_PostNummerOgByer_PostNummerOgByPostnummer",
                table: "Kunder",
                column: "PostNummerOgByPostnummer",
                principalTable: "PostNummerOgByer",
                principalColumn: "Postnummer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Medarbejdere_MekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_PostNummerOgByer_PostNummerOgByPostnummer",
                table: "Kunder");

            migrationBuilder.DropIndex(
                name: "IX_Kunder_MekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.DropIndex(
                name: "IX_Kunder_PostNummerOgByPostnummer",
                table: "Kunder");

            migrationBuilder.DropColumn(
                name: "MekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.DropColumn(
                name: "PostNummerOgByPostnummer",
                table: "Kunder");
        }
    }
}
