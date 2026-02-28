using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidatAPP.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        #region Operações de transação
        void BegionTransaction();
        void Commit();
        void Rollback();
        #endregion

        #region Acesso aos repositórios

        #endregion
    }
}
