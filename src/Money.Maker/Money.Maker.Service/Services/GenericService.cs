using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Money.Maker.Domain.DataModels;
using Money.Maker.Repository.Interfaces;
using Money.Maker.Repository.Repositories;
using Money.Maker.Repository.Util;
using Money.Maker.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Money.Maker.Service.Services
{
    public abstract class GenericService<E, R> : IGenericService<E> where E : GenericModel
                                                                    where R : GenericRepository<E>
    {
        private IGenericRepository<E> _genericRepository;

        protected DataTransaction dataTransaction;

        public GenericService()
        {
            dataTransaction = new DataTransaction();
        }

        protected R GetRepository(DbContext context, IDbContextTransaction transaction)
        {
            return (R)Activator.CreateInstance(typeof(R), context, transaction);
        }

        private void LoadModel(DbContext context, IDbContextTransaction transaction)
        {
            _genericRepository = GetRepository(context, transaction);
        }

        public E Add(E entity)
        {
            throw new NotImplementedException();
        }

        public E Add(IList<E> entities)
        {
            throw new NotImplementedException();
        }

        public E Get(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<E>> Get()
        {
            IList<E> result = new List<E>();
            
            dataTransaction
                .Execute(
                    async () => result = await _genericRepository.Get(),
                    LoadModel);

            return result;
        }

        public E Remove(string id)
        {
            throw new NotImplementedException();
        }

        public E Remove(IList<E> entities)
        {
            throw new NotImplementedException();
        }

        public E Update(E entity, string id)
        {
            throw new NotImplementedException();
        }

        public E Update(IList<E> entity)
        {
            throw new NotImplementedException();
        }
    }
}
