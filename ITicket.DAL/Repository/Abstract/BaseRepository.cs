using ITicket.DAL.DATA;
using ITicket.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.DAL.Repository.Abstract
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private DataContext _ctx;
        private IDbContextTransaction _transaction;

        public BaseRepository()
        {
            _ctx = new DataContext();
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }
        public void Add(TEntity entity)
        {
            _ctx.Set<TEntity>().Add(entity);
            
            Save();
        }

        public void AddRange(List<TEntity> entities)
        {
            _ctx.Set<TEntity>().AddRange(entities);
            Save();
        }

        public bool Any(Expression<Func<TEntity, bool>> exp)
        {
            return _ctx.Set<TEntity>().Any(exp);
        }

        public void Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            Save();
        }

        public void DeleteRange(List<TEntity> entities)
        {
            foreach (TEntity item in entities)
                Delete(item);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> exp)
        {
            return _ctx.Set<TEntity>().FirstOrDefault(exp);
        }

        public TEntity Find(int id)
        {
            return _ctx.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            return _ctx.Set<TEntity>().ToList();
        }

        public TEntity IgnoreDeleted()
        {
            return Where(c => c.IsDeleted != true).FirstOrDefault();
        }

        public List<TEntity> IgnoreDeleteds()
        {
            return Where(c => c.IsDeleted != true).ToList();
        }

        public object Select(Expression<Func<TEntity, object>> exp)
        {
            return _ctx.Set<TEntity>().Select(exp);
        }

        public IQueryable<GEntity> Select<GEntity>(Expression<Func<TEntity, GEntity>> exp)
        {
            return _ctx.Set<TEntity>().Select(exp);
        }

        public virtual void Update(TEntity entity)
        {
            TEntity current = Find(entity.Id);
            _ctx.Entry(current).CurrentValues.SetValues(entity);

            Save();
        }

        public void UpdateRange(List<TEntity> entities)
        {
            foreach (TEntity entity in entities)
                Update(entity);
        }

        public List<TEntity> Where(Expression<Func<TEntity, bool>> exp)
        {
            return _ctx.Set<TEntity>().Where(exp).ToList();
        }

        public IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = _ctx.Set<TEntity>().AsQueryable();

            if (includes != null)
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return query;
        }
        public void BeginTransaction()
        {
            if (_transaction == null)
                _transaction = _ctx.Database.BeginTransaction();
        }
        public void CommitTransaction(string? message)
        {
            try
            {
                _ctx.SaveChanges();
                _transaction?.Commit();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something went wrong. " + message);
            }
            finally
            {
                _transaction?.Dispose();
                _transaction = null;
            }
        }

        public void RollBackTransaction(string? message)
        {
            try
            {
                _transaction?.Rollback();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something went wrong. "+message);
            }
            finally
            {
                _transaction?.Dispose();
                _transaction = null;
            }
        }
    }
}
