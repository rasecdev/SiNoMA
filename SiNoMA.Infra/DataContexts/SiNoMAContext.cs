using SiNoMA.Domain;
using SiNoMA.Infra.Mappings;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SiNoMA.Infra.DataContexts
{
    public class SiNoMAContext : DbContext
    {
        public SiNoMAContext() : base("SiNoMAConnectionString")
        {
            // mecanismo faz com que o Entity Framework carregue automaticamente os 
            // relacionamentos em memória, o que pode causar perda de performance ao 
            // fazer um select na base de dados, quando essa opção é desabilitada 
            // (deixado como false), ele não carrega as dependências automaticamente
            // e quando for necessário carregar, basta usar o método Include()
            Configuration.LazyLoadingEnabled = false;

            // o Entity Framework por padrão cria um proxy toda vez que é instanciado 
            // uma entidade POCO para que possa ser realizado eventuais mudanças e fazer 
            // o carregamento automático das propriedades virtuais, como não estamos 
            // usando o Lazy Loading habilitado, não tem muito sentido manter a criação de 
            // proxy habilitada também
            Configuration.ProxyCreationEnabled = false;
        }

        // usando a interface IDbSet para não ocorrer erro na criação do controller no Web Api.
        // mapeamento das tabelas do banco de dados nas entidades POCO (Plain Old CLR Object) 
        public IDbSet<AndamentoNotificacao> AndamentosNotificacoes { get; set; }
        public IDbSet<Ativo> Ativos { get; set; }
        public IDbSet<Email> Emails { get; set; }
        public IDbSet<Notificacao> Notificacoes { get; set; }
        public IDbSet<TipoEnvio> TiposEnvio { get; set; }
        public IDbSet<Usuario> Usuarios { get; set; }

        // método para inicializar na criação das tabelas as configurações dos mapeamentos.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // aqui vamos remover a pluralização padrão do Etity Framework que é em inglês
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // desabilitamos o delete em cascata em relacionamentos 1:N evitando
            // ter registros filhos sem registros pai
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // basicamente a mesma configuração acima, porém em relacionamenos N:N
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // toda propriedade do tipo string na entidade POCO
            // seja configurado como VARCHAR no SQL Server
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new AndamentoNotificacaoMapping());
            modelBuilder.Configurations.Add(new AtivoMapping());
            modelBuilder.Configurations.Add(new NotificacaoMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
            modelBuilder.Configurations.Add(new TipoEnvioMapping());
            modelBuilder.Configurations.Add(new EmailMapping());
            //base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<SiNoMA.Domain.Ativo> Ativoes { get; set; }

        public System.Data.Entity.DbSet<SiNoMA.Domain.AndamentoNotificacao> AndamentoNotificacaos { get; set; }

        public System.Data.Entity.DbSet<SiNoMA.Domain.Notificacao> Notificacaos { get; set; }

        public System.Data.Entity.DbSet<SiNoMA.Domain.TipoEnvio> TipoEnvios { get; set; }
    }
}
