using SiNoMA.Domain;
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

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.ID)
                .HasColumnName("USER_ID");

            //Informa as características para a propriedade ter no máximo 40 caracteres e é obrigatória e Muança no Nome.                        
            Property(x => x.Login)
                .HasMaxLength(40)
                .IsRequired()
                .HasColumnName("USER_Login");

            //Informa as características para a propriedade ter no máximo 40 caracteres e é obrigatória e Muança no Nome.            
            Property(x => x.Senha)
                .HasMaxLength(30)
                .IsRequired()
               .HasColumnName("USER_Senha");

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.UltimoAcesso)
                .HasColumnName("USER_UltimoAcesso");

            //Informa as características para a propriedade ter no máximo 40 caracteres e é obrigatória e Muança no Nome.            
            Property(x => x.Email)
                .HasMaxLength(40)
                .IsRequired()
                .HasColumnName("USER_Email");

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.Situacao)
                .HasColumnName("USER_Situacao");

            //Muda o nome do parâmetro na base de dados.
            Property(x => x.Administrador)
                .HasColumnName("USER_Administrador");
        }
    }
}
