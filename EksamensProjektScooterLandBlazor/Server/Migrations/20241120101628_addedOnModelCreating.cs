using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedOnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_PostNummerOgByer_PostNummer",
                table: "Kunder");

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder",
                column: "PreferetMekanikerCprNummer",
                principalTable: "Medarbejdere",
                principalColumn: "CprNummer");

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_PostNummerOgByer_PostNummer",
                table: "Kunder",
                column: "PostNummer",
                principalTable: "PostNummerOgByer",
                principalColumn: "Postnummer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_PostNummerOgByer_PostNummer",
                table: "Kunder");

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder",
                column: "PreferetMekanikerCprNummer",
                principalTable: "Medarbejdere",
                principalColumn: "CprNummer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_PostNummerOgByer_PostNummer",
                table: "Kunder",
                column: "PostNummer",
                principalTable: "PostNummerOgByer",
                principalColumn: "Postnummer",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
