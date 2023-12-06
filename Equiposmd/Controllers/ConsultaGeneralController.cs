using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Equiposmd.Controllers
{
    public class ConsultaGeneralController : Controller
    {
        private readonly ApplicationDbContext _contexto;

        public ConsultaGeneralController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public IActionResult TrasladarEquipo()
        {
            return View();
        }
        public IActionResult Suvar203()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> suvar203(suvar203 suvar203)
        {
            if (ModelState.IsValid)
            {
                _contexto.suvar203s.Add(suvar203);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(suvar203Info));
            }
            return View(suvar203);
        }
        [HttpPost]
        public async Task<IActionResult> TrasladarEquipo(TrasladarEquipo trasladarEquipo)
        {
            if (ModelState.IsValid)
            {
                _contexto.trasladarEquipo.Add(trasladarEquipo);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(suvar203Info));
            }
            return View(trasladarEquipo);
        }
        [HttpGet]
        public async Task<IActionResult> suvar203Info(string searchString)
        {
            var suvar203 = await _contexto.suvar203s.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                suvar203 = suvar203
                    .Where(s => s.Id.ToString().Contains(searchString)
                                || s.UnidadEmisora.Contains(searchString)
                                || s.Ubicacion.Contains(searchString)
                                || s.Oficina.Contains(searchString)
                                || s.Fecha.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.Codigo.ToString().Contains(searchString)
                                || s.Telefono.Contains(searchString)
                                || s.Numero_de_activo.ToString().Contains(searchString)
                                || s.Descripcion.Contains(searchString)
                                || s.Modelo.Contains(searchString)
                                || s.Marca.Contains(searchString)
                                || s.Numerodeserie.Contains(searchString)
                                || s.Color.Contains(searchString)
                                || s.Condicion.Contains(searchString)
                                || s.Observaciones.Contains(searchString)
                    )
                    .ToList();
            }

            return View(suvar203);
        }
        public async Task<IActionResult> SolicitudTraslado(string searchString)
        {
            var TrasladarEquipo = await _contexto.trasladarEquipo.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                TrasladarEquipo = TrasladarEquipo
                    .Where(s => s.Id.ToString().Contains(searchString)
                                || s.UnidadEmisora.Contains(searchString)
                                || s.Ubicacion.Contains(searchString)
                                || s.Oficina.Contains(searchString)
                                || s.Fecha.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.Codigo.ToString().Contains(searchString)
                                || s.Telefono.Contains(searchString)
                                || s.Numero_de_activo.ToString().Contains(searchString)
                                || s.Descripcion.Contains(searchString)
                                || s.Modelo.Contains(searchString)
                                || s.Marca.Contains(searchString)
                                || s.Numerodeserie.Contains(searchString)
                                || s.Color.Contains(searchString)
                                || s.Condicion.Contains(searchString)
                                || s.Observaciones.Contains(searchString)
                    )
                    .ToList();
            }

            return View(TrasladarEquipo);
        }

        public IActionResult Imprimir(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var suvar203 = _contexto.suvar203s.Find(id);
            if (suvar203 == null)
            {
                return NotFound();
            }
            return View(suvar203);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Imprimir(suvar203 suvar203)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(suvar203);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(suvar203Info));
            }
            return View();
        }
       
    }
}

    



