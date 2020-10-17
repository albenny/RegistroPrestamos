using Microsoft.EntityFrameworkCore;
using RegistroPrestamos.Entidades;

namespace RegistroPrestamos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Moras> Moras { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data\Prestamo.db");
        }
    }
}