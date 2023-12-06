using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Equiposmd.Models
{
    public class RegistroIndividual
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public int Id_Equipo { get; set; }
        [Required(ErrorMessage = "El Tipo de equipo es obligatorio")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "La Marca del equipo es obligatoria")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El Modelo del equipo es obligatorio")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "El Número de activo del banco es obligatorio")]
        public int Número_de_activo_del_banco { get; set; }

        [Required(ErrorMessage = "El Número serial del equipo es obligatorio")]
        public string Número_serial_de_fábrica { get; set; }

        [Required(ErrorMessage = "El Estado del equipo es obligatorio")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "El Color del equipo es obligatorio")]
        public string Color { get; set; }

    }
}
