using System;
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
            
            // Departamento d1 = new Departamento(1, "TI");
            // Departamento d2 = new Departamento(2, "Programação");
            // Departamento d3 = new Departamento(3, "Manutenção");
            // Departamento d4 = new Departamento(4, "Serviços");

            // Funcionario f1 = new Funcionario(1, "Felipe", "password", "Luiz Felipe", "TI", d1);       
            // Funcionario f2 = new Funcionario(2, "Jack", "password", "Jack Chan", "Suporte", d1); 
            // Funcionario f3 = new Funcionario(3, "Lola", "password", "Lola Queiroga", "Programador", d2); 
            // Funcionario f4 = new Funcionario(4, "Ronaldo", "password", "Ronaldo Fenomeno", "Analista",d2);
            // Funcionario f5 = new Funcionario(5, "Tio da Limpeza", "password", "Tio da Limpeza", "Serviço Gerais",d4);
            // Funcionario f6 = new Funcionario(6, "Geraldo", "password", "Geraldo", "Tecnico em refrigeração",d3);
            // Funcionario f7 = new Funcionario(7, "Joelson", "password", "Joelson Fenomeno", "Eletricista",d3);
            // Funcionario f8 = new Funcionario(8, "Zuleide", "password", "Zuleide", "Serviços Gerais",d4);

            // OrdemServico o1 = new OrdemServico(1, "Corrigir um BUG do codigo", "Programação", OsStatus.Iniciado, new DateTime(2019, 02, 03), f3);
            // OrdemServico o2 = new OrdemServico(2, "Auxiliar na manutenão do pc", "Suporte", OsStatus.EmExecucao, new DateTime(2019, 03, 01), f2);
            // OrdemServico o3 = new OrdemServico(3, "Levantar requesitos para Sistema X", "TI",OsStatus.Finalizado, new DateTime(2019, 01, 10), f4);
            // OrdemServico o4 = new OrdemServico(4, "Consertar impressora", "Suporte", OsStatus.Iniciado, new DateTime(2019, 04, 20), f2);
            // OrdemServico o5 = new OrdemServico(5, "Melhorar tela de sistemas", "Programação", OsStatus.Pausado, new DateTime(2019, 04, 30), f3);
            // OrdemServico o6 = new OrdemServico(6, "Montar diagrama de classe", "TI", OsStatus.Iniciado, new DateTime(2019, 05, 01), f1);
            // OrdemServico o7 = new OrdemServico(7, "Analisar programa", "TI", OsStatus.EmExecucao, new DateTime(2019, 04, 25), f1);
            // OrdemServico o8 = new OrdemServico(8, "Limpeza total setor X", "Serviço", OsStatus.EmExecucao, new DateTime(2019, 04, 30), f5);
            // OrdemServico o9 = new OrdemServico(9, "Limpeza dos tetos de setor X", "Serviço", OsStatus.Iniciado, new DateTime(2019, 05, 4), f5);
            // OrdemServico o10 = new OrdemServico(10, "Lavação do pátio da empresa", "Serviço", OsStatus.Finalizado, new DateTime(2019, 04, 30), f5);
            // OrdemServico o11 = new OrdemServico(11, "Limpeza sala X", "Serviço", OsStatus.Finalizado, new DateTime(2019, 04, 28), f5);
            // OrdemServico o12 = new OrdemServico(12, "Limpeza das cadeiras da empresa", "Serviço", OsStatus.EmExecucao, new DateTime(2019, 04, 30), f5);
            // OrdemServico o13 = new OrdemServico(13, "Limpar ar-condicionados andar 1", "Manutenção", OsStatus.EmExecucao, new DateTime(2019, 05, 06), f6);
            // OrdemServico o14 = new OrdemServico(14, "Concertar ar-condicionado de setor X", "Manutenção", OsStatus.Iniciado, new DateTime(2019, 05, 07), f6);
            // OrdemServico o15 = new OrdemServico(15, "Instalação de refrigerador do Servidor", "Manutenção", OsStatus.EmExecucao, new DateTime(2019, 05, 08), f6);
            // OrdemServico o16 = new OrdemServico(16, "Instalação de ar-condicionado para setor X", "Manutenção", OsStatus.Cancelado, new DateTime(2019, 05, 01), f6);
            // OrdemServico o17 = new OrdemServico(17, "Instalação de refrigerador", "Manutenção", OsStatus.Cancelado, new DateTime(2019, 05, 02), f6);
            // OrdemServico o18 = new OrdemServico(18, "Trocar força do sistema eletrico x", "Manutenção", OsStatus.Iniciado, new DateTime(2019, 04, 28), f7);
            // OrdemServico o19 = new OrdemServico(19, "Trocar tomadas do setor X", "Manutenção", OsStatus.EmExecucao, new DateTime(2019, 05, 07), f7);
            // OrdemServico o20 = new OrdemServico(20, "Instalar novas tomadas em setor X", "Manutenção", OsStatus.Finalizado, new DateTime(2019, 04, 30), f7);
            // OrdemServico o21 = new OrdemServico(21, "Trocar fios de energia de setor X", "Manutenção", OsStatus.Pausado, new DateTime(2019, 05, 03), f7);
            // OrdemServico o22 = new OrdemServico(22, "Trocar lampadas quebradas do setor X", "Manutenção", OsStatus.EmExecucao, new DateTime(2019, 05, 07), f7);
            // OrdemServico o23 = new OrdemServico(23, "Limpeza completa setor X", "Serviços", OsStatus.Iniciado, new DateTime(2019, 05, 05), f8);
            // OrdemServico o24 = new OrdemServico(24, "Limpeza completa setor Y", "Serviços", OsStatus.EmExecucao, new DateTime(2019, 05, 05), f8);
            // OrdemServico o25 = new OrdemServico(25, "Limpeza completa setor Z", "Serviços", OsStatus.Pausado, new DateTime(2019, 05, 06), f8);
            // OrdemServico o26 = new OrdemServico(26, "Limpeza completa setor A", "Serviços", OsStatus.Cancelado, new DateTime(2019, 05, 08), f8);
            // OrdemServico o27 = new OrdemServico(27, "Limpeza completa setor B", "Serviços", OsStatus.EmExecucao, new DateTime(2019, 05, 06), f8);


            // Ferramenta fe1 = new Ferramenta(1, 10, 1, o1, "Alicate");
            // Ferramenta fe2 = new Ferramenta(2, 5, 1, o2, "CD-ROM de Instalação");





            // _context.Funcionario.AddRange(f1,f2,f3,f4,f5,f6,f7,f8);
            // _context.Departamento.AddRange(d1,d2,d3,d4);
            // _context.OrdemServico.AddRange(o1,o2,o3,o4,o5,o6,o7,o8,o9,o10,o11,o12,o13,o14,o15,o16,o17,o18,o19,o20,o21,o22,o23,o24,o25,o26,o27);
            // _context.Ferramenta.AddRange(fe1,fe2);

            // _context.SaveChanges();

        }


    }
}