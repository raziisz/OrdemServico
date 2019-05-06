using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OS.MVC.Models;
using OS.MVC.Models.ViewModels;
using OS.MVC.Services;

namespace OS.MVC.Controllers
{
    public class OrdemServicosController : Controller
    {
        private readonly OrdemServicoService _ordemServicoService;
        private readonly FuncionarioService _funcionarioService;
        public OrdemServicosController(OrdemServicoService ordemServicoService, FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
            _ordemServicoService = ordemServicoService;

        }

        public async Task<IActionResult> Index()
        {
            var lista = await _ordemServicoService.FindAllOS();
            return View(lista);
        }

        public async Task<IActionResult> Create()
        {
            var funcionarios = await _funcionarioService.FindAllFunc();
            var viewModel = new OSFormViewModel {Funcionarios = funcionarios};
            return View(viewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrdemServico ordemServico)
        {
            await _ordemServicoService.AdicionarOS(ordemServico);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> PesquisarDatas(DateTime? minDate, DateTime? maxDate)
        {
            if(!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if(!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _ordemServicoService.FindByDate(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> GrupoDepartamento(DateTime? minDate, DateTime? maxDate)
        {
            if(!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if(!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _ordemServicoService.FindByDateDep(minDate, maxDate);
            return View(result);
        }
    }
}