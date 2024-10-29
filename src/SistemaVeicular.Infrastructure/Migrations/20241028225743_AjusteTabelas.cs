using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVeicular.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Cliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Cliente",
                type: "text",
                nullable: true);
        }
    }
}
