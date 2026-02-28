using CidatAPP.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class GrupoNiveis :  BaseEntity
    {
        #region Propriedades 
        public Guid IdUsuario { get; set;}
        #endregion
        #region Relacionamentos
        public Usuario Usuario { get; set; }
        public Niveis Niveis { get; set; }
        #endregion
    }
}
