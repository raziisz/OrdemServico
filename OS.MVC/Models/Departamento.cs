using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OS.MVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public ICollection<Funcionario> Funcionarios { get; set; }

        public Departamento()
        {
            
        }
        public Departamento(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public void AddFunc(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }
    }
}