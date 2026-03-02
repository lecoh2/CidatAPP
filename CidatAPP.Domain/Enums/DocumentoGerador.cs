using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Enums
{
    public enum DocumentoGerador
    {
        Oficio = 1,
        Carta = 2,
        Memorando = 3,
        Email=4,
        Circular=5,
        Comunicado=6,
        ProcessoJudicial = 7,
        Outros = 8
    }
}
