namespace OS.MVC.Models
{
    public class Ferramenta
    {
        public int Id { get; set; }
        public int Quantidade_Estoque { get; set; }
        public int Quantidade_Reservada { get; set; }
        public OrdemServico OrdemServico { get; set; }
        public int OrdemServicoId { get; set; }
        public string Descricao { get; set; }

        public Ferramenta()
        {

        }        
        public Ferramenta(int id, int quantidade_Estoque, int quantidade_Reservada, OrdemServico ordemServico, string descricao)
        {
            Id = id;
            Quantidade_Estoque = quantidade_Estoque - quantidade_Reservada;
            Quantidade_Reservada = quantidade_Reservada;
            OrdemServico = ordemServico;
            Descricao = descricao;

        }
    }


}