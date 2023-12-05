
using Equiposmd.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Equiposmd.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        //modelos aqui
        public DbSet<Mequipo> mequipos { get; set; }
        public DbSet<RegistroIndividual> registroindividuals { get; set; }
        public DbSet<EquiposAsignados> equiposAsignados { get; set; }
        public DbSet<AsignarAreaEquipo> asignarAreaEquipos { get; set; }
        public DbSet<RegistrarMarcas> registrarMarcas { get; set; }
        public DbSet<HistorialEvento> historialEventos { get; set; }
        public DbSet<SolicitudEquipo> solicitudEquipos { get; set; }
        public DbSet<suvar203> suvar203s { get; set; }








    }
}