using SiNoMA.Domain;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    public class TipoEnvioMapping : EntityTypeConfiguration<TipoEnvio>
    {
        public TipoEnvioMapping()
        {
            // define o nome da tabela
            ToTable("TipoEnvio");

            // define o nome da coluna da tabela
            // define que a coluna seja autoincremente
            Property(x => x.ID)
                .HasColumnName("TIEN_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            // define a chave primária
            HasKey(x => x.ID);

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.Nome)
                .HasColumnName("TIEN_Nome")
                .HasMaxLength(60)
                .IsRequired();

            // define o nome da coluna da tabela
            // define tamanho máximo do campo
            // define que o campo é obrigatório
            Property(x => x.Descricao)
                .HasColumnName("TIEN_Descricao")
                .HasMaxLength(200)
                .IsRequired();
        }
        
    }
}
