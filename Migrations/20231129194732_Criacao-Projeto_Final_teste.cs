using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_Final.Migrations
{
    public partial class CriacaoProjeto_Final_teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntradaProduto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuantidadeEntrada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradaProduto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntradaProduto_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoSaida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoSaidaDescricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoSaida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenhaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntradaProduto_ProdutoId",
                table: "EntradaProduto",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntradaProduto");

            migrationBuilder.DropTable(
                name: "TipoSaida");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
