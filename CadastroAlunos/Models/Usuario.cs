﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroAlunos.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}