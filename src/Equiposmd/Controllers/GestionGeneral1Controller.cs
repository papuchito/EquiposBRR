using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Equiposmd.Controllers
{
    public class GestionGeneral1Controller : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public GestionGeneral1Controller(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> MEquipo(Mequipo mequipo)
        {
            if (ModelState.IsValid)
            {
                _contexto.mequipos.Add(mequipo);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Historialdeequipo));
            }
            return View();

        }
        public IActionResult ModeloEquipo()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Historialdeequipo(string searchString)
        {
            var mequipo = await _contexto.mequipos.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                mequipo = mequipo
                    .Where(s =>  s.Tipo.Contains(searchString)
                                || s.Marca.Contains(searchString)
                                || s.Modelo.Contains(searchString)
                                || s.Color.Contains(searchString)
                                || s.Condicion.Contains(searchString)
                                || s.Numero_de_activo.ToString().Contains(searchString)
                                || s.Numero_serial.Contains(searchString)
                                || s.Fecha_fabricacion.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.fecha_adquisicion.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.Fecha_expiracion_garantia_1.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.Fecha_expiracion_garantia_2.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.Fecha_final_vida_util.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.Fecha_descarte.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.Precio.ToString().Contains(searchString)
                                || s.Cantidad.ToString().Contains(searchString)



                    )
                    .ToList();
            }

            return View(mequipo);
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var mEquipos = _contexto.mequipos.Find(id);
            if (mEquipos == null)
            {
                return NotFound();
            }
            return View(mEquipos);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Mequipo mequipo)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(mequipo);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Historialdeequipo));
            }
            return View(mequipo); 
        }

       
    }
}
