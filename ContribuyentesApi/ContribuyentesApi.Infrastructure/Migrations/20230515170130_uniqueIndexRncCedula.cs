using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContribuyentesApi.Infrastructure.Migrations
{
    public partial class uniqueIndexRncCedula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RncCedula",
                table: "Contribuyentes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Contribuyentes_RncCedula",
                table: "Contribuyentes",
                column: "RncCedula",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contribuyentes_RncCedula",
                table: "Contribuyentes");

            migrationBuilder.AlterColumn<string>(
                name: "RncCedula",
                table: "Contribuyentes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
