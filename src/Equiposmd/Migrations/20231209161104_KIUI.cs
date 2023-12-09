using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equiposmd.Migrations
{
    /// <inheritdoc />
    public partial class KIUI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "asignarEquipoEmpleados");

            migrationBuilder.DropColumn(
                name: "Condicion",
                table: "asignarEquipoEmpleados");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "asignarEquipoEmpleados");

            migrationBuilder.DropColumn(
                name: "Modelo",
                table: "asignarEquipoEmpleados");

            migrationBuilder.DropColumn(
                name: "Numero_de_serie",
                table: "asignarEquipoEmpleados");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "asignarEquipoEmpleados");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "asignarAreaEquipos");

            migrationBuilder.DropColumn(
                name: "Numero_activo_del_banco",
                table: "asignarAreaEquipos");

            migrationBuilder.DropColumn(
                name: "Numero_serial",
                table: "asignarAreaEquipos");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "asignarAreaEquipos");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "trasladarEquipo",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "trasladarEquipo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "asignarEquipoEmpleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Condicion",
                table: "asignarEquipoEmpleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "asignarEquipoEmpleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Modelo",
                table: "asignarEquipoEmpleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero_de_serie",
                table: "asignarEquipoEmpleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "asignarEquipoEmpleados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "asignarAreaEquipos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Numero_activo_del_banco",
                table: "asignarAreaEquipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Numero_serial",
                table: "asignarAreaEquipos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "asignarAreaEquipos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
