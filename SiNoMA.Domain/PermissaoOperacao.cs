namespace SiNoMA_MVC.Models
{
    public class PermissaoOperacao
    {
        public int PermissaoOperacaoID { get; set; }

        public Operacao OperacaoID { get; set; }

        public PermissaoAcesso PermissaoID { get; set; }
    }
}