using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OS.Models.ViewModels;
using OS.MVC.Models;
using OS.MVC.Models.ViewModels;
using OS.MVC.Services;
using OS.MVC.Services.Exceptions;

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

        public async Task<IActionResult> Cancelar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não foi fornecido"});
            }

            var obj = await _ordemServicoService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não encontrado"});
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cancelar(int id, OrdemServico ordemServico)
        {
            if (id != ordemServico.Id)
            {
                return RedirectToAction(nameof(Error), new {message ="Id OS solicitado não correspondem"});
            }
            var os = await _ordemServicoService.FindById(ordemServico.Id);
            os.Status = Enum.Parse<OsStatus>("Cancelado");
            os.DataFinalizada = DateTime.Now;
            try
            {
                await _ordemServicoService.AtualizarOS(os);
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

        public async Task<IActionResult> Finalizar (int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não foi fornecido"});
            }

            var obj = await _ordemServicoService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não encontrado"});
            }

            return View(obj);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Finalizar(int id, OrdemServico ordemServico)
        {
            if (id != ordemServico.Id)
            {
                return RedirectToAction(nameof(Error), new {message ="Id OS solicitado não correspondem"});
            }
            var os = await _ordemServicoService.FindById(ordemServico.Id);
            os.Status = Enum.Parse<OsStatus>("Finalizado");
            os.DataFinalizada = DateTime.Now;
            try
            {
                await _ordemServicoService.AtualizarOS(os);
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

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não foi fornecido"});
            }
            var os = await _ordemServicoService.FindById(id.Value);
            if (os == null)
            {
                return RedirectToAction(nameof(Error), new {message ="Id não encontrado"});
            }
            return View(os);
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