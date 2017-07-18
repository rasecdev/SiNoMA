namespace SiNoMA.Domain
{
    public class PermissaoOperacao
    {
        public int PermissaoOperacaoID { get; set; }

        public Operacao OperacaoID { get; set; }

        public PermissaoAcesso PermissaoID { get; set; }
    }
}