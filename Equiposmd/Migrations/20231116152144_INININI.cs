using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Equiposmd.Migrations
{
    /// <inheritdoc />
    public partial class INININI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Numero_serial",
                table: "asignarAreaEquipos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Numero_activo_del_banco",
                table: "asignarAreaEquipos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Equipo",
                table: "asignarAreaEquipos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marca",
                table: "asignarAreaEquipos");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "asignarAreaEquipos");

            migrationBuilder.AlterColumn<string>(
                name: "Numero_serial",
                table: "asignarAreaEquipos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Numero_activo_del_banco",
                table: "asignarAreaEquipos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id_Equipo",
                table: "asignarAreaEquipos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
