using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OS.Models.ViewModels;
using OS.MVC.Data;
using OS.MVC.Models;
using OS.MVC.Models.ViewModels;
using OS.MVC.Services;
using OS.MVC.Services.Exceptions;

namespace OS.MVC.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly FuncionarioService _funcionarioService;
        public FuncionariosController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;

        }
        public async Task<IActionResult> Index()
        {
            var lista = await _funcionarioService.FindAllFunc();
            return View(lista);
        }

        public async Task<IActionResult> Create()
        {
            var departamentos = await _funcionarioService.FindAllDep();
            var viewModel = new FuncionarioFormViewModel {Departamentos = departamentos};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Funcionario funcionario)
        {

            if (!ModelState.IsValid)
            {
                var departamentos = await _funcionarioService.FindAllDep();
                var viewModel = new FuncionarioFormViewModel {Funcionario = funcionario, Departamentos = departamentos};
                return View(viewModel);
            }
            await _funcionarioService.AdicionarFunc(funcionario);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não foi fornecido"});
            }

            var obj = await _funcionarioService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não encontrado"});
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _funcionarioService.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch(IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new {message = e.Message});
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não foi fornecido"});
            }

            var obj = await _funcionarioService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não encontrado"});
            }
            
            return View(obj);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não foi fornecido"});
            }

            var obj = await _funcionarioService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não encontrado"});
            }

            var departamentos = await _funcionarioService.FindAllDep();
            FuncionarioFormViewModel viewModel = new FuncionarioFormViewModel {
                    Funcionario = obj, Departamentos = departamentos};

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Funcionario funcionario)
        {
            if (!ModelState.IsValid)
            {
                var departamentos = await _funcionarioService.FindAllDep();
                var viewModel = new FuncionarioFormViewModel {Funcionario = funcionario, Departamentos = departamentos};
                return View(viewModel);
            }
            if (id != funcionario.Id)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não correspondem"});
            }

            try
            {
                await _funcionarioService.AtualizarFunc(funcionario);
                return RedirectToAction(nameof(Index));
            }
            catch(NotFoundException e) 
            {
                return RedirectToAction(nameof(Error), new {message = e.Message});
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), new {message = e.Message});
            }
            
        }

        public IActionResult Error (string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}