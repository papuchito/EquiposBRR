using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Equiposmd.Models
{
    public class AsignarAreaEquipo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Required(ErrorMessage = "El Tipo de equipo es obligatorio.")]
            public int Id_Equipo { get; set; }

            [Required(ErrorMessage = "El Número de serie es obligatorio.")]
            public string Numero_serial { get; set; }

            [Required(ErrorMessage = "El Número activo del banco es obligatorio.")]
            public int Numero_activo_del_banco { get; set; }

            [Required(ErrorMessage = "El Área asignada es obligatoria.")]
            public string Area_Asignada { get; set; }

            [Required(ErrorMessage = "El Tipo es obligatorio.")]
            public string Tipo { get; set; }

            [Required(ErrorMessage = "La Marca es obligatoria.")]
            public string Marca { get; set; }
        }

    }

