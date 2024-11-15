using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class updateOrdreMedarbejderCpr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MedarbejderCprNummer",
                table: "Ordrer",
                newName: "MedarbejderCprNum");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MedarbejderCprNum",
                table: "Ordrer",
                newName: "MedarbejderCprNummer");
        }
    }
}
