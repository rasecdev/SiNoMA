using System;

namespace SiNoMA.Domain
{
    public class AndamentoNotificacao
    {
        public Notificacao Notificacao { get; set; }

        public string Descrisao { get; set; }

        public DateTime DataHora { get; set; }

        public bool Enviada { get; set; }

        public bool Recebida { get; set; }
    }
}
