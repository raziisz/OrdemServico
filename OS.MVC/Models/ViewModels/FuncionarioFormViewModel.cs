
using System.Collections.Generic;

namespace OS.MVC.Models.ViewModels
{
    public class FuncionarioFormViewModel
    {
        public Funcionario Funcionario { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}