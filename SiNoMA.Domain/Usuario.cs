using System;
using System.Collections.Generic;

namespace SiNoMA.Domain
{
    public class Usuario
    {
        public Usuario()
        {
            Notificacoes = new List<Notificacao>();
            Emails = new List<Email>();
        }

        public long ID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<Ativo> Ativos { get; set; }
        public virtual ICollection<Notificacao> Notificacoes { get; set; }
        //public virtual ICollection<AndamentoNotificacao> AndamentosNotificacoes { get; set; }

    }
}