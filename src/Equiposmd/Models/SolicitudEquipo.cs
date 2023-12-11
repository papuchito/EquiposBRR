using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Equiposmd.Models
{
    public class SolicitudEquipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El área solicitada es obligatoria.")]
        public string Areasolicitada { get; set; }

        [Required(ErrorMessage = "El tipo de equipo es obligatorio.")]
        public string TipoEquipo { get; set; }

        [Required(ErrorMessage = "El procesador es obligatorio.")]
        public string Procesador { get; set; }

        [Required(ErrorMessage = "La memoria RAM es obligatoria.")]
        public string MemoriaRam { get; set; }

        [Required(ErrorMessage = "El disco duro es obligatorio.")]
        public string DiscoDuro { get; set; }

        [Required(ErrorMessage = "La tarjeta gráfica es obligatoria.")]
        public string TarjetaGrafica { get; set; }

        [Required(ErrorMessage = "La marca es obligatoria.")]
        public string Marca { get; set; }
    }
}
