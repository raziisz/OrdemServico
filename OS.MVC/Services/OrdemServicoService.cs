using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OS.MVC.Data;
using OS.MVC.Models;
using OS.MVC.Services.Exceptions;

namespace OS.MVC.Services
{
    public class OrdemServicoService
    {
        private readonly OSMvcContext _context;
        public OrdemServicoService(OSMvcContext context)
        {
            _context = context;

        }

        public async Task<List<OrdemServico>> FindAllOS()
        {
            return await _context.OrdemServico.Include(x => x.Funcionario).ToListAsync();
        }
        public async Task<OrdemServico> FindById(int id)
        {
            var os = await _context.OrdemServico.Include(x => x.Funcionario).FirstOrDefaultAsync(y => y.Id == id);
            return os;
        }
        public async Task Remove (int id)
        {
            var obj = await _context.OrdemServico.FindAsync(id);
            _context.OrdemServico.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task AdicionarOS (OrdemServico obj)
        {
            await _context.AddAsync(obj);
            await _context.SaveChangesAsync();
        }
        
        public async Task AtualizarOS(OrdemServico obj)
        {
            bool hasAny = await _context.OrdemServico.AnyAsync(x => x.Id == obj.Id);
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
    }
}