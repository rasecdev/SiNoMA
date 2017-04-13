using System;

namespace SiNoMA_MVC.Models
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public DateTime UltimoAcesso { get; set; }

        public string Email { get; set; }

        public int Situacao { get; set; }

        public int Administrador { get; set; }

    }
}