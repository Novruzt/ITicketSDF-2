using ITicket.Entity.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITicket.DAL.Repository.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        List<TEntity> IgnoreDeleteds();
        TEntity IgnoreDeleted();
        TEntity Find(int id);
        List<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(List<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteRange(List<TEntity> entitites);
        void Update(TEntity entity);
        void UpdateRange(List<TEntity> entities);
        List<TEntity> Where(Expression<Func<TEntity, bool>> exp);
        bool Any(Expression<Func<TEntity, bool>> exp);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> exp);
        object Select(Expression<Func<TEntity, object>> exp);
        IQueryable<GEntity> Select<GEntity>(Expression<Func<TEntity, GEntity>> exp);
        IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes);
        void BeginTransaction();
        void CommitTransaction(string? message);
        void RollBackTransaction(string? message);
    }
}
