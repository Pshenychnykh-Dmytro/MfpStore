using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MfpStore.App.Models;

namespace MfpStore.App.Data
{
    public interface IRepository<TEntity> where TEntity: BaseModel
    {
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(Expression<Func<TEntity, bool>> condition);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> condition);

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> condition);        

        IEnumerable<TEntity> GetAll();
    }
}
