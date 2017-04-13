using System;

namespace SiNoMA_MVC.Models
{
    public class Notificacao
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public int TipoEnvio { get; set; }

        public DateTime DataParaEnvio { get; set; }

        public int Repeticao { get; set; }

        public string Mensagem { get; set; }

        public byte StatusEnvio { get; set; }

        public byte StatusRecebido { get; set; }
    }
}