using ControleFuncionarios.Business.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ControleFuncionarios.Business.Models
{
    public class Usuario : IdentityUser<Guid>
    {
        public Usuario()
        {
            DataInclusao = DateTime.Now;
        }
        public string Nome { get; set; }
        public override string Email { get; set; }
        public string Celular { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
