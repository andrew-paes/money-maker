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
            E result = null;

            dataTransaction
                .Execute(
                    () => result = _genericRepository.Add(entity),
                    LoadModel);

            return result;
        }

        public E Add(IList<E> entities)
        {
            throw new NotImplementedException();
        }

        public E Get(int id)
        {
            E result = null;

            dataTransaction
                .Execute(
                    () => result = _genericRepository.Get(id),
                    LoadModel);

            return result;
        }

        public IList<E> Get()
        {
            IList<E> result = new List<E>();

            dataTransaction
                .Execute(
                    async () => result = await _genericRepository.Get(),
                    LoadModel);

            return result;
        }

        public E Delete(int id)
        {
            var entity = this.Get(id);

            E result = null;

            if (entity != null && entity.Id > 0)
            {
                dataTransaction
                    .Execute(
                        () => _genericRepository.Delete(entity),
                        LoadModel);
            }
            else
            {
                throw new ArgumentException("Object not found.");
            }

            return result;
        }

        public E Delete(IList<E> entities)
        {
            throw new NotImplementedException();
        }

        public E Update(E entity, int id)
        {
            var entityId = entity.GetType().GetProperty("Id").GetValue(entity);

            long tryId = 0;

            if (entityId != null && !String.IsNullOrEmpty(entityId.ToString()))
            {
                if(long.TryParse(entityId.ToString(), out tryId))
                {
                    if (Convert.ToInt32(entityId.ToString()) != id)
                    {
                        throw new ArgumentException("Object Id is not equal to Id specified on URL.");
                    }
                }
                else
                {
                    throw new ArgumentException("Object Id must be an Integer.");
                }
            }   

            E result = null;

            dataTransaction
                .Execute(
                        () => result = _genericRepository.Update(entity),
                        LoadModel);

            return result;
        }

        public E Update(IList<E> entity)
        {
            throw new NotImplementedException();
        }
    }
}
