using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Equiposmd.Controllers
{
    public class EmpleadoGeneralController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public EmpleadoGeneralController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public async Task<IActionResult> AsignarEquipo(EquiposAsignados equiposAsignados)
        {
            if (ModelState.IsValid)
            {
                _contexto.equiposAsignados.Add(equiposAsignados);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(InformacionA));
            }
            return View();
        }

        public IActionResult EquiposAsignados()
        {
            return View();
        }
       
        [HttpGet]
        public async Task<IActionResult> InformacionA(string searchString)
        {
            var equiposAsignados = await _contexto.equiposAsignados.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                equiposAsignados = equiposAsignados
                    .Where(s => s.ID_del_Equipo.ToString().Contains(searchString)
                                || s.Tipo.Contains(searchString)
                                || s.Marca.Contains(searchString)
                                || s.Condicion.Contains(searchString)
                                || s.Modelo.Contains(searchString)
                                || s.Numero_de_serie.Contains(searchString)
                                || s.Color.Contains(searchString)
                                || s.Fecha_de_fabricacion.ToString("yyyy-MM-dd").Contains(searchString) 
                                || s.Fecha_de_adquisicion.ToString("yyyy-MM-dd").Contains(searchString) 
                                || s.Estado.Contains(searchString)
                                || s.Ubicación_Actual.Contains(searchString)
                                || s.Asignado.Contains(searchString)
                                

                    )
                    .ToList();
            }

            return View(equiposAsignados);
        }
    }
}



