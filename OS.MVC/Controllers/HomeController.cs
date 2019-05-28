using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OS.Models.ViewModels;
using OS.MVC.Models;
using OS.MVC.Models.ViewModels;
using OS.MVC.Services;

namespace OS.Controllers
{
    public class HomeController : Controller
    {
        public FuncionarioService _funcionarioService { get; }
        public HomeController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;

        }
        public  IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Verify(Funcionario func)
        {
            var funcDB = _funcionarioService.Login(func);
            if (funcDB != null) 
            {
                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Login));
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Analise e projeto de Sistemas";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}