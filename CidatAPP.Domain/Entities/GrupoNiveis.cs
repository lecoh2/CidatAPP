using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class GrupoNiveis
    {
        public Guid IdNivel { get; set; } = Guid.NewGuid();
       public Guid IdUsuario { get; set;}
        public Usuario Usuario { get; set; }
        public Niveis Niveis { get; set; }
    }
}
