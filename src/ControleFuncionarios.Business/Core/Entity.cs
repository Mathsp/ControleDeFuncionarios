using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios.Business.Core
{
    public class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            DataInclusao = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime DataInclusao { get; set; }
        public Guid UsuarioInclusao { get; set; }
        public Guid UsuarioAlteracao { get; set; }
    }
}
