using Microsoft.EntityFrameworkCore;

namespace Prueba.Models
{
    public class PruebaContext : DbContext
    {

        public PruebaContext(DbContextOptions<PruebaContext> opciones)
        : base(opciones)
        {

        }

        public DbSet<Producto> Producto { get; set; }
    }
}