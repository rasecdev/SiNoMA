﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiNoMA_MVC.Models
{
    public class Operacao
    {
        public int OperacaoID { get; set; }

        [MaxLength(45)]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public int Incluir { get; set; }

        public int Alterar { get; set; }

        public int Excluir { get; set; }

        public int Visualizar { get; set; }
    }
}