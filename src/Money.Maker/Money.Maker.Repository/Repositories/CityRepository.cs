using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Money.Maker.Domain.DataModels;
using Money.Maker.Domain.ResponseModel;
using Money.Maker.Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Money.Maker.Repository.Repositories
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        private new readonly DataContext _context;

        public CityRepository(DataContext context, IDbContextTransaction transaction)
            : base(context, transaction)
        {
            _context = context;
        }

        public IList<ViewCity> GetByStateId(int StateId)
        {
            IList<ViewCity> returnList = _context.Cities
                                        .Join(_context.States,
                                        city => city.State.Id,
                                        state => state.Id,
                                        (city, state) => new ViewCity
                                        {
                                            CityId = city.Id,
                                            CityName = city.Name,
                                            StateId = state.Id,
                                            StateName = state.Name
                                        })
                                        .Where(x => x.StateId == StateId).OrderBy(x => x.CityName)
                                        .ToList();

            return returnList;
        }
    }
}