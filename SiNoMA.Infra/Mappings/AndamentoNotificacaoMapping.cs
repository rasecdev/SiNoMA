using SiNoMA.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    public class AndamentoNotificacaoMapping : EntityTypeConfiguration<AndamentoNotificacao>
    {
        public AndamentoNotificacaoMapping()
        {
            // define o nome da tabela
            ToTable("AndamentoNotificacao");

            // define o nome da coluna da tabela
            // define que a coluna seja autoincremente
            Property(x => x.ID)
                .HasColumnName("ANNO_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // define a chave primária
            HasKey(x => x.ID);

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.Descricao)
                .HasColumnName("ANNO_Descricao")
                .HasMaxLength(500)
                .IsRequired();

            // define o nome da coluna da tabela
            // define que o campo é obrigatório
            Property(x => x.DataHora)
                .HasColumnName("ANNO_DataHora")
                .IsRequired();

            // define um relacionamento deste tipo de entidade, neste caso é a Notificação
            HasRequired(x => x.Notificacao) // um AndamentoNotificação deve ter uma Notificação associado a ele
                .WithMany(c => c.AndamentosNotificacoes) // um Notificação pode ter muitos AndamentosNotificações
                .Map(m => m.MapKey("NOTI_ID")); // especifica o nome da coluna de chave estrangeira na tabela Notificação
        }
    }
}
