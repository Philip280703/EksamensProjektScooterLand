using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemovedCalcFieldfromDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AntalDage",
                table: "ScooterLejer");

            migrationBuilder.DropColumn(
                name: "Ledig",
                table: "ScooterLejer");

            migrationBuilder.DropColumn(
                name: "Pris",
                table: "ScooterLejer");

            migrationBuilder.DropColumn(
                name: "SamletPris",
                table: "Ordrer");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "OrdreLinjer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AntalDage",
                table: "ScooterLejer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ledig",
                table: "ScooterLejer",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Pris",
                table: "ScooterLejer",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SamletPris",
                table: "Ordrer",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "OrdreLinjer",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
