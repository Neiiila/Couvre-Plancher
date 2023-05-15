using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Couvre_Plancher.Migrations
{
    /// <inheritdoc />
    public partial class initdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nom",
                table: "superviseurs",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "cin",
                table: "superviseurs",
                newName: "Cin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "superviseurs",
                newName: "nom");

            migrationBuilder.RenameColumn(
                name: "Cin",
                table: "superviseurs",
                newName: "cin");
        }
    }
}
