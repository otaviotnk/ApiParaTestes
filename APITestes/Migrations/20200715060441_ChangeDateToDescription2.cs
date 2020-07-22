using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APITestes.Migrations
{
    public partial class ChangeDateToDescription2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Curso",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Descricao",
                table: "Curso",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
