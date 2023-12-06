using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Equiposmd.Models
{
    public class HistorialEvento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Numero_serial { get; set; }
        public int numero_de_activo { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoEvento { get; set; }
        public string Detalles { get; set; }
        public string EmpleadoAsignado { get; set; }
        public string AreaOrigen { get; set; }
        public string AreaDestino { get; set; }
        public string SoftwareInstalado { get; set; }
        public string DetallesMantenimiento { get; set; }
        public string DetallesReparacion { get; set; }
        public string DetallesModificacion { get; set; }
        public string CausaDaño { get; set; }
    }
}
