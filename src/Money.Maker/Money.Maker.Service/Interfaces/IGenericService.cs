using System.Collections.Generic;
using System.Threading.Tasks;

namespace Money.Maker.Service.Interfaces
{
    public interface IGenericService<T>
        where T : class
    {
        T Add(T entity);

        T Add(IList<T> entities);

        T Delete(int id);

        T Delete(IList<T> entities);

        T Get(int id);

        IList<T> Get();

        T Update(T entity, int id);

        T Update(IList<T> entity);
    }
}
