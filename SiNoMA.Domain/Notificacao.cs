using System;
using System.Collections.Generic;

namespace SiNoMA.Domain
{
    public class Notificacao
    {
        public Notificacao()
        {
            Ativo = new Ativo();
            Usuario = new Usuario();
            TipoEnvio = new TipoEnvio();
        }

        public long ID { get; set; }
        public string Nome { get; set; }
        public virtual TipoEnvio TipoEnvio { get; set; }
        public DateTime DataParaEnvio { get; set; }
        public string Repeticao { get; set; }
        public string Mensagem { get; set; }
        public bool NotificacaoAtiva { get; set; }
        public virtual Ativo Ativo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<AndamentoNotificacao> AndamentosNotificacoes { get; set; }
    }
}