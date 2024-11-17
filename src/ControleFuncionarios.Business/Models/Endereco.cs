using ControleFuncionarios.Business.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios.Business.Models
{
    public class Endereco : Entity
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        [ForeignKey("Cidade")]
        public Guid CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
        [ForeignKey("Estado")]
        public Guid EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
