using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OS.MVC.Models;
using OS.MVC.Services;

namespace OS.MVC.Controllers
{
    public class DepartamentosController : Controller
    {
        private readonly FuncionarioService _funcionarioService;
        public DepartamentosController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;

        }
        public async Task<IActionResult> Index()
        {
            var lista = await _funcionarioService.FindAllDep();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Departamento departamento)
        {
            await _funcionarioService.AdicionarDep(departamento);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details()
        {
            var lista = await _funcionarioService.FindAllDep();
            return View(lista);
        }
    }
}