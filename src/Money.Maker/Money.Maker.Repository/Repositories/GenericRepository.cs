using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Money.Maker.Domain.DataModels;
using Money.Maker.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Money.Maker.Repository.Repositories
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : GenericModel
    {
        protected readonly DataContext _context;

        protected readonly IDbContextTransaction _transaction;

        public GenericRepository(DataContext context, IDbContextTransaction transaction)
        {
            _context = context;
            _transaction = transaction;
        }

        public TEntity Add(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public void Add(IList<TEntity> entities)
        {
            try
            {
                _context.Set<TEntity>().AddRange(entities);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public async Task<IList<TEntity>> Get()
        {
            List<TEntity> list = await _context.Set<TEntity>().ToListAsync();

            return list;
        }

        public void Delete(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(IList<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.Entry(entity).Property(o => o.CreatedDate).IsModified = false;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return entity;
        }

        public IList<TEntity> Update(IList<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}
