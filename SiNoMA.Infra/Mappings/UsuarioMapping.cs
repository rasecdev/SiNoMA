using SiNoMA.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            // define o nome da tabela
            ToTable("Usuario");
            
            // define o nome da coluna da tabela
            // define que a coluna seja autoincremente
            Property(x => x.ID)
                .HasColumnName("USUA_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // define a chave primária
            HasKey(x => x.ID);

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.Nome)
                .HasColumnName("USUA_Nome")
                .HasMaxLength(60)
                .IsRequired();

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.Login)
                .HasColumnName("USUA_Login")
                .HasMaxLength(40)
                .IsRequired();

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.Senha)
                .HasColumnName("USUA_Senha")
                .HasMaxLength(30)
                .IsRequired();

            // relacionamento N:N, sendo um usuario possui N notificações, 
            // e uma notificação pode ser de um ou mais usuarios
            //HasMany(x => x.Notificacoes)
            //    .WithMany()
            //    .Map(m =>
            //    {
            //        m.MapLeftKey("USER_ID");
            //        m.MapRightKey("NOTI_ID");
            //        m.ToTable("UsuarioNotificacao");
            //    });

            //HasMany(x => x.Emails)
            //    .WithOptional()
            //    .Map(m => m.MapKey("USER_ID"));
            
        }
    }
}
