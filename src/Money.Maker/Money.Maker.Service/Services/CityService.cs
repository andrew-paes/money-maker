using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Money.Maker.Domain.DataModels;
using Money.Maker.Domain.ResponseModel;
using Money.Maker.Repository;
using Money.Maker.Repository.Interfaces;
using Money.Maker.Repository.Repositories;
using Money.Maker.Service.Interfaces;
using System.Collections.Generic;

namespace Money.Maker.Service.Services
{
    public class CityService : GenericService<City, CityRepository>, ICityService
    {
        private ICityRepository _repository;

        private void LoadModel(DbContext dbContext, IDbContextTransaction transaction) 
            => _repository = new CityRepository((DataContext)dbContext, transaction);

        public IList<ViewCity> GetByStateId(int StateId)
        {
            IList<ViewCity> returnList = new List<ViewCity>();

            dataTransaction
                .Execute
                    (() => returnList = _repository.GetByStateId(StateId),
                    LoadModel);

            return returnList;
        }
    }
}