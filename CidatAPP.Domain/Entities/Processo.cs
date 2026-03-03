using CidatAPP.Domain.Commons;
using CidatAPP.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public abstract class Processo : BaseEntity
    {
        #region propriedades/atributos
        public string Nome { get; set; } = string.Empty;
        public string NumeroProcesso { get; set; }
        public string Telefone { get; set; } = string.Empty;
        public string AnoProcesso { get; set; } = string.Empty;
        public string Cda { get; set; } = string.Empty;
        public DateOnly Cadastro { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateOnly Atualizacao { get; set; }
        public DateTime DAtaAtualizacao { get; set; }
        public string Oficio { get; set; } =string.Empty;
        public DateOnly PrazoInicial { get; set; }
        public DateOnly PrazoFinal { get; set; }
        public int Recebido { get; set; }
        public string Observacao { get; set; } = string.Empty;

        #endregion
        #region Relacionamentos
        public Guid IdUsuario { get; set; }
        public Guid IdLocalizacao { get; set; }
        public Guid IdSubLocalizacao { get; set; }
        public Guid IdAdvogado { get; set; }
        public Guid IdEstagiario { get; set; }
        public Guid IdDocumento { get; set; }
        public Endereco? Endereco { get; set; }
        #region Enumerdores
        public Retorno? Retorno{ get; set; }
        #endregion
     

        #endregion
    }
}
