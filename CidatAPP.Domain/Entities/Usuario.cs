using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public GCNotificationStatus? Status { get; set; }
        public ICollection<GrupoNiveis> GrupoNiveis { get; set; }
    }
}
