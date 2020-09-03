using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estapar.Infrastructure.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    Placa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manobrista",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    CPF = table.Column<string>(nullable: false),
                    Data_Nascimento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manobrista", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarroManobrista",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponsavelPorManobrar = table.Column<int>(nullable: false),
                    CarroManobrado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarroManobrista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarroManobrista_Carro_CarroManobrado",
                        column: x => x.CarroManobrado,
                        principalTable: "Carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarroManobrista_Manobrista_ResponsavelPorManobrar",
                        column: x => x.ResponsavelPorManobrar,
                        principalTable: "Manobrista",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carro_Placa",
                table: "Carro",
                column: "Placa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarroManobrista_CarroManobrado",
                table: "CarroManobrista",
                column: "CarroManobrado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarroManobrista_ResponsavelPorManobrar",
                table: "CarroManobrista",
                column: "ResponsavelPorManobrar");

            migrationBuilder.CreateIndex(
                name: "IX_Manobrista_CPF",
                table: "Manobrista",
                column: "CPF",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarroManobrista");

            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Manobrista");
        }
    }
}
