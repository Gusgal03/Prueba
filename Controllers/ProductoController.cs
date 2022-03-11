using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;

namespace Prueba.Controllers
{
    public class ProductoController : Controller //esta clase hereda

    {
        private readonly PruebaContext _context;
        public ProductoController(PruebaContext context)
        {
            _context = context;

        }

        public IActionResult Index() //muestra el retorno en la interface de usuario
        {
            return View(_context.Producto.ToList());
        }
    }
}