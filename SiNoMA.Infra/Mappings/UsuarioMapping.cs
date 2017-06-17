using SiNoMA_MVC.Models;
using System.Data.Entity.ModelConfiguration;

namespace SiNoMA.Infra.Mappings
{
    class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            //Inforam qual será o nome da tabela.
            ToTable("Usuario");

            //Informa qual será a chave primária.
            HasKey(x => x.ID);

            //Informa as características para a propriedade ter no máximo 40 caracteres e é obrigatória.            
            Property(x => x.Login).HasMaxLength(40).IsRequired();

            //Informa as características para a propriedade ter no máximo 30 caracteres e é obrigatória.            
            Property(x => x.Senha).HasMaxLength(30).IsRequired();

            //Informa as características para a propriedade ter no máximo 40 caracteres e é obrigatória.            
            Property(x => x.Email).HasMaxLength(40).IsRequired();
        }
    }
}
