using SiNoMA.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    class NotificacaoMapping : EntityTypeConfiguration<Notificacao>
    {
        public NotificacaoMapping()
        {
            //Inforam qual será o nome da tabela.
            ToTable("Notificacao");

            //Informa qual será a chave primária.
            HasKey(x => x.ID);

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.ID)
                .HasColumnName("NOTI_ID");

            //Informa as características para a propriedade ter no máximo 40 caracteres e é obrigatória e Muança no Nome.            
            Property(x => x.Nome)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("NOTI_Nome");

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.TipoEnvio)
                .HasColumnName("NOTI_TipoEnvio");

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.DataParaEnvio)
                .HasColumnName("NOTI_DataParaEnvio");

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.Repeticao)
                .HasColumnName("NOTI_Repeticao");

            //Informa as características para a propriedade ter no máximo 40 caracteres e é obrigatória e Muança no Nome.            
            Property(x => x.Mensagem)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnName("NOTI_Mensagem");

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.StatusEnvio)
                .HasColumnName("NOTI_StatusEnvio");

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.StatusRecebido)
                .HasColumnName("NOTI_StatusRecebido");

        }
    }
}
