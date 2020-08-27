using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HoraExtraWebApMVC.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorasExtra");

            migrationBuilder.CreateTable(
                name: "HorasExtras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Departamento = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Matricula = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false),
                    Periodo = table.Column<string>(nullable: true),
                    Transporte = table.Column<string>(nullable: true),
                    Horas = table.Column<int>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorasExtras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorasExtras_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HorasExtras_FuncionarioId",
                table: "HorasExtras",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorasExtras");

            migrationBuilder.CreateTable(
                name: "HorasExtra",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<double>(nullable: false),
                    DataDaHora = table.Column<DateTime>(nullable: false),
                    FuncionarioId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorasExtra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorasExtra_Funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HorasExtra_FuncionarioId",
                table: "HorasExtra",
                column: "FuncionarioId");
        }
    }
}
