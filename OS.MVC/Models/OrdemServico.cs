using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OS.MVC.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Tipo de Ordem")]
        public string TipoOrdem { get; set; }
        public OsStatus Status { get; set; }

        [Display(Name = "Data Registrada")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime DataRegistro { get; set; }

        [Display(Name = "Data Finalizada")]
        public DateTime DataFinalizada { get; set; }
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }
        public ICollection<Ferramenta> Ferramentas { get; set; }
        public OrdemServico()
        {
            
        }
        public OrdemServico(int id, string descricao, string tipoOrdem,  Funcionario funcionario)
        {
            Id = id;
            Descricao = descricao;
            TipoOrdem = tipoOrdem;
            Status = Enum.Parse<OsStatus>("Iniciado");
            DataRegistro = DateTime.Now;
            Funcionario = funcionario;
        }
    }


}