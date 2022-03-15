using System.ComponentModel.DataAnnotations;

namespace Prueba.Models

{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccionf {get; set;}

        public string Direccione {get; set;}
        
        public string Telefono {get; set;}

        public string Email {get; set;}
    }
}