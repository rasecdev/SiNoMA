﻿namespace SiNoMA.Domain
{
    public class Ativo
    {
        public long ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}