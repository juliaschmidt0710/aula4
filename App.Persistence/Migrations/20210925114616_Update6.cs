using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Persistence.Migrations
{
    public partial class Update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "pessoa",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rg",
                table: "pessoa",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Telefone",
                table: "pessoa",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "pessoa");

            migrationBuilder.DropColumn(
                name: "Rg",
                table: "pessoa");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "pessoa");
        }
    }
}
