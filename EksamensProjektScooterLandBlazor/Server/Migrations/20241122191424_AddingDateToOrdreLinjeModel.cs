using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddingDateToOrdreLinjeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrdreLinjeDato",
                table: "OrdreLinjer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "PreferetMekanikerCprNummer",
                table: "Kunder",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder",
                column: "PreferetMekanikerCprNummer",
                principalTable: "Medarbejdere",
                principalColumn: "CprNummer",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.DropColumn(
                name: "OrdreLinjeDato",
                table: "OrdreLinjer");

            migrationBuilder.AlterColumn<string>(
                name: "PreferetMekanikerCprNummer",
                table: "Kunder",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder",
                column: "PreferetMekanikerCprNummer",
                principalTable: "Medarbejdere",
                principalColumn: "CprNummer");
        }
    }
}
