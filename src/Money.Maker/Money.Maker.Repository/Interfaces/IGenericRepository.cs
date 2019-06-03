using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Money.Maker.Repository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);

        void Add(IList<TEntity> entities);

        void Delete(TEntity entity);

        void Delete(IList<TEntity> entities);

        TEntity Get(int id);

        Task<IList<TEntity>> Get();

        TEntity Update(TEntity entity);

        IList<TEntity> Update(IList<TEntity> entities);
    }
}
