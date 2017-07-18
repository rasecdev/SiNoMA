namespace SiNoMA.Domain
{
    public class GrupoAcesso
    {
        public int ID { get; set; }

        public string Descricao { get; set; }

        public Usuario UsuarioID { get; set; }
    }
}