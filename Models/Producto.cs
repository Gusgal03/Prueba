using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        public string Descripcion { get; set; }

        public int Precio { get; set; }

        public int Cantidad { get; set; }
    }
}