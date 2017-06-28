using SiNoMA_MVC.Models;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    public class AtivoMapping : EntityTypeConfiguration<Ativo>
    {
        public AtivoMapping()
        {
            //Inforam qual será o nome da tabela.
            ToTable("Ativo");

            //Informa qual será a chave primária.
            HasKey(x => x.ID);

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.ID)
                .HasColumnName("ATIV_ID");

            //Informa as características para a propriedade ter no máximo 40 caracteres e é obrigatória e Muança no Nome.                       
            Property(x => x.Nome)
                .HasMaxLength(60)
                .IsRequired()
                .HasColumnName("ATIV_Nome");

            //Informa as características para a propriedade ter no máximo 40 caracteres e é obrigatória e Muança no Nome.                       
            Property(x => x.Descrisao)
                .HasMaxLength(60)
                .IsRequired()
                .HasColumnName("ATIV_Descrisao"); ;
        }
    }
}
