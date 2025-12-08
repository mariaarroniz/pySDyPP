using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using pySDyPPApi.Models;

namespace pySDyPPApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Prueba> pruebas { get; set; }
        public DbSet<Analitica> pruebasAnalitica { get; set; }
        public DbSet<Constantes> pruebasConstantes { get; set; }
        public DbSet<Electrocardiograma> pruebasElectrocardiograma { get; set; }
        public DbSet<ITB> pruebasITB { get; set; }
        public DbSet<Preguntas> pregutnas { get; set; }
        public DbSet<Retinografia> pruebasRetinografia { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prueba>()
                .HasDiscriminator<string>("TipoPrueba");



            base.OnModelCreating(modelBuilder);
        }
    }
}
