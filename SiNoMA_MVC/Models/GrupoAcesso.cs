namespace SiNoMA_MVC.Models
{
    public class GrupoAcesso
    {
        public int GrupoID { get; set; }

        public string Descricao { get; set; }

        public Usuario UsuarioID { get; set; }
    }
}