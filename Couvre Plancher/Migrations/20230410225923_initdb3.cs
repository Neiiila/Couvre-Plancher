using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Couvre_Plancher.Migrations
{
    /// <inheritdoc />
    public partial class initdb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "superviseurs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "superviseurs",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);
        }
    }
}
