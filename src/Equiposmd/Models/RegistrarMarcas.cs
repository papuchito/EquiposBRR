using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Equiposmd.Models
{
    public class RegistrarMarcas
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La Marca del equipo es obligatorio")]
        public string Marca { get; set; }
        

    }
}
