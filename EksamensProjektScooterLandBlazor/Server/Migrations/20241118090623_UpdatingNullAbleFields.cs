using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingNullAbleFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medarbejdere_ScooterBrands_ScooterBrandID",
                table: "Medarbejdere");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdreLinjer_Produkter_ProduktID",
                table: "OrdreLinjer");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdreLinjer_ScooterLejer_ScooterLejeID",
                table: "OrdreLinjer");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdreLinjer_Ydelser_YdelseID",
                table: "OrdreLinjer");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Kunder_KundeiD",
                table: "Ordrer");

            migrationBuilder.AlterColumn<double>(
                name: "Pris",
                table: "ScooterLejer",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "AntalDage",
                table: "ScooterLejer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "SamletPris",
                table: "Ordrer",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "MedarbejderCpr",
                table: "Ordrer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KundeiD",
                table: "Ordrer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "BetalingsSum",
                table: "Ordrer",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "YdelseID",
                table: "OrdreLinjer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ScooterLejeID",
                table: "OrdreLinjer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RabatProcent",
                table: "OrdreLinjer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProduktID",
                table: "OrdreLinjer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Medarbejdere_ScooterBrands_ScooterBrandID",
                table: "Medarbejdere",
                column: "ScooterBrandID",
                principalTable: "ScooterBrands",
                principalColumn: "ScooterBrandID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdreLinjer_Produkter_ProduktID",
                table: "OrdreLinjer",
                column: "ProduktID",
                principalTable: "Produkter",
                principalColumn: "ProduktID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdreLinjer_ScooterLejer_ScooterLejeID",
                table: "OrdreLinjer",
                column: "ScooterLejeID",
                principalTable: "ScooterLejer",
                principalColumn: "ScooterID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdreLinjer_Ydelser_YdelseID",
                table: "OrdreLinjer",
                column: "YdelseID",
                principalTable: "Ydelser",
                principalColumn: "YdelseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Kunder_KundeiD",
                table: "Ordrer",
                column: "KundeiD",
                principalTable: "Kunder",
                principalColumn: "KundeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medarbejdere_ScooterBrands_ScooterBrandID",
                table: "Medarbejdere");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdreLinjer_Produkter_ProduktID",
                table: "OrdreLinjer");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdreLinjer_ScooterLejer_ScooterLejeID",
                table: "OrdreLinjer");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdreLinjer_Ydelser_YdelseID",
                table: "OrdreLinjer");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Kunder_KundeiD",
                table: "Ordrer");

            migrationBuilder.AlterColumn<double>(
                name: "Pris",
                table: "ScooterLejer",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AntalDage",
                table: "ScooterLejer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "SamletPris",
                table: "Ordrer",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MedarbejderCpr",
                table: "Ordrer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KundeiD",
                table: "Ordrer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "BetalingsSum",
                table: "Ordrer",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "YdelseID",
                table: "OrdreLinjer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ScooterLejeID",
                table: "OrdreLinjer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RabatProcent",
                table: "OrdreLinjer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProduktID",
                table: "OrdreLinjer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Medarbejdere_ScooterBrands_ScooterBrandID",
                table: "Medarbejdere",
                column: "ScooterBrandID",
                principalTable: "ScooterBrands",
                principalColumn: "ScooterBrandID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdreLinjer_Produkter_ProduktID",
                table: "OrdreLinjer",
                column: "ProduktID",
                principalTable: "Produkter",
                principalColumn: "ProduktID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdreLinjer_ScooterLejer_ScooterLejeID",
                table: "OrdreLinjer",
                column: "ScooterLejeID",
                principalTable: "ScooterLejer",
                principalColumn: "ScooterID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdreLinjer_Ydelser_YdelseID",
                table: "OrdreLinjer",
                column: "YdelseID",
                principalTable: "Ydelser",
                principalColumn: "YdelseID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Kunder_KundeiD",
                table: "Ordrer",
                column: "KundeiD",
                principalTable: "Kunder",
                principalColumn: "KundeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
