using Money.Maker.Domain.DataModels;
using Money.Maker.Domain.ResponseModel;
using System.Collections.Generic;

namespace Money.Maker.Repository.Interfaces
{
    public interface ICityRepository : IGenericRepository<City>
    {
        IList<ViewCity> GetByStateId(int StateId);
    }
}