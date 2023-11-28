using System.ComponentModel.DataAnnotations;

namespace Equiposmd.Models
{
    public class EquiposAsignados
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public int ID_del_Equipo { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string Condicion { get; set; }
        public string Modelo { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string Numero_de_serie { get; set; }
        public string Color { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public DateTime Fecha_de_fabricacion { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public DateTime Fecha_de_adquisicion { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string Ubicación_Actual { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string Asignado { get; set; }
    }
}
