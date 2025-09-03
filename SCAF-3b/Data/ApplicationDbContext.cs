using Microsoft.EntityFrameworkCore;
using SCAF.Models; // Ajusta al namespace donde estarán tus modelos

namespace SCAF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Tablas de la BD
        public DbSet<Padre> Padres { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
    }
}
