using CidatAPP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class OutrosOrgaos : Processo
    {
 
        #region Relacionamentos
        public CadastroOutrosOrgaos? CadastroOutrosOrgaos { get; set; }
        public DocumentoGerador? DocumentoGerador { get; set; }
        #endregion
    }
}
