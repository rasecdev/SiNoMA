using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiNoMA_MVC.Models
{
    public class Ativo
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        [MaxLength(45)]
        [DataType(DataType.MultilineText)]
        public string Descricaos { get; set; }

    }
}