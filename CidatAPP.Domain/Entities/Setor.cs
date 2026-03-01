using CidatAPP.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class Setor : BaseEntity
    {
        public string? NomeSetor { get; set; }
        public ICollection<GrupoSetores> GrupoSetores { get; set; } = new List<GrupoSetores>();
    }
}
