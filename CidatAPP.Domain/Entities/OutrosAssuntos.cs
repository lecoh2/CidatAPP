using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Entities
{
    public class OutrosAssuntos : Processo
    {
        public string? Nome { get; set; }
        public string? NumeroProcesso { get; set; }
        public string? Telefone { get; set; }
    }
}
