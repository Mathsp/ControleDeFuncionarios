﻿using ControleFuncionarios.Business.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios.Business.Models
{
    public class Estado : Entity
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}