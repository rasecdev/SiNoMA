using SiNoMA_MVC.Models;
using System;

namespace SiNoMA.Domain
{
    public class Notificacao
    {
        public int ID { get; set; }

        public Usuario Usuario { get; set; }

        public Ativo Ativo { get; set; }

        public string Nome { get; set; }

        public int TipoEnvio { get; set; }

        public DateTime DataParaEnvio { get; set; }

        public int Repeticao { get; set; }

        public string Mensagem { get; set; }

        public Boolean StatusEnvio { get; set; }

        public Boolean StatusRecebido { get; set; }
    }
}