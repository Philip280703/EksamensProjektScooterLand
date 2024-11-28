using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class foreignkeySpecInOrdre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Medarbejdere_medarbejderCprNummer",
                table: "Ordrer");

            migrationBuilder.DropIndex(
                name: "IX_Ordrer_medarbejderCprNummer",
                table: "Ordrer");

            migrationBuilder.DropColumn(
                name: "medarbejderCprNummer",
                table: "Ordrer");

            migrationBuilder.AlterColumn<string>(
                name: "MedarbejderCpr",
                table: "Ordrer",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ordrer_MedarbejderCpr",
                table: "Ordrer",
                column: "MedarbejderCpr");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Medarbejdere_MedarbejderCpr",
                table: "Ordrer",
                column: "MedarbejderCpr",
                principalTable: "Medarbejdere",
                principalColumn: "CprNummer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Medarbejdere_MedarbejderCpr",
                table: "Ordrer");

            migrationBuilder.DropIndex(
                name: "IX_Ordrer_MedarbejderCpr",
                table: "Ordrer");

            migrationBuilder.AlterColumn<int>(
                name: "MedarbejderCpr",
                table: "Ordrer",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "medarbejderCprNummer",
                table: "Ordrer",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ordrer_medarbejderCprNummer",
                table: "Ordrer",
                column: "medarbejderCprNummer");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Medarbejdere_medarbejderCprNummer",
                table: "Ordrer",
                column: "medarbejderCprNummer",
                principalTable: "Medarbejdere",
                principalColumn: "CprNummer");
        }
    }
}
