﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rx.EntityFramework
{
    public interface IRepository<TEntity> where TEntity : class 
    {
        IQueryable<TEntity> Queryable();
        IEnumerable<TEntity> All();

        Task<IEnumerable<TEntity>> AllAsync();

        IEnumerable<TEntity> AllInclude
        (params Expression<Func<TEntity, object>>[] includeProperties);

        IEnumerable<TEntity> FindByInclude
          (Expression<Func<TEntity, bool>> predicate,
          params Expression<Func<TEntity, object>>[] includeProperties);

        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity FindByKey(int id);

        Task<TEntity> FindByKeyAsync(int id);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity Single(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity First(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity LastOrDefault(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> LastOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        TEntity Last(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> LastAsync(Expression<Func<TEntity, bool>> predicate);
        int Count(Expression<Func<TEntity, bool>> predicate);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Get(int pageNumber, int pageSize);

        IEnumerable<TEntity> Get(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Get(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

        Task<IEnumerable<TEntity>> GetAsync(int pageNumber, int pageSize);

        Task<IEnumerable<TEntity>> GetAsync(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetAsync(int pageNumber, int pageSize, Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);

    }
}
