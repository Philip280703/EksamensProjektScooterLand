using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EksamensProjektScooterLandBlazor.Server.Migrations
{
    /// <inheritdoc />
    public partial class updateOrdreMedarbejderCpr1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Kunder_KundeID",
                table: "Ordrer");

            migrationBuilder.RenameColumn(
                name: "KundeID",
                table: "Ordrer",
                newName: "KundeiD");

            migrationBuilder.RenameIndex(
                name: "IX_Ordrer_KundeID",
                table: "Ordrer",
                newName: "IX_Ordrer_KundeiD");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Kunder_KundeiD",
                table: "Ordrer",
                column: "KundeiD",
                principalTable: "Kunder",
                principalColumn: "KundeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Kunder_KundeiD",
                table: "Ordrer");

            migrationBuilder.RenameColumn(
                name: "KundeiD",
                table: "Ordrer",
                newName: "KundeID");

            migrationBuilder.RenameIndex(
                name: "IX_Ordrer_KundeiD",
                table: "Ordrer",
                newName: "IX_Ordrer_KundeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Kunder_KundeID",
                table: "Ordrer",
                column: "KundeID",
                principalTable: "Kunder",
                principalColumn: "KundeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
