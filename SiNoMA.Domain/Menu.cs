﻿namespace SiNoMA.Domain
{
    public class Menu
    {
        public int ID { get; set; }

        public string Descricao { get; set; }

        public string Url { get; set; }

        public string Icone { get; set; }

        public string Indice { get; set; }

        public PermissaoAcesso PermissaoID { get; set; }

        public Menu MenuPai { get; set; }
    }
}