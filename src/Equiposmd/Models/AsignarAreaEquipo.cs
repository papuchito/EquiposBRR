using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Equiposmd.Models
{
    public class AsignarAreaEquipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Tipo de equipo es obligatorio.")]
        public int Id_Equipo { get; set; }

        [Required(ErrorMessage = "El Área asignada es obligatoria.")]
        public string Area_Asignada { get; set; }
    }
}
