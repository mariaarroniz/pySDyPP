using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pySDyPPApi.Migrations
{
    /// <inheritdoc />
    public partial class AddNombreToPruebas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "pruebas",
                newName: "TipoPrueba");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "pruebas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "pruebas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 1,
                columns: new[] { "FechaRealizacion", "Nombre", "SiguienteRealizacion" },
                values: new object[] { new DateTime(2025, 11, 24, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(6918), "Analitica", new DateTime(2026, 6, 9, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 2,
                columns: new[] { "Nombre", "SiguienteRealizacion" },
                values: new object[] { "Analitica", new DateTime(2026, 12, 9, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 3,
                columns: new[] { "FechaRealizacion", "Nombre", "SiguienteRealizacion" },
                values: new object[] { new DateTime(2025, 12, 4, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(6989), "Constantes", new DateTime(2026, 3, 9, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 4,
                columns: new[] { "FechaRealizacion", "Nombre", "SiguienteRealizacion" },
                values: new object[] { new DateTime(2025, 12, 8, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(6994), "Constantes", new DateTime(2026, 3, 9, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 5,
                columns: new[] { "FechaRealizacion", "Nombre", "SiguienteRealizacion" },
                values: new object[] { new DateTime(2025, 11, 19, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(7010), "Preguntas", new DateTime(2026, 12, 9, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 7,
                columns: new[] { "FechaRealizacion", "Nombre", "SiguienteRealizacion" },
                values: new object[] { new DateTime(2025, 11, 9, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(7027), "Electrocardiograma", new DateTime(2026, 12, 9, 19, 18, 52, 456, DateTimeKind.Local).AddTicks(7028) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "pruebas");

            migrationBuilder.RenameColumn(
                name: "TipoPrueba",
                table: "pruebas",
                newName: "Discriminator");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "pruebas",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 1,
                columns: new[] { "FechaRealizacion", "SiguienteRealizacion", "Tipo" },
                values: new object[] { new DateTime(2025, 11, 24, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3428), new DateTime(2026, 6, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3477), "Analitica" });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 2,
                columns: new[] { "SiguienteRealizacion", "Tipo" },
                values: new object[] { new DateTime(2026, 12, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3483), "Analitica" });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 3,
                columns: new[] { "FechaRealizacion", "SiguienteRealizacion", "Tipo" },
                values: new object[] { new DateTime(2025, 12, 4, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3504), new DateTime(2026, 3, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3505), "Constantes" });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 4,
                columns: new[] { "FechaRealizacion", "SiguienteRealizacion", "Tipo" },
                values: new object[] { new DateTime(2025, 12, 8, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3510), new DateTime(2026, 3, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3511), "Constantes" });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 5,
                columns: new[] { "FechaRealizacion", "SiguienteRealizacion", "Tipo" },
                values: new object[] { new DateTime(2025, 11, 19, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3527), new DateTime(2026, 12, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3528), "Preguntas" });

            migrationBuilder.UpdateData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 7,
                columns: new[] { "FechaRealizacion", "SiguienteRealizacion", "Tipo" },
                values: new object[] { new DateTime(2025, 11, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3549), new DateTime(2026, 12, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3550), "Electrocardiograma" });
        }
    }
}
