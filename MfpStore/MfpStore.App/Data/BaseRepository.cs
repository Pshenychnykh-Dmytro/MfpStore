using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using MfpStore.App.Models;

namespace MfpStore.App.Data
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
    {
        protected internal readonly EntityContext Context;

        public BaseRepository(EntityContext context)
            => Context = context;

        public virtual void Add(TEntity entity)
        {
            entity.Id = Guid.NewGuid();
            Context.Set<TEntity>().Add(entity);
        }
    

        public virtual void Update(TEntity entity)
            => Context.Set<TEntity>().AddOrUpdate(entity);

        public virtual void Delete(Expression<Func<TEntity, bool>> condition)
            => Context.Set<TEntity>()
                .Where(condition)
                .ToList()
                .ForEach(x => Context.Set<TEntity>().Remove(x));
        

        public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> condition)
            => Context.Set<TEntity>().FirstOrDefault(condition);

        public virtual IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> condition)
            => Context.Set<TEntity>().Where(condition);

        public virtual IEnumerable<TEntity> GetAll()
            => Context.Set<TEntity>().ToList();
    }
}
