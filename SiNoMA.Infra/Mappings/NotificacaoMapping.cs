using SiNoMA_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //Informa as características para a propriedade ter no máximo 200 caracteres e é obrigatória.
            Property(x => x.Mensagem).HasMaxLength(200).IsRequired();

            //Informa as características para a propriedade ter no máximo 50 caracteres e é obrigatória.
            Property(x => x.Nome).HasMaxLength(50).IsRequired();
            
        }
    }
}
