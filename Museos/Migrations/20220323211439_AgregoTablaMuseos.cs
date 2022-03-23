using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museos.Migrations
{
    public partial class AgregoTablaMuseos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Museos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Historia = table.Column<string>(type: "TEXT", nullable: false),
                    FechaFundacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Mapa = table.Column<byte[]>(type: "BLOB", nullable: false),
                    Coordenadas = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Museos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Museos");
        }
    }
}
