using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Diagnostics.Contracts;


namespace Equiposmd.Controllers
{
    public class AreaGeneralController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public AreaGeneralController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
       
        
        public IActionResult AsignarAEquipo()
        {
            return View();
        }
        public async Task<IActionResult> AsignarAEquipo1(AsignarAreaEquipo asignarAreaEquipo)
        {
            if (ModelState.IsValid)
            {
                _contexto.asignarAreaEquipos.Add(asignarAreaEquipo);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }
      
        public async Task<IActionResult> AEquiposDetalle(string searchString)
        {
            var asignarAreaEquipo = await _contexto.asignarAreaEquipos.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                asignarAreaEquipo = asignarAreaEquipo
                    .Where(s => s.Id_Equipo.ToString().Contains(searchString)
                                || s.Numero_activo_del_banco.ToString().Contains(searchString)
                                || s.Area_Asignada.Contains(searchString)
                                || s.Tipo.Contains(searchString)
                                || s.Marca.Contains(searchString)
                                
                    )
                    .ToList();
            }

            return View(asignarAreaEquipo);
        }
    }
}
