using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equiposmd.Migrations
{
    /// <inheritdoc />
    public partial class JJ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "registrarMarcas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "registrarMarcas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
