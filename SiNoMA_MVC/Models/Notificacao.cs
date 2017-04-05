using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiNoMA_MVC.Models
{
    public class Notificacao
    {
        public int NOTI_ID { get; set; }

        public string NOTI_Nome { get; set; }

        public int NOTI_TipoEnvio { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime NOTI_DataParaEnvio { get; set; }

        public int NOTI_Repeticao { get; set; }

        public string NOTI_Mensagem { get; set; }

        public byte NOTI_StatusEnvio { get; set; }

        public byte StatusRecebido { get; set; }
    }
}