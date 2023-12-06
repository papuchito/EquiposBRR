using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Equiposmd.Models
{
    public class AsignarEquipoEmpleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El ID del Equipo es obligatorio.")]
        public int ID_del_Equipo { get; set; }
        [Required(ErrorMessage = "El Tipo de Equipo es Obligatorio")]
        public string Tipo { get; set;}
        [Required(ErrorMessage = "La Marca es obligatoria.")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "La Condición es obligatoria.")]
        public string Condicion { get; set; }
        [Required(ErrorMessage = "El Modelo es obligatorio.")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "El Número de serie es obligatorio.")]
        public string Numero_de_serie { get; set; }
        [Required(ErrorMessage = "El Color del equipo es obligatorio.")]
        public string Color { get; set; }
        [Required(ErrorMessage = "La Fecha de fabricación es obligatoria.")]        
        public string Estado { get; set; }
        [Required(ErrorMessage = "La Ubicación Actual es obligatoria.")]
        public string Ubicación_Actual { get; set; }
        [Required(ErrorMessage = "La Asignación es obligatoria.")]
        public string Asignado { get; set; }
        [Required(ErrorMessage = "La Fecha de adquisición es obligatoria.")]
        public DateTime Fecha_de_Asignacion { get; set; }
    }
}
