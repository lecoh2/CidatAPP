using CidatAPP.Domain.Dtos.Usuario.Request;
using CidatAPP.Domain.Dtos.Usuario.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Interfaces.Services
{
    /// <summary> 
    /// Interface específica para serviços de Usuário 
    /// </summary> 
    public interface IUsuarioService : IBaseService<UsuarrioRequest,UsuarioResponse, Guid>
    {

    }
}
