using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Edit(int? id) //el ? es en caso de que se reciba en null y edita
        {
            if(id == null)
            {
                return NotFound();
            }

            var producto = _context.Producto.Find(id); //Igual que un select from

            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);

        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind("IdProducto, Descripcion")] Producto producto)
        {
            if(id!= producto.IdProducto)
            {
                return NotFound();
            }

            if(ModelState.IsValid) //si las validaciones del formulario estan bien
            {
                _context.Update(producto); //entonces que lo actualice y luego lo grabe
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }
    }
}