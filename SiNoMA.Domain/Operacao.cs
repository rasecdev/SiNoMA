﻿namespace SiNoMA.Domain
{
    public class Operacao
    {
        public int ID { get; set; }

        public string Descricao { get; set; }

        public int Incluir { get; set; }

        public int Alterar { get; set; }

        public int Excluir { get; set; }

        public int Visualizar { get; set; }
    }
}