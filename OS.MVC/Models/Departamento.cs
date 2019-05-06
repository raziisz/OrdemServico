using System.Collections;
using System.Collections.Generic;

namespace OS.MVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
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
    }
}