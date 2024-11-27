using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class addingEkstraAntalToOrdreLinjeNullAble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AntalEkstra",
                table: "OrdreLinjer",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AntalEkstra",
                table: "OrdreLinjer");
        }
    }
}
