namespace SiNoMA_MVC.Models
{
    public class Operacao
    {
        public int OperacaoID { get; set; }

        public string Descricao { get; set; }

        public int Incluir { get; set; }

        public int Alterar { get; set; }

        public int Excluir { get; set; }

        public int Visualizar { get; set; }
    }
}