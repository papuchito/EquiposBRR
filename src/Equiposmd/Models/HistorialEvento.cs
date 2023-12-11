using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Equiposmd.Models
{
    public class HistorialEvento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Id Del Equipo es requerido")]
        public int Id_Equipo { get; set; }

        [Required(ErrorMessage = "El campo Numero_serial es requerido")]
        public string Numero_serial { get; set; }

        [Required(ErrorMessage = "El campo numero_de_activo es requerido")]
        public int numero_de_activo { get; set; }

        [Required(ErrorMessage = "El campo Fecha es requerido")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo TipoEvento es requerido")]
        public string TipoEvento { get; set; }

        [Required(ErrorMessage = "El campo Detalles es requerido")]
        public string Detalles { get; set; }

        [Required(ErrorMessage = "El campo EmpleadoAsignado es requerido")]
        public string EmpleadoAsignado { get; set; }

        [Required(ErrorMessage = "El campo AreaOrigen es requerido")]
        public string AreaOrigen { get; set; }

        [Required(ErrorMessage = "El campo AreaDestino es requerido")]
        public string AreaDestino { get; set; }

        [Required(ErrorMessage = "El campo SoftwareInstalado es requerido")]
        public string SoftwareInstalado { get; set; }

        [Required(ErrorMessage = "El campo DetallesMantenimiento es requerido")]
        public string DetallesMantenimiento { get; set; }

        [Required(ErrorMessage = "El campo DetallesReparacion es requerido")]
        public string DetallesReparacion { get; set; }

        [Required(ErrorMessage = "El campo DetallesModificacion es requerido")]
        public string DetallesModificacion { get; set; }

        [Required(ErrorMessage = "El campo CausaDaño es requerido")]
        public string CausaDaño { get; set; }
    }
}
