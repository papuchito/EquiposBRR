using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Equiposmd.Models
{
    public class suvar203
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "La Unidad Emisora es obligatoria.")]
        public string UnidadEmisora { get; set; }
        [Required(ErrorMessage = "El Código es obligatorio.")]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "La Fecha es obligatoria.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La Ubicación es obligatoria.")]
        public string Ubicacion { get; set; }
        [Required(ErrorMessage = "El Teléfono es obligatorio.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La Oficina es obligatoria.")]
        public string Oficina { get; set; }
        [Required(ErrorMessage = "El Código es obligatorio.")]

        public int CodigoReceptor { get; set; }


        [Required(ErrorMessage = "El Número de activo del equipo es obligatorio.")]
        public int Numero_de_activo { get; set; }

        [Required(ErrorMessage = "La Descripción del equipo es obligatoria.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Modelo del equipo es obligatorio.")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "La Marca del equipo es obligatoria.")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El Número de serie del equipo es obligatorio.")]
        public string Numerodeserie { get; set; }

        [Required(ErrorMessage = "El Color del equipo es obligatorio.")]
        public string Color { get; set; }

        [Required(ErrorMessage = "La Condición del equipo es obligatoria.")]
        public string Condicion { get; set; }

        [Required(ErrorMessage = "Las Observaciones del equipo son obligatorias.")]
        public string Observaciones { get; set; }
    }
}