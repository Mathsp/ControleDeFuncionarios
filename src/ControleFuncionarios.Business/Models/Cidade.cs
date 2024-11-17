using ControleFuncionarios.Business.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios.Business.Models
{
    public class Cidade : Entity
    {
        public string Nome { get; set; }
        [ForeignKey("Estado")]
        public Guid EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
