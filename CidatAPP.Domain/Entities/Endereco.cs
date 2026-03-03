using CidatAPP.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }    
        public string? Bairro { get; set; }
        public string? Localidade { get; set; } 
        public string? Uf { get; set; }
        public string? Cep { get; set; }
        public Guid? IdProcesso { get; set; }
        #region relacionamento
        public virtual Processo? Processo{ get; set; }
        #endregion
    }
}
