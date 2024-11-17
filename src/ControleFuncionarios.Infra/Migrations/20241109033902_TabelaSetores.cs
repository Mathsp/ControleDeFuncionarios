using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleFuncionarios.Infra.Migrations
{
    /// <inheritdoc />
    public partial class TabelaSetores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioInclusao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioAlteracao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Excluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Setores");
        }
    }
}
