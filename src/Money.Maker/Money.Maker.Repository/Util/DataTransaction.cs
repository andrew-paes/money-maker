using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Money.Maker.Repository.Util
{
    public class DataTransaction
    {
        public DbContext _context { get; set; }

        private IDbContextTransaction _transaction;

        public void Execute(Action action, Action<DbContext, IDbContextTransaction> instanceModel)
        {
            using (var context = new DataContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        _context = context;
                        _transaction = transaction;
                        instanceModel(context, transaction);
                        action();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        throw ex;
                    }
                }
            }
        }
    }
}
