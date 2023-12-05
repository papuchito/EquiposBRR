using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Equiposmd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _contexto;
        public HomeController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }
        
       

        
        
     
    
   
        
       
        
       
        
        public IActionResult Onigrama()
        {
            return View();
        }
       
        public IActionResult Seguridad()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}