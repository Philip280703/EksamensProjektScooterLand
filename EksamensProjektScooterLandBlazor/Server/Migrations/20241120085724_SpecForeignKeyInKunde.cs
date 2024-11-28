using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class SpecForeignKeyInKunde : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PreferetMekanikerCprNummer",
                table: "Kunder",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Kunder_PostNummer",
                table: "Kunder",
                column: "PostNummer");

            migrationBuilder.CreateIndex(
                name: "IX_Kunder_PreferetMekanikerCprNummer",
                table: "Kunder",
                column: "PreferetMekanikerCprNummer");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_PostNummerOgByer_PostNummer",
                table: "Kunder");

            migrationBuilder.DropIndex(
                name: "IX_Kunder_PostNummer",
                table: "Kunder");

            migrationBuilder.DropIndex(
                name: "IX_Kunder_PreferetMekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.AlterColumn<string>(
                name: "PreferetMekanikerCprNummer",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
