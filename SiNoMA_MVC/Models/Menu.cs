using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiNoMA_MVC.Models
{
    public class Menu
    {
        public int MenuID { get; set; }

        [MaxLength(45)]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        [MaxLength(150)]
        public string Url { get; set; }

        [MaxLength(45)]
        public string Icone { get; set; }

        [MaxLength(45)]
        public string Indice { get; set; }

        public PermissaoAcesso PermissaoID { get; set; }

        public Menu MenuPai { get; set; }
    }
}