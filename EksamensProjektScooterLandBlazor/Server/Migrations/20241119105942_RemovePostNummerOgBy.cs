using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemovePostNummerOgBy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_PostNummerOgByer_postNummerOgByPostnummer",
                table: "Kunder");

            migrationBuilder.DropIndex(
                name: "IX_Kunder_postNummerOgByPostnummer",
                table: "Kunder");

            migrationBuilder.DropColumn(
                name: "postNummerOgByPostnummer",
                table: "Kunder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "postNummerOgByPostnummer",
                table: "Kunder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Kunder_postNummerOgByPostnummer",
                table: "Kunder",
                column: "postNummerOgByPostnummer");

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_PostNummerOgByer_postNummerOgByPostnummer",
                table: "Kunder",
                column: "postNummerOgByPostnummer",
                principalTable: "PostNummerOgByer",
                principalColumn: "Postnummer",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
