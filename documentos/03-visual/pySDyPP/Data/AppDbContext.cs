using Microsoft.EntityFrameworkCore;
using pySDyPP.Models;

namespace pySDyPP.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Prueba> pruebas { get; set; }
        public DbSet<Analitica> pruebasAnalitica { get; set; }
        public DbSet<Constantes> pruebasConstantes { get; set; }
        public DbSet<Electrocardiograma> pruebasElectrocardiograma { get; set; }
        public DbSet<ITB> pruebasITB { get; set; }
        public DbSet<Preguntas> pregutnas { get; set; }
        public DbSet<Retinografia> pruebasRetinografia { get; set; }
        public DbSet<TipoI> pruebasTipoI { get; set; }
        public DbSet<TipoII> pruebasTipoII { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             => optionsBuilder.UseSqlite("Data Source=pacientes.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>().HasData(
                new Paciente { PacienteId = 1,Telefono = "123456789", Nombre = "María", Apellidos = "Arróniz Saiz", Edad = 20, Genero = "Femenino", TipoDiabetes = "TipoI" },
                new Paciente { PacienteId = 2, Telefono = "987654321", Nombre = "Nazaret", Apellidos = "Deras Ortiz", Edad = 22, Genero = "Femenino", TipoDiabetes = "TipoII" },
                new Paciente { PacienteId = 3, Telefono = "601835924", Nombre = "Javier", Apellidos = "García López", Edad = 45, Genero = "Masculino", TipoDiabetes = "TipoII" },
                new Paciente { PacienteId = 4, Telefono = "678102934", Nombre = "Elena", Apellidos = "Martínez Ruíz", Edad = 31, Genero = "Femenino", TipoDiabetes = "TipoI" },
                new Paciente { PacienteId = 5, Telefono = "722560813", Nombre = "Carlos", Apellidos = "Sánchez Pérez", Edad = 60, Genero = "Masculino", TipoDiabetes = "TipoII" },
                new Paciente { PacienteId = 6, Telefono = "640917285", Nombre = "Laura", Apellidos = "Fernández Soto", Edad = 14, Genero = "Femenino", TipoDiabetes = "TipoI" },
                new Paciente { PacienteId = 7, Telefono = "699345102", Nombre = "Miguel", Apellidos = "Hernández Gil", Edad = 55, Genero = "Masculino", TipoDiabetes = "TipoI" }

            );

            modelBuilder.Entity<Analitica>().HasData(
                new Analitica
                {
                    PruebaId = 1,
                    Tipo = "Analitica",
                    Realizada = true,
                    FechaRealizacion = DateTime.Now.AddDays(-15),
                    SiguienteRealizacion = DateTime.Now.AddMonths(6),
                    Resultado = "Normal",
                    Observaciones = "Perfil lipídico ok.",
                    Estado = "Realizada",
                    PacienteId = 1,
                    Hba1 = true
                },
                new Analitica
                {
                    PruebaId = 2,
                    Tipo = "Analitica",
                    Realizada = false,
                    FechaRealizacion = DateTime.MinValue,
                    SiguienteRealizacion = DateTime.Now.AddMonths(12),
                    Resultado = "Pendiente",
                    Observaciones = "Programar cita.",
                    Estado = "Pendiente",
                    PacienteId = 3,
                    Hba1 = false
                }
            );

            modelBuilder.Entity<Constantes>().HasData(
                new Constantes
                {
                    PruebaId = 3,
                    Tipo = "Constantes",
                    Realizada = true,
                    FechaRealizacion = DateTime.Now.AddDays(-5),
                    SiguienteRealizacion = DateTime.Now.AddMonths(3),
                    Resultado = "Óptimo",
                    Observaciones = "Tensión y glucemia estables.",
                    Estado = "Realizada",
                    PacienteId = 1,
                    Peso = 65.5f,
                    Altura = 1.70f,
                    TensionArterial = 120.80f,
                    glucemiaCapilar = 105.0f
                },
                new Constantes
                {
                    PruebaId = 4,
                    Tipo = "Constantes",
                    Realizada = true,
                    FechaRealizacion = DateTime.Now.AddDays(-1),
                    SiguienteRealizacion = DateTime.Now.AddMonths(3),
                    Resultado = "Límite",
                    Observaciones = "Tensión ligeramente alta.",
                    Estado = "Realizada",
                    PacienteId = 3,
                    Peso = 88.0f,
                    Altura = 1.82f,
                    TensionArterial = 140.95f,
                    glucemiaCapilar = 135.0f
                }
            );

            modelBuilder.Entity<Preguntas>().HasData(
                new Preguntas
                {
                    PruebaId = 5,
                    Tipo = "Preguntas",
                    Realizada = true,
                    FechaRealizacion = DateTime.Now.AddDays(-20),
                    SiguienteRealizacion = DateTime.Now.AddYears(1),
                    Resultado = "Bajo riesgo",
                    Observaciones = "Estilo de vida activo.",
                    Estado = "Realizada",
                    PacienteId = 1,
                    ActividadFisica = "Regular",
                    Fumar = "No",
                    Drogas = "No",
                    Alcohol = "Ocasional",
                    TomaMedicacionCorectamente = "Sí"
                }
            );

            modelBuilder.Entity<Electrocardiograma>().HasData(
                new Electrocardiograma
                {
                    PruebaId = 7,
                    Tipo = "Electrocardiograma",
                    Realizada = true,
                    FechaRealizacion = DateTime.Now.AddDays(-30),
                    SiguienteRealizacion = DateTime.Now.AddYears(1),
                    Resultado = "Normal",
                    Observaciones = "Sin alteraciones relevantes.",
                    Estado = "Realizada",
                    PacienteId = 3
                }
            );


            modelBuilder.Entity<Prueba>()
                .HasDiscriminator<string>("TipoPrueba");

            modelBuilder.Entity<Paciente>()
                .HasMany(p => p.PruebasRealizadas)
                .WithOne(t => t.Paciente)
                .HasForeignKey(t => t.PacienteId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
