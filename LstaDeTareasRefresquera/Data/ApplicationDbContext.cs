using ListaDeTareasRefresquera.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ListaDeTareasRefresquera.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Empleado> Empleados { get; set; }  
        public DbSet<Tarea> Tareas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}