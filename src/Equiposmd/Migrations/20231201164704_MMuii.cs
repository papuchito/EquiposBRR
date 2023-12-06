using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equiposmd.Migrations
{
    /// <inheritdoc />
    public partial class MMuii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Asignado",
                table: "asignarEquipoEmpleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "asignarEquipoEmpleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha_de_Asignacion",
                table: "asignarEquipoEmpleados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Ubicación_Actual",
                table: "asignarEquipoEmpleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Asignado",
                table: "asignarEquipoEmpleados");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "asignarEquipoEmpleados");

            migrationBuilder.DropColumn(
                name: "Fecha_de_Asignacion",
                table: "asignarEquipoEmpleados");

            migrationBuilder.DropColumn(
                name: "Ubicación_Actual",
                table: "asignarEquipoEmpleados");
        }
    }
}
