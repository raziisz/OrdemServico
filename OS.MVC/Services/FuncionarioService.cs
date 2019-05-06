using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OS.MVC.Data;
using OS.MVC.Models;
using OS.MVC.Services.Exceptions;

namespace OS.MVC.Services
{
    public class FuncionarioService
    {
        private readonly OSMvcContext _context;
        public FuncionarioService(OSMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Funcionario>> FindAllFunc()
        {
            return await _context.Funcionario.Include(d => d.Departamento).ToListAsync();
        }

        public async Task<Funcionario> FindById( int id)
        {
            var func =  await _context.Funcionario.Include(d => d.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
            var ordemServicos = await _context.OrdemServico.Where(p => p.FuncionarioId == id).ToListAsync();
            foreach (var ordemServico in ordemServicos)
            {
                func.OrdemServicos.Add(ordemServico);
            }
            
            return func;
        }

        public async Task Remove (int id)
        {
            try
            {
            var obj = await _context.Funcionario.FindAsync(id);
            _context.Funcionario.Remove(obj);
            await _context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task AdicionarFunc (Funcionario obj)
        {
            await _context.AddAsync(obj);
            await _context.SaveChangesAsync();
        }
        
        public async Task AtualizarFunc(Funcionario obj)
        {
            bool hasAny = await _context.Funcionario.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try{
                _context.Update(obj);
                await _context.SaveChangesAsync();
            } 
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
        //DepartamentoServices Abaixo
        public async Task<List<Departamento>> FindAllDep()
        {
            return await _context.Departamento.OrderBy(x => x.Descricao).ToListAsync();
        }



        public async Task AdicionarDep (Departamento obj)
        {
            await _context.AddAsync(obj);
            await _context.SaveChangesAsync();
        }
    }
}