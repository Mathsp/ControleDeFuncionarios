using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleFuncionarios.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoCamposDeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInclusao",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DataInclusao",
                table: "AspNetUsers");
        }
    }
}
