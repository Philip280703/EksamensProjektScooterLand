using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class mekanikerPrefBeNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.AlterColumn<string>(
                name: "PreferetMekanikerCprNummer",
                table: "Kunder",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Placering",
                table: "Kunder",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HusNummer",
                table: "Kunder",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Etage",
                table: "Kunder",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder",
                column: "PreferetMekanikerCprNummer",
                principalTable: "Medarbejdere",
                principalColumn: "CprNummer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder");

            migrationBuilder.AlterColumn<string>(
                name: "PreferetMekanikerCprNummer",
                table: "Kunder",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Placering",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HusNummer",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(4)",
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<string>(
                name: "Etage",
                table: "Kunder",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Medarbejdere_PreferetMekanikerCprNummer",
                table: "Kunder",
                column: "PreferetMekanikerCprNummer",
                principalTable: "Medarbejdere",
                principalColumn: "CprNummer",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
