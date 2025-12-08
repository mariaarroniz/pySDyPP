using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pySDyPPApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pacientes",
                columns: table => new
                {
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellidos = table.Column<string>(type: "TEXT", nullable: false),
                    Edad = table.Column<int>(type: "INTEGER", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TipoDiabetes = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacientes", x => x.PacienteId);
                });

            migrationBuilder.CreateTable(
                name: "pruebas",
                columns: table => new
                {
                    PruebaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<string>(type: "TEXT", nullable: false),
                    Realizada = table.Column<bool>(type: "INTEGER", nullable: false),
                    FechaRealizacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SiguienteRealizacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Resultado = table.Column<string>(type: "TEXT", nullable: false),
                    Observaciones = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    TipoPrueba = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    Hba1 = table.Column<bool>(type: "INTEGER", nullable: true),
                    Peso = table.Column<float>(type: "REAL", nullable: true),
                    Altura = table.Column<float>(type: "REAL", nullable: true),
                    TensionArterial = table.Column<float>(type: "REAL", nullable: true),
                    glucemiaCapilar = table.Column<float>(type: "REAL", nullable: true),
                    ActividadFisica = table.Column<string>(type: "TEXT", nullable: true),
                    Fumar = table.Column<string>(type: "TEXT", nullable: true),
                    Drogas = table.Column<string>(type: "TEXT", nullable: true),
                    Alcohol = table.Column<string>(type: "TEXT", nullable: true),
                    TomaMedicacionCorectamente = table.Column<string>(type: "TEXT", nullable: true),
                    AlteracionesTipoII = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pruebas", x => x.PruebaId);
                    table.ForeignKey(
                        name: "FK_pruebas_pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "pacientes",
                        principalColumn: "PacienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pruebas_PacienteId",
                table: "pruebas",
                column: "PacienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pruebas");

            migrationBuilder.DropTable(
                name: "pacientes");
        }
    }
}
