using CidatAPP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class ProcessoPessoJuridica : Processo
    {
        
        public string? CNPJ { get; set; }
        public string? RepresentanteLegal{ get; set; }
        public string? InscricaoMunicipal { get; set; }
        public string? RamoAtividade { get; set; }

        #region Relacionamentos
        public CadastroPessoaJuridica? CadastroPessoaJuridica { get; set; }
        #endregion
    }
}
