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
    }
}