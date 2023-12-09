using DinkToPdf;
using DinkToPdf.Contracts;
using Equiposmd.Datos;
using Equiposmd.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Diagnostics.Contracts;


namespace Equiposmd.Controllers
{
    public class AreaGeneralController : Controller
    {
        private readonly IConverter _converter;

        private readonly ApplicationDbContext _contexto;
        public AreaGeneralController(IConverter converter, ApplicationDbContext contexto)
        {
            _converter = converter;

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
                                || s.Area_Asignada.Contains(searchString)
                    )
                    .ToList();
            }

            return View(asignarAreaEquipo);
        }
        [HttpPost]
        public async Task<IActionResult> TrasladarEquipo(TrasladarEquipo trasladarEquipo)
        {
            if (ModelState.IsValid)
            {
                _contexto.trasladarEquipo.Add(trasladarEquipo);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(SolicitudTraslado));
            }
            return View(trasladarEquipo);
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
        public IActionResult TrasladarEquipo()
        {
            return View();
        }
       
        public IActionResult DetalleTraslado(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var TrasladarEquipo = _contexto.trasladarEquipo.Find(id);
            if (TrasladarEquipo == null)
            {
                return NotFound();
            }
            return View(TrasladarEquipo);
        }
         public IActionResult ImprimirTraslado(int id)
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
        string nombrePDF = $"Reporte Traslado De Equipo_{id}.pdf";

        return File(archivoPDF, "application/pdf", nombrePDF);
          }
       
        public IActionResult DescargarPDF([Bind("UnidadEmisora, Codigo, Fecha, Ubicacion, Telefono, Oficina, CodigoReceptor, Numero_de_activo, Descripcion, Modelo, Marca, Numerodeserie, Color, Condicion, Observaciones")] TrasladarEquipo model)
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
            string nombrePDF = "reporte_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            return File(archivoPDF, "application/pdf", nombrePDF);
        }

        private string ObtenerContenidoPDF(TrasladarEquipo model)
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

        private TrasladarEquipo ObtenerModeloPorId(int id)
        {
            // Lógica para obtener el modelo por su id desde la base de datos
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return _contexto.trasladarEquipo.Find(id);
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }
    }
}
