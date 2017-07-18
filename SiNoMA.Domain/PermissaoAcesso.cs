namespace SiNoMA.Domain
{
    public class PermissaoAcesso
    {
        public int PID { get; set; }

        public int SituacaoID { get; set; }

        public Operacao OperacaoID { get; set; }

        public Usuario UsuarioID { get; set; }

        public GrupoAcesso GrupoAcessoID { get; set; }
    }
}