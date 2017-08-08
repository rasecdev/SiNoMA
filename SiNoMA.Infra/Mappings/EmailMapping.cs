using SiNoMA.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    public class EmailMapping : EntityTypeConfiguration<Email>
    {
        public EmailMapping()
        {
            // define o nome da tabela
            ToTable("Email");

            // define o nome da coluna da tabela
            // define que a coluna seja autoincremente
            Property(x => x.ID)
                .HasColumnName("EMAI_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // define a chave primária
            HasKey(x => x.ID);

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.DescricaoEmail)
                .HasColumnName("EMAI_DescricaoEmail")
                .HasMaxLength(150)
                .IsRequired();

            // define um relacionamento deste tipo de entidade, neste caso é o Usuario
            HasRequired(x => x.Usuario) // um Email deve ter um Usuario associado a ele
                .WithMany(c => c.Emails) // um Usuario pode ter muitos Emails
                .Map(m => m.MapKey("USUA_ID")); // especifica o nome da coluna de chave estrangeira na tabela Email
        }
    }
}
