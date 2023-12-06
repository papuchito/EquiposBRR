using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Equiposmd.Controllers
{
    public class HistorialEventoController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public HistorialEventoController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public IActionResult HistorialEvento()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ListaDeEvento(string searchString)
        {
            var historialEvento = await _contexto.historialEventos.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                historialEvento = historialEvento
                    .Where(s => s.Numero_serial.ToString().Contains(searchString)
                                || s.Fecha.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.TipoEvento.Contains(searchString)
                                || s.Detalles.Contains(searchString)
                                || s.EmpleadoAsignado.Contains(searchString)
                                || s.AreaOrigen.Contains(searchString)
                                || s.AreaDestino.Contains(searchString)
                                || s.SoftwareInstalado.Contains(searchString)
                                || s.DetallesMantenimiento.ToString().Contains(searchString)
                                || s.DetallesReparacion.Contains(searchString)
                                || s.DetallesModificacion.Contains(searchString)
                                || s.CausaDaño.Contains(searchString)
                    // Añade más propiedades según sea necesario
                    )
                    .ToList();
            }

            return View(historialEvento);
        }

        public async Task<IActionResult> ListaDeEvento(HistorialEvento ListaDeEvento)
        {
            if (ModelState.IsValid)
            {
                _contexto.historialEventos.Add(ListaDeEvento);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(ListaDeEvento));
            }
            return View(ListaDeEvento);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(HistorialEvento historialEvento)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(historialEvento);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(historialEvento));
            }
            return View();
        }
        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var historialEvento = _contexto.historialEventos.Find(id);
            if (historialEvento == null)
            {
                return NotFound();
            }
            return View(historialEvento);
        }
    }
}