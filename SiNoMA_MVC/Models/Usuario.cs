using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiNoMA_MVC.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }

        [MaxLength(45)]
        public string Login { get; set; }

        [MaxLength(45)]
        public string Senha { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime UltimoAcesso { get; set; }

        [MaxLength(45)]
        public string Email { get; set; }

        public int Situacao { get; set; }

        public int Administrador { get; set; }

    }
}