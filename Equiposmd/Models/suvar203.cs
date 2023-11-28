using System.ComponentModel.DataAnnotations;

namespace Equiposmd.Models
{
    public class suvar203
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string UnidadEmisora { get; set; }
        [Required(ErrorMessage = "La Marca del equipo es obligatorio")]
        public string Ubicacion { get; set; }
        [Required(ErrorMessage = "El Iddelequipo es obligatorio")]
        public string Oficina { get; set; }
        [Required(ErrorMessage = "La Color del equipo es obligatorio")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "La Condición del equipo es obligatorio")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El Precio es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Número de activo del equipo obligatorio")]
        public int Numero_de_activo { get; set; }
        [Required(ErrorMessage = "El número de identificación del equipo dentro del banco es obligatorio")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "LaFecha de fabricacion es obligatorio")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "La fecha de adquisicion es obligatorio")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "La Fecha de expiración de la primera garantía del equipo es obligatorio")]
        public string Numerodeserie { get; set; }
        [Required(ErrorMessage = "La Fecha de expiración de la segunda garantía del equipo es obligatorio")]
        public string color { get; set; }
        [Required(ErrorMessage = "La Fecha final de vida útil del equipo es obligatorio")]
        public string Condicion { get; set; }
        [Required(ErrorMessage = "LaFecha de descarte es obligatorio")]
        public string Observaciones { get; set; }       
    }
}
