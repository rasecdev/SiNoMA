using SiNoMA.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    public class NotificacaoMapping : EntityTypeConfiguration<Notificacao>
    {
        public NotificacaoMapping()
        {
            // define o nome da tabela
            ToTable("Notificacao");

            // define o nome da coluna da tabela
            // define que a coluna seja autoincremente
            Property(x => x.ID)
                .HasColumnName("NOTI_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // define a chave primária
            HasKey(x => x.ID);

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.Nome)
                .HasColumnName("NOTI_Nome")
                .HasMaxLength(50)
                .IsRequired();

            // define o nome da coluna da tabela
            // define que o campo é obrigatório
            Property(x => x.DataParaEnvio)
                .HasColumnName("NOTI_DataParaEnvio")
                .IsRequired();

            // define o nome da coluna da tabela
            // defini o tipo da coluna como char
            // define que o campo é obrigatório   
            Property(x => x.Repeticao)
                .HasColumnName("NOTI_Repeticao")
                .HasColumnType("char")
                .HasMaxLength(2)
                .IsRequired();

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório   
            Property(x => x.Mensagem)
                .HasColumnName("NOTI_Mensagem")
                .HasMaxLength(400)
                .IsRequired();

            // define o nome da coluna da tabela
            Property(x => x.NotificacaoAtiva)
                .HasColumnName("NOTI_NotificacaoAtiva");

            // define um relacionamento deste tipo de entidade, neste caso é o Usuario
            HasRequired(x => x.Usuario) // uma Notificacao deve ter um Usuario associado a ele
                .WithMany(n => n.Notificacoes) // um Usuario pode ter muitas Notificações
                .Map(m => m.MapKey("USUA_ID")); // especifica o nome da coluna de chave estrangeira na tabela Notificação

            HasRequired(x => x.TipoEnvio)
                .WithMany()
                .Map(m => m.MapKey("TIEN_ID")); // especifica o nome da coluna de chave estrangeira na tabela TipoEnvio

            HasRequired(x => x.Ativo)
                .WithMany()
                .Map(m => m.MapKey("ATIV_ID")); // especifica o nome da coluna de chave estrangeira na tabela Ativo
        }
    }
}
