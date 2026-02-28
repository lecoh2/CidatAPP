using CidatAPP.Domain.Interfaces.Repositories;
using CidatAPP.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CidatAPP.Infra.Data.Repositories
{
    public class UnitOfWork(DataContext dataContext) : IUnitOfWork
    {
        private IDbContextTransaction? transaction;
    
        public void BegionTransaction()
        {
        if (transaction != null)
            return;
            transaction = dataContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            if (transaction != null)
                transaction.Commit();
        }
        public void Rollback()
        {
            if (transaction != null)
                transaction.Rollback();
        }
        public void Dispose()
        {
            if (transaction != null)
                transaction.Dispose();
        }

      
    }
}
