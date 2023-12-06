using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equiposmd.Migrations
{
    /// <inheritdoc />
    public partial class KUKKK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "historialEventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_serial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero_de_activo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoEvento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Detalles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpleadoAsignado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaOrigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareInstalado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetallesMantenimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetallesReparacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetallesModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CausaDaño = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historialEventos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historialEventos");
        }
    }
}
