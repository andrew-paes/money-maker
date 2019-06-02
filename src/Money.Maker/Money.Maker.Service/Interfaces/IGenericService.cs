using System.Collections.Generic;
using System.Threading.Tasks;

namespace Money.Maker.Service.Interfaces
{
    public interface IGenericService<T>
        where T : class
    {
        T Add(T entity);

        T Add(IList<T> entities);

        T Remove(string id);

        T Remove(IList<T> entities);

        T Get(string id);

        Task<IList<T>> Get();

        T Update(T entity, string id);

        T Update(IList<T> entity);
    }
}
