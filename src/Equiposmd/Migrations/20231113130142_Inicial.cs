using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equiposmd.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "areaequipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<string>(type: "varchar(50)", nullable: false),
                    Area_Padre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areaequipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "detalleEs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(50)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Número_de_activo_del_banco = table.Column<string>(type: "int", nullable: false),
                    Número_serial_de_fábrica = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "char(10)", nullable: false),
                    Historial = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleEs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Género = table.Column<string>(type: "varchar(50)", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Teléfono = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Empresa = table.Column<string>(type: "varchar(50)", nullable: false),
                    Correo_electrónico = table.Column<string>(type: "varchar(50)", nullable: false),
                    Puesto = table.Column<string>(type: "varchar(50)", nullable: false),
                    Area = table.Column<string>(type: "varchar(50)", nullable: false),
                    Fecha_de_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo_de_contrato = table.Column<string>(type: "varchar(50)", nullable: false),
                    Duracion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Referencia = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "historialdelequipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(50)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Color = table.Column<string>(type: "varchar(50)", nullable: false),
                    Condicion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Numero_de_activo = table.Column<int>(type: "int", nullable: false),
                    Numero_serial = table.Column<int>(type: "int", nullable: false),
                    Fecha_fabricacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_adquisicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_expiracion_garantia_1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_expiracion_garantia_2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_final_vida_util = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_descarte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<decimal>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historialdelequipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mequipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(50)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Color = table.Column<string>(type: "varchar(50)", nullable: false),
                    Condicion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Numero_de_activo = table.Column<int>(type: "int", nullable: false),
                    Numero_serial = table.Column<int>(type: "int", nullable: false),
                    Fecha_fabricacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_adquisicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_expiracion_garantia_1 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_expiracion_garantia_2 = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_final_vida_util = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_descarte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<decimal>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mequipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "onigramas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empresa = table.Column<string>(type: "varchar(50)", nullable: false),
                    Area_administrativa = table.Column<string>(type: "varchar(50)", nullable: false),
                    Subarea = table.Column<string>(type: "varchar(50)", nullable: false),
                    Codigo_interno = table.Column<string>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_onigramas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "registroindividuals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: " varchar(50)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(50)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Número_de_activo_del_banco = table.Column<string>(type: "int", nullable: false),
                    Número_serial_de_fábrica = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "char(10)", nullable: false),
                    Historial = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registroindividuals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "seguridads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol = table.Column<string>(type: "varchar(50)", nullable: false),
                    Area = table.Column<string>(type: "varchar(50)", nullable: false),
                    Equipo = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seguridads", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "areaequipos");

            migrationBuilder.DropTable(
                name: "detalleEs");

            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "historialdelequipos");

            migrationBuilder.DropTable(
                name: "mequipos");

            migrationBuilder.DropTable(
                name: "onigramas");

            migrationBuilder.DropTable(
                name: "registroindividuals");

            migrationBuilder.DropTable(
                name: "seguridads");
        }
    }
}
