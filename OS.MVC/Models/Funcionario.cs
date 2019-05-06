using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OS.MVC.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        [Required(ErrorMessage = "Preencher {0}")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Tamanho do {0} deve ser entre {2} a {1} caracteres")]
        public string Nome { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }

        [Required(ErrorMessage = "Preencher {0}")]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Tamanho do {0} deve ser entre {2} a {1} caracteres")]
        public string Cargo { get; set; }
        public ICollection<OrdemServico> OrdemServicos { get; set; }

        
    public Funcionario()
    {   
    }

    public Funcionario(int id, string login, string senha, string nome, string cargo, Departamento departamento)
    {
        Id = id;
        Login = login;
        Senha = senha;
        Nome = nome;
        Cargo = cargo;
        Departamento = departamento; 
    }

    
    }

}