using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APITestes.Migrations
{
    public partial class ChangeDateToDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPublicacao",
                table: "Curso");

            migrationBuilder.AddColumn<DateTime>(
                name: "Descricao",
                table: "Curso",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Curso");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPublicacao",
                table: "Curso",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
