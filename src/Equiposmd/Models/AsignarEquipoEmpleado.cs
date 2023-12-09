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
        public string Estado { get; set; }
        [Required(ErrorMessage = "La Ubicación Actual es obligatoria.")]
        public string Ubicación_Actual { get; set; }
        [Required(ErrorMessage = "La Asignación es obligatoria.")]
        public string Asignado { get; set; }
        [Required(ErrorMessage = "La Fecha de adquisición es obligatoria.")]
        public DateTime Fecha_de_Asignacion { get; set; }
    }
}
