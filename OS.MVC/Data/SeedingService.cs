using System.Linq;
using OS.MVC.Models;

namespace OS.MVC.Data
{
    public class SeedingService
    {
        public OSMvcContext _context { get; }
        public SeedingService(OSMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Funcionario.Any() || _context.Departamento.Any()
                    || _context.OrdemServico.Any() || _context.Ferramenta.Any())
            {
                return; //DB ja foi populado
            }
            
            Departamento d1 = new Departamento(1, "TI");
            Departamento d2 = new Departamento(2, "Programação");
            Departamento d3 = new Departamento(3, "Manutenção");
            Departamento d4 = new Departamento(4, "Serviços");

            Funcionario f1 = new Funcionario(1, "Felipe", "password", "Luiz Felipe", "TI", d1);       
            Funcionario f2 = new Funcionario(2, "Jack", "password", "Jack Chan", "Suporte", d1); 
            Funcionario f3 = new Funcionario(3, "Lola", "password", "Lola Queiroga", "Programador", d2); 
            Funcionario f4 = new Funcionario(4, "Ronaldo", "password", "Ronaldo Fenomeno", "Analista",d2);

            OrdemServico o1 = new OrdemServico(1, "Corrigir um BUG do codigo", "Programação", f3);
            OrdemServico o2 = new OrdemServico(2, "Auxiliar na manutenão do pc", "Suporte", f2);
            OrdemServico o3 = new OrdemServico(3, "Levantar requesitos para Sistema X", "TI", f4);
            OrdemServico o4 = new OrdemServico(4, "Consertar impressora", "Suporte", f2);
            OrdemServico o5 = new OrdemServico(5, "Melhorar tela de sistemas", "Programação", f3);
            OrdemServico o6 = new OrdemServico(6, "Montar diagrama de classe", "TI", f1);
            OrdemServico o7 = new OrdemServico(7, "Analisar programa", "TI", f1);

            Ferramenta fe1 = new Ferramenta(1, 10, 1, o1, "Alicate");
            Ferramenta fe2 = new Ferramenta(2, 5, 1, o2, "CD-ROM de Instalação");





            _context.Funcionario.AddRange(f1,f2,f3,f4);
            _context.Departamento.AddRange(d1,d2,d3,d4);
            _context.OrdemServico.AddRange(o1,o2,o3,o4,o5,o6,o7);
            _context.Ferramenta.AddRange(fe1,fe2);

            _context.SaveChanges();

        }


    }
}