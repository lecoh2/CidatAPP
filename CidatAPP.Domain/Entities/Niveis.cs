using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class Niveis
    {
        public Guid IdNivel { get; set; }
        public string? NomeNivel { get; set; }  
        public ICollection<GrupoNiveis> GrupoNiveis { get; set; } = new List<GrupoNiveis>();
    }
}