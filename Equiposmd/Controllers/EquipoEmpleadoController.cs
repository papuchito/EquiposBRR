using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Equiposmd.Controllers
{
    public class EquipoEmpleadoController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public EquipoEmpleadoController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult EmpleadoEasignado()
        {
            return View();
        }
        public async Task<IActionResult> EAsignar(AsignarEquipoEmpleado asignarEquipoEmpleado)
        {
            if (ModelState.IsValid)
            {
                _contexto.asignarEquipoEmpleados.Add(asignarEquipoEmpleado);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(InformacionA));
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> InformacionA(string searchString)
        {
            var asignarEquipoEmpleados = await _contexto.asignarEquipoEmpleados.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                asignarEquipoEmpleados = asignarEquipoEmpleados
                    .Where(s => s.ID_del_Equipo.ToString().Contains(searchString)
                                || s.Tipo.Contains(searchString)
                                || s.Marca.Contains(searchString)
                                || s.Condicion.Contains(searchString)
                                || s.Modelo.Contains(searchString)
                                || s.Numero_de_serie.Contains(searchString)
                                || s.Color.Contains(searchString)
                                || s.Fecha_de_Asignacion.ToString("yyyy-MM-dd").Contains(searchString)
                                || s.Estado.Contains(searchString)
                                || s.Ubicación_Actual.Contains(searchString)
                                || s.Asignado.Contains(searchString)


                    )
                    .ToList();
            }

            return View(asignarEquipoEmpleados);
        }
    }
}
