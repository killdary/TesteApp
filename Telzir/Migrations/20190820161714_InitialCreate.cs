using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Telzir.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarifa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DdOrigem = table.Column<int>(nullable: false),
                    DdDestino = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Porcentagem = table.Column<decimal>(nullable: false),
                    Criado = table.Column<DateTime>(nullable: false),
                    Editado = table.Column<DateTime>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plano_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(nullable: true),
                    Minutos = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    PlanoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacote_Plano_PlanoId",
                        column: x => x.PlanoId,
                        principalTable: "Plano",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacote_PlanoId",
                table: "Pacote",
                column: "PlanoId");

            migrationBuilder.CreateIndex(
                name: "IX_Plano_UsuarioId",
                table: "Plano",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacote");

            migrationBuilder.DropTable(
                name: "Tarifa");

            migrationBuilder.DropTable(
                name: "Plano");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
