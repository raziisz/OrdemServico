using System;
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
            return await _context.OrdemServico.Include(x => x.Funcionario).OrderBy(y => y.DataRegistro).ToListAsync();
        }
        public async Task<OrdemServico> FindById(int id)
        {
            var os = await _context.OrdemServico
            .Include(z => z.Funcionario.Departamento)
            .Include(x => x.Funcionario)
            .FirstOrDefaultAsync(y => y.Id == id);
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

        public async Task<List<OrdemServico>> FindByDate(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _context.OrdemServico select obj; //criando objeto do tipo Iqueryable para melhorar a consulta
            if (minDate.HasValue) 
            {
                resultado = resultado.Where(x => x.DataRegistro >= minDate.Value);
            }
            if(maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.DataRegistro <= maxDate.Value);
            }

            return await resultado
            .Include(f => f.Funcionario)
            .OrderByDescending(d => d.DataRegistro)
            .ToListAsync();
        }
        public async Task<List<IGrouping<Departamento,OrdemServico>>> FindByDateDep(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in _context.OrdemServico select obj; //criando objeto do tipo Iqueryable para melhorar a consulta
            if (minDate.HasValue) 
            {
                resultado = resultado.Where(x => x.DataRegistro >= minDate.Value);
            }
            if(maxDate.HasValue)
            {
                resultado = resultado.Where(x => x.DataRegistro <= maxDate.Value);
            }

            return await resultado
            .Include(f => f.Funcionario)
            .Include(d => d.Funcionario.Departamento)
            .OrderByDescending(d => d.DataRegistro)
            .GroupBy(x => x.Funcionario.Departamento)
            .ToListAsync();
        }
    }
}