using System.Collections.Generic;

namespace OS.MVC.Models.ViewModels
{
    public class OSFormViewModel
    {
        public OrdemServico OrdemServico { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}