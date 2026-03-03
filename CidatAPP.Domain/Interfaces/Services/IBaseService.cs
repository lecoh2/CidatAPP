using CidatAPP.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Interfaces.Services
{
    public interface IBaseService<TResquest, TResponse, TKey> : IDisposable
    {
        Task<TResponse> AdicionarAsync(TResquest request);
        Task<TResponse> Modificar(TKey id, TResquest request);
        Task<TResponse> Excluir(TKey id);
        Task<PageResult<TResponse>> ConsultarAsync
      (int pageNumber, int pageSize);
        Task<TResponse?> ObterPorIdAsync(TKey id);
    }
}
