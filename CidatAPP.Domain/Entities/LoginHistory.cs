using CidatAPP.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class LoginHistory : BaseEntity
    {
        public Guid IdUsuario { get; set; }
        public string? IpAcesso { get; set; }
        public string? UserAgent { get; set; }
        public DateTime DataHoraAcesso { get; set; } = DateTime.Now;
        public bool Sucesso { get; set; }
        public string? Mensagem { get; set; }

        // Relação com usuário
        public virtual Usuario Usuario { get; set; } = null!;
    }
}
