using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiNoMA_MVC.Models
{
    public class Ativo
    {
        public int ATIV_ID { get; set; }

        public string ATIV_Nome { get; set; }

        [MaxLength(45)]
        [DataType(DataType.MultilineText)]
        public string ATIV_Descricaos { get; set; }

    }
}