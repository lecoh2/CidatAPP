using CidatAPP.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class Niveis : BaseEntity
    {
        #region propriedades/atributos
        public string? NomeNivel { get; set; }
        #endregion
        #region Relacionamentos
        public ICollection<GrupoNiveis> GrupoNiveis { get; set; } = new List<GrupoNiveis>();
        #endregion 
    }
}