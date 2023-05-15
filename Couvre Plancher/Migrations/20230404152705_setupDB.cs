using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Couvre_Plancher.Migrations
{
    /// <inheritdoc />
    public partial class setupDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "couvrePlanches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prix = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_couvrePlanches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materiel",
                columns: table => new
                {
                    Nom = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrixParMetre = table.Column<float>(type: "real", nullable: false),
                    PrixMainOeuvre = table.Column<float>(type: "real", nullable: false),
                    CouvrePlancheId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiel", x => x.Nom);
                    table.ForeignKey(
                        name: "FK_Materiel_couvrePlanches_CouvrePlancheId",
                        column: x => x.CouvrePlancheId,
                        principalTable: "couvrePlanches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materiel_CouvrePlancheId",
                table: "Materiel",
                column: "CouvrePlancheId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materiel");

            migrationBuilder.DropTable(
                name: "couvrePlanches");
        }
    }
}
