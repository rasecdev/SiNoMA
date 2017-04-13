﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiNoMA_MVC.Models
{
    public class GrupoAcesso
    {
        public int GrupoID { get; set; }

        [MaxLength(45)]
        [DataType(DataType.MultilineText)]
        public string Descricao { get; set; }

        public Usuario UsuarioID { get; set; }
    }
}