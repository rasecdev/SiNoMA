using SiNoMA.Infra.Mappings;
using SiNoMA_MVC.Models;
using System.Data.Entity;

namespace SiNoMA.Infra.DataContexts
{
    public class SiNoMAContext : DbContext
    {
        public SiNoMAContext() : base("SiNoMAConnectionString")
        {
            //Modifica o carregamento em demanda e não recupera a Category altomaticamente. 
            //Para incluir é feita uma configuração no controller.
            Configuration.LazyLoadingEnabled = false;

            //Configuração para os proxy, dessa maneira não serão criados os proxy para as classes e a serialização será
            //mais suave.
            Configuration.ProxyCreationEnabled = false;
        }

        //Usando a Interface IDbSet para não ocorrer erro na criação do controller no Web Api.
        public IDbSet<Ativo> Ativos { get; set; }

        public IDbSet<Notificacao> Notificacoes { get; set; }

        public IDbSet<Usuario> Usuarios { get; set; }

        //Método para inicializar na creação das tabelas as configurações dos mapeamentos.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AtivoMapping());

            modelBuilder.Configurations.Add(new NotificacaoMapping());

            modelBuilder.Configurations.Add(new UsuarioMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
