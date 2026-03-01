using CidatAPP.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class GrupoSetores : BaseEntity
    {
        public Guid IdUsuario { get; set; }
        public Guid IdSetor { get; set; }
        public Usuario Usuario { get; set; }
        public Setor Setor { get; set; }

    }
}
