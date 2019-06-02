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

        void Remove(TEntity entity);

        void Remove(IList<TEntity> entities);

        TEntity Get(string id);

        Task<IList<TEntity>> Get();

        TEntity Update(TEntity entity);

        IList<TEntity> Update(IList<TEntity> entities);
    }
}
