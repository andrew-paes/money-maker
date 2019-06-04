using Money.Maker.Domain.DataModels;
using Money.Maker.Domain.ResponseModel;
using System.Collections.Generic;

namespace Money.Maker.Service.Interfaces
{
    public interface ICityService : IGenericService<City>
    {
        IList<ViewCity> GetByStateId(int StateId);
    }
}