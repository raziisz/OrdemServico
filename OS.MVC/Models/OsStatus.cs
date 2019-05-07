using System.ComponentModel.DataAnnotations;

namespace OS.MVC.Models
{
    public enum OsStatus : int
    {
        [Display(Name = "Em execução")]
        EmExecucao = 0,
        Iniciado = 1,
        Cancelado = 2,
        Finalizado = 3,
        Pausado = 4
    }
}