using CidatAPP.Domain.Commons;
using CidatAPP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class ProcessoPessoaFisica : Processo
    {
        public DateOnly Nascimento { get; set; }
        public string? CadastroEconomico { get; set; }
        #region Relacionamentos
        public CadastroPessoaFisica? CadastroPessoaFisica { get; set; }
        public OutrosAssuntos? OutrosAssuntos { get; set; }
        #endregion
    }
}
