using SiNoMA_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //Informa as características para a propriedade Nome, tem no máximo 60 caracteres e é obrigatória.            
            Property(x => x.Nome).HasMaxLength(60).IsRequired();

            //Informa as características para a propriedade Descrisao, tem no máximo 60 caracteres e é obrigatória.            
            Property(x => x.Descrisao).HasMaxLength(60).IsRequired();
        }
    }
}
