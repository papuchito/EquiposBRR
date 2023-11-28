using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equiposmd.Migrations
{
    /// <inheritdoc />
    public partial class nuevooooo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Número_de_activo_del_banco",
                table: "registroindividuals",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "solicitudEquipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEquipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Procesador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemoriaRam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscoDuro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarjetaGrafica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_solicitudEquipos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "solicitudEquipos");

            migrationBuilder.AlterColumn<string>(
                name: "Número_de_activo_del_banco",
                table: "registroindividuals",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
