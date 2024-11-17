using ControleFuncionarios.Business.Core;
using ControleFuncionarios.Business.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios.Business.Models
{
    public class Funcionario : Entity
    {
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public Genero Genero { get; set; }
        [ForeignKey("Endereco")]
        public Guid EnderecoId { get; set; }
        public virtual Endereco Endereco{ get; set; }

    }
}
