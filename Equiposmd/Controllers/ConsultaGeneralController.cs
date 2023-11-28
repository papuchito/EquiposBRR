using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Equiposmd.Controllers
{
    public class ConsultaGeneralController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public ConsultaGeneralController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult suvar203()
        {
            return View();
        }

        public async Task<IActionResult> suvar2033(suvar203 suvar203)
        {
            if (ModelState.IsValid)

            {
                _contexto.suvar203s.Add(suvar203);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View("Index");
        }
    }
}





