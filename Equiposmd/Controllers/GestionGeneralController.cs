using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Equiposmd.Controllers
{
    public class GestionGeneralController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public GestionGeneralController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> NuevaSolicitud(SolicitudEquipo solicitudEquipo)
        {
            if (ModelState.IsValid)
            {
                _contexto.solicitudEquipos.Add(solicitudEquipo);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(ListaSolicitudes));
            }
            return View(solicitudEquipo);
        }


        [HttpGet]
        public async Task<IActionResult> ListaSolicitudes(string searchString)
        {
           
            var solicitudEquipos = await _contexto.solicitudEquipos.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                solicitudEquipos = solicitudEquipos
                    .Where(s => s.Areasolicitada.Contains(searchString)
                                || s.TipoEquipo.Contains(searchString)
                                || s.Procesador.Contains(searchString)
                                || s.MemoriaRam.Contains(searchString)
                                || s.DiscoDuro.Contains(searchString)
                    // Añade más propiedades según sea necesario
                    )
                    .ToList();
            }

            return View(solicitudEquipos);
        }



        public IActionResult SolicitudEquipo()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var solicitudequipo = _contexto.solicitudEquipos.Find(id);
            if (solicitudequipo == null)
            {
                return NotFound();
            }
            return View(solicitudequipo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(SolicitudEquipo solicitudEquipo)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(solicitudEquipo);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(ListaSolicitudes));
            }
            return View();
        }
     
        [HttpGet]
        public IActionResult Borrar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var solicitudequipo = _contexto.solicitudEquipos.Find(id);
            if (solicitudequipo == null)
            {
                return NotFound();
            }
            return View(solicitudequipo);
        }
        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrarContacto(int? id)
        {
            var solicitudequipo = await _contexto.solicitudEquipos.FindAsync(id);
            if (solicitudequipo == null)
            {
                return View();
            }
            _contexto.solicitudEquipos.Remove(solicitudequipo);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(ListaSolicitudes));
        }
       
       




    }
}



        