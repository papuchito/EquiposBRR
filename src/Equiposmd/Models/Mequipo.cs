using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Equiposmd.Models
{
    public class Mequipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "La Marca del equipo es obligatorio")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "El Modelo es obligatorio")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "La Color del equipo es obligatorio")]
        public string Color { get; set; }
        [Required(ErrorMessage = "La Condición del equipo es obligatorio")]
        public string Condicion { get; set; }
        [Required(ErrorMessage = "El Número de activo del equipo obligatorio")]
        public int Numero_de_activo { get; set; }
        [Required(ErrorMessage = "El número de identificación del equipo dentro del banco es obligatorio")]
        public string Numero_serial { get; set; }
        [Required(ErrorMessage = "La fecha de fabricacion es obligatorio")]
        public DateTime Fecha_fabricacion { get; set; }
        [Required(ErrorMessage = "La fecha de adquisicion es obligatorio")]
        public DateTime fecha_adquisicion { get; set; }
        [Required(ErrorMessage = "La Fecha de expiración de la primera garantía del equipo es obligatorio")]
        public DateTime Fecha_expiracion_garantia_1 { get; set; }
        [Required(ErrorMessage = "La Fecha de expiración de la segunda garantía del equipo es obligatorio")]
        public DateTime Fecha_expiracion_garantia_2 { get; set; }
        [Required(ErrorMessage = "La Fecha final de vida útil del equipo es obligatorio")]
        public DateTime Fecha_final_vida_util { get; set; }
        [Required(ErrorMessage = "LaFecha de descarte es obligatorio")]
        public DateTime Fecha_descarte { get; set; }
        [Required(ErrorMessage = "El Precio es obligatorio")]
        public int Precio { get; set; }
        [Required(ErrorMessage = "El Número de activo del equipo obligatorio")]
        public int Cantidad { get; set; }
    }
}
