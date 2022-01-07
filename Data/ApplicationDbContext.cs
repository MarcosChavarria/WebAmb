using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAmb.Models;

namespace WebAmb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAmb.Models.Genero> Genero { get; set; }
        public DbSet<WebAmb.Models.Paciente> Paciente { get; set; }
   
    }
}