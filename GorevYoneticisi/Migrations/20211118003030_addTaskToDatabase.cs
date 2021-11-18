using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GorevYoneticisi.Migrations
{
    public partial class addTaskToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gorev",
                columns: table => new
                {
                    gorevId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gorevAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    baslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gorevTuru = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorev", x => x.gorevId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gorev");
        }
    }
}
