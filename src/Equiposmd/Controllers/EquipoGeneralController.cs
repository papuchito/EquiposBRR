using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Equiposmd.Controllers
{
    public class EquipoGeneralController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public EquipoGeneralController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> RegistroIndividual1(RegistroIndividual registroIndividual)
        {
            if (ModelState.IsValid)

            {
                _contexto.registroindividuals.Add(registroIndividual);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(DetalleE));
            }
            return View();
        }
        public async Task<IActionResult> RegistroIndividual2(string buscar)
        {
            var registroIndividuals = from registroindividual in _contexto.registroindividuals select registroindividual;


            if (!String.IsNullOrEmpty(buscar))
            {
                registroIndividuals = registroIndividuals.Where(s => s.Marca!.Contains(buscar));
            }



            return View("~/Views/EquipoGeneral/RegistroIndividual.cshtml", await registroIndividuals.ToListAsync());

        }

        public IActionResult RegistroIndividual()
        {
            return View("RegistroIndividual");
        }


        [HttpGet]
        public async Task<IActionResult> DetalleE(string searchString)
        {
            var registroIndividual = await _contexto.registroindividuals.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                registroIndividual = registroIndividual
                    .Where(s => s.Tipo.Contains(searchString)
                                || s.Marca.Contains(searchString)
                                || s.Modelo.Contains(searchString)
                                || s.Número_de_activo_del_banco.ToString().Contains(searchString)
                                || s.Número_serial_de_fábrica.Contains(searchString)
                                || s.Estado.Contains(searchString)
                                || s.Color.Contains(searchString)
                    // Añade más propiedades según sea necesario
                    )
                    .ToList();
            }

            return View(registroIndividual);
        }


        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var registroIndividual = _contexto.registroindividuals.Find(id);
            if (registroIndividual == null)
            {
                return NotFound();
            }
            return View(registroIndividual);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(RegistroIndividual registroIndividual)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(registroIndividual);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(DetalleE));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Detalle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var registroIndividual = _contexto.registroindividuals.Find(id);
            if (registroIndividual == null)
            {
                return NotFound();
            }
            return View(registroIndividual);
        }
        [HttpGet]
        public IActionResult Borrar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var registroIndividual = _contexto.registroindividuals.Find(id);
            if (registroIndividual == null)
            {
                return NotFound();
            }
            return View(registroIndividual);
        }
        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrarContacto(int? id)
        {
            var registroIndividual = await _contexto.registroindividuals.FindAsync(id);
            if (registroIndividual == null)
            {
                return View();
            }
            _contexto.registroindividuals.Remove(registroIndividual);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(DetalleE));
        }
        public IActionResult RegistrarMarcas()
        {
            return View();
        }
        public async Task<IActionResult> RegistrarMarca(RegistrarMarcas registrarMarcas)
        {
            if (ModelState.IsValid)
            {
                _contexto.registrarMarcas.Add(registrarMarcas);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            return View("Index");
        }
    }
}
