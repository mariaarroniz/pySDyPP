using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace pySDyPPApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoPrueba",
                table: "pruebas",
                newName: "Discriminator");

            migrationBuilder.InsertData(
                table: "pacientes",
                columns: new[] { "PacienteId", "Apellidos", "Edad", "FechaNacimiento", "Genero", "Nombre", "Telefono", "TipoDiabetes" },
                values: new object[,]
                {
                    { 1, "Arróniz Saiz", 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "María", "123456789", "TipoI" },
                    { 2, "Deras Ortiz", 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Nazaret", "987654321", "TipoII" },
                    { 3, "García López", 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Javier", "601835924", "TipoII" },
                    { 4, "Martínez Ruíz", 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Elena", "678102934", "TipoI" },
                    { 5, "Sánchez Pérez", 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Carlos", "722560813", "TipoII" },
                    { 6, "Fernández Soto", 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Laura", "640917285", "TipoI" },
                    { 7, "Hernández Gil", 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "Miguel", "699345102", "TipoI" }
                });

            migrationBuilder.InsertData(
                table: "pruebas",
                columns: new[] { "PruebaId", "Discriminator", "Estado", "FechaRealizacion", "Hba1", "Observaciones", "PacienteId", "Realizada", "Resultado", "SiguienteRealizacion", "Tipo" },
                values: new object[,]
                {
                    { 1, "Analitica", "Realizada", new DateTime(2025, 11, 24, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3428), true, "Perfil lipídico ok.", 1, true, "Normal", new DateTime(2026, 6, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3477), "Analitica" },
                    { 2, "Analitica", "Pendiente", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Programar cita.", 3, false, "Pendiente", new DateTime(2026, 12, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3483), "Analitica" }
                });

            migrationBuilder.InsertData(
                table: "pruebas",
                columns: new[] { "PruebaId", "Altura", "Discriminator", "Estado", "FechaRealizacion", "Observaciones", "PacienteId", "Peso", "Realizada", "Resultado", "SiguienteRealizacion", "TensionArterial", "Tipo", "glucemiaCapilar" },
                values: new object[,]
                {
                    { 3, 1.7f, "Constantes", "Realizada", new DateTime(2025, 12, 4, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3504), "Tensión y glucemia estables.", 1, 65.5f, true, "Óptimo", new DateTime(2026, 3, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3505), 120.8f, "Constantes", 105f },
                    { 4, 1.82f, "Constantes", "Realizada", new DateTime(2025, 12, 8, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3510), "Tensión ligeramente alta.", 3, 88f, true, "Límite", new DateTime(2026, 3, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3511), 140.95f, "Constantes", 135f }
                });

            migrationBuilder.InsertData(
                table: "pruebas",
                columns: new[] { "PruebaId", "ActividadFisica", "Alcohol", "Discriminator", "Drogas", "Estado", "FechaRealizacion", "Fumar", "Observaciones", "PacienteId", "Realizada", "Resultado", "SiguienteRealizacion", "Tipo", "TomaMedicacionCorectamente" },
                values: new object[] { 5, "Regular", "Ocasional", "Preguntas", "No", "Realizada", new DateTime(2025, 11, 19, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3527), "No", "Estilo de vida activo.", 1, true, "Bajo riesgo", new DateTime(2026, 12, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3528), "Preguntas", "Sí" });

            migrationBuilder.InsertData(
                table: "pruebas",
                columns: new[] { "PruebaId", "Discriminator", "Estado", "FechaRealizacion", "Observaciones", "PacienteId", "Realizada", "Resultado", "SiguienteRealizacion", "Tipo" },
                values: new object[] { 7, "Electrocardiograma", "Realizada", new DateTime(2025, 11, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3549), "Sin alteraciones relevantes.", 3, true, "Normal", new DateTime(2026, 12, 9, 10, 41, 0, 876, DateTimeKind.Local).AddTicks(3550), "Electrocardiograma" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pacientes",
                keyColumn: "PacienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pacientes",
                keyColumn: "PacienteId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "pacientes",
                keyColumn: "PacienteId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "pacientes",
                keyColumn: "PacienteId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "pacientes",
                keyColumn: "PacienteId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "pruebas",
                keyColumn: "PruebaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "pacientes",
                keyColumn: "PacienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pacientes",
                keyColumn: "PacienteId",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "pruebas",
                newName: "TipoPrueba");
        }
    }
}
