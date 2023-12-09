using DinkToPdf.Contracts;
using DinkToPdf;
using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Equiposmd.Controllers
{
    public class ConsultaGeneralController : Controller
    {
        private readonly IConverter _converter;
        private readonly ApplicationDbContext _contexto;

        public ConsultaGeneralController(IConverter converter, ApplicationDbContext contexto)
        {
            _converter = converter;
            _contexto = contexto;
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
        public IActionResult DetalleDescarte(int? id)
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


        public IActionResult Imprimir(int id)
        {
            var model = ObtenerModeloPorId(id); // Obtén el modelo correspondiente según tu lógica

            if (model == null)
            {
                return NotFound();
            }

            var contenidoHTML = ObtenerContenidoPDF(model);

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = new GlobalSettings()
                {
                    PaperSize = PaperKind.A3Extra,
                    Orientation = Orientation.Portrait
                },
                Objects =
        {
            new ObjectSettings
            {
                HtmlContent = contenidoHTML
            }
        }
            };

            var archivoPDF = _converter.Convert(pdf);
            string nombrePDF = $"Reporte Descarte Equipo_{id}.pdf";

            return File(archivoPDF, "application/pdf", nombrePDF);
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
       
            public IActionResult MostrarPDFenPagina()
            {
                string pagina_actual = HttpContext.Request.Path;
                string url_pagina = HttpContext.Request.GetEncodedUrl();
                url_pagina = url_pagina.Replace(pagina_actual, "");
                url_pagina = $"{url_pagina}/ConsultaGeneral/Imprimir";


                var pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = new GlobalSettings()
                    {
                        PaperSize = PaperKind.A3Extra,
                        Orientation = Orientation.Portrait
                    },
                    Objects = {
                    new ObjectSettings(){
                        Page = url_pagina
                    }
                }

                };

                var archivoPDF = _converter.Convert(pdf);


                return File(archivoPDF, "application/pdf");
            }
        public IActionResult DescargarPDF([Bind("UnidadEmisora, Codigo, Fecha, Ubicacion, Telefono, Oficina, CodigoReceptor, Numero_de_activo, Descripcion, Modelo, Marca, Numerodeserie, Color, Condicion, Observaciones")] suvar203 model)
        {
            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = new GlobalSettings()
                {
                    PaperSize = PaperKind.A3Extra,
                    Orientation = Orientation.Portrait
                },
                Objects =
        {
            new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = $"<!DOCTYPE html><html><head></head><body>{ObtenerContenidoPDF(model)}</body></html>",
                WebSettings = { DefaultEncoding = "utf-8" },
                HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                FooterSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
            }
        }
            };

            var archivoPDF = _converter.Convert(pdf);
            string nombrePDF = "Reporte Descarte Equipo" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            return File(archivoPDF, "application/pdf", nombrePDF);
        }

        private string ObtenerContenidoPDF(suvar203 model)
        {
            return $@"
        <!DOCTYPE html>
        <html>
        <head>
            <title>Descarte(s) De Equipo(s) Mobiliarios</title>
            <style>
                .container {{
                    margin-top: 7px;
                    padding: 7px;
                    border: 1px solid #ccc;
                    border-radius: 5px;
                    background-color: #f9f9f9;
                }}

                .form-group {{
                    margin-bottom: 20px;
                }}

                .form-control {{
                    width: 100%;
                    padding: 10px;
                    font-size: 16px;
                }}

                .text-danger {{
                    color: red;
                }}

                h1 {{
                    text-align: right;
                }}
            </style>
        </head>
        <body>

            <div class='container'>
                <h1>Descarte(s) De Equipo(s) Mobiliarios</h1>
                
                <div class='row'>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Unidad Emisora</h6>
                            <input class='form-control' value='{model.UnidadEmisora}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Codigo</h6>
                            <input class='form-control' value='{model.Codigo}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Fecha</h6>
                            <input class='form-control' value='{model.Fecha.ToString("yyyy-MM-dd")}' type='date' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Departamento/Ubicacion</h6>
                            <input class='form-control' value='{model.Ubicacion}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Telefono</h6>
                            <input class='form-control' value='{model.Telefono}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Oficina/Unidad receptora</h6>
                            <input class='form-control' value='{model.Oficina}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Codigo Receptor</h6>
                            <input class='form-control' value='{model.CodigoReceptor}' disabled>
                        </div>
                    </div>
                </div>
            </div>

            <div class='container'>
                <h1>Descarte(s) De Equipo(s) Mobiliarios</h1>
                
                <div class='row'>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Numero De Activo</h6>
                            <input class='form-control' value='{model.Numero_de_activo}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Descripcion</h6>
                            <input class='form-control' value='{model.Descripcion}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Modelo</h6>
                            <input class='form-control' value='{model.Modelo}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Marca</h6>
                            <input class='form-control' value='{model.Marca}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Numero De Serie</h6>
                            <input class='form-control' value='{model.Numerodeserie}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Color</h6>
                            <input class='form-control' value='{model.Color}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Condicion</h6>
                            <input class='form-control' value='{model.Condicion}' disabled>
                        </div>
                    </div>
                    <div class='col-md-4'>
                        <div class='form-group'>
                            <h6>Observaciones</h6>
                            <input class='form-control' value='{model.Observaciones}' disabled>
                        </div>
                    </div>
                </div>
            </div>


        </body>
        </html>";
        }

        private suvar203 ObtenerModeloPorId(int id)
        {
            // Lógica para obtener el modelo por su id desde la base de datos
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return _contexto.suvar203s.Find(id);
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }



    }
}


    



