using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        public string Descripcion { get; set; }
    }
}