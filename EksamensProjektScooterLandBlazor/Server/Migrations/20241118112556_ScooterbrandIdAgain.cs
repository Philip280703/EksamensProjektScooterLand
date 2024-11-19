using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class ScooterbrandIdAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medarbejdere_ScooterBrands_ScooterBrandID",
                table: "Medarbejdere");

            migrationBuilder.RenameColumn(
                name: "ScooterBrandID",
                table: "Medarbejdere",
                newName: "ScooterBrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Medarbejdere_ScooterBrandID",
                table: "Medarbejdere",
                newName: "IX_Medarbejdere_ScooterBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medarbejdere_ScooterBrands_ScooterBrandId",
                table: "Medarbejdere",
                column: "ScooterBrandId",
                principalTable: "ScooterBrands",
                principalColumn: "ScooterBrandID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medarbejdere_ScooterBrands_ScooterBrandId",
                table: "Medarbejdere");

            migrationBuilder.RenameColumn(
                name: "ScooterBrandId",
                table: "Medarbejdere",
                newName: "ScooterBrandID");

            migrationBuilder.RenameIndex(
                name: "IX_Medarbejdere_ScooterBrandId",
                table: "Medarbejdere",
                newName: "IX_Medarbejdere_ScooterBrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_Medarbejdere_ScooterBrands_ScooterBrandID",
                table: "Medarbejdere",
                column: "ScooterBrandID",
                principalTable: "ScooterBrands",
                principalColumn: "ScooterBrandID");
        }
    }
}
