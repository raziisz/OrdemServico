using Microsoft.EntityFrameworkCore;
using OS.Models;
using OS.MVC.Models;

namespace OS.MVC.Data
{
    public class OSMvcContext : DbContext
    {
        public OSMvcContext (DbContextOptions<OSMvcContext> options)
            : base(options)
        {

        }

        public DbSet<Funcionario> Funcionario {get; set;}
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Ferramenta> Ferramenta { get; set; }
        public DbSet<OrdemServico> OrdemServico { get; set; }
        
    }
}