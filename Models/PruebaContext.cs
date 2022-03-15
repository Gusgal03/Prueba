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

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entidad =>
            {
                entidad.ToTable("Producto"); //A la tabla en particular se le asigna el nombre Producto

                entidad.HasKey(e => e.IdProducto);

                entidad.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
            }
            );
        }*/
    }
}