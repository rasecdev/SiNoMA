using System;

namespace SiNoMA.Domain
{
    public class AndamentoNotificacao
    {
        public long ID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public virtual Notificacao Notificacao { get; set; }
    }
}
