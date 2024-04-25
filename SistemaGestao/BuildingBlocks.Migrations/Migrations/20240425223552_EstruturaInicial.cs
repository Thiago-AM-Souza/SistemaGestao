using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingBlocks.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class EstruturaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "colaborador");

            migrationBuilder.EnsureSchema(
                name: "unidade");

            migrationBuilder.EnsureSchema(
                name: "usuario");

            migrationBuilder.CreateTable(
                name: "unidades",
                schema: "unidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Desativado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                schema: "usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "varchar", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: false),
                    Desativado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "colaboradores",
                schema: "colaborador",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uuid", nullable: false),
                    UnidadeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colaboradores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_colaboradores_unidades_UnidadeId",
                        column: x => x.UnidadeId,
                        principalSchema: "unidade",
                        principalTable: "unidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_colaboradores_usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalSchema: "usuario",
                        principalTable: "usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_colaboradores_UnidadeId",
                schema: "colaborador",
                table: "colaboradores",
                column: "UnidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_colaboradores_UsuarioId",
                schema: "colaborador",
                table: "colaboradores",
                column: "UsuarioId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "colaboradores",
                schema: "colaborador");

            migrationBuilder.DropTable(
                name: "unidades",
                schema: "unidade");

            migrationBuilder.DropTable(
                name: "usuarios",
                schema: "usuario");
        }
    }
}
