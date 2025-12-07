using Microsoft.EntityFrameworkCore;
using controlDiabeticos.Models;

namespace controlDiabeticos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Paciente> pacientes { get; set; }
    }
}
