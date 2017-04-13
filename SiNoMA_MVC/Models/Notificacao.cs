using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiNoMA_MVC.Models
{
    public class Notificacao
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public int TipoEnvio { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataParaEnvio { get; set; }

        public int Repeticao { get; set; }

        public string Mensagem { get; set; }

        public byte StatusEnvio { get; set; }

        public byte StatusRecebido { get; set; }
    }
}