using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using MfpStore.App.Models;

namespace MfpStore.App.Data
{
    public class BaseRepository<TEntity>: IRepository<TEntity> where TEntity: BaseModel
    {
        protected EntityContext Context;

        public BaseRepository(EntityContext context)
            => Context = context;

        public void Add(TEntity entity)
            => Context.Set<TEntity>().Add(entity);

        public void Update(TEntity entity)
            => Context.Set<TEntity>().AddOrUpdate(entity);

        public void Delete(Expression<Func<TEntity, bool>> condition)
            => Context.Set<TEntity>()
                .Where(condition).ToList()
                .ForEach(x => Context.Set<TEntity>().Remove(x));

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> condition)
            => Context.Set<TEntity>().FirstOrDefault(condition);

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> condition)
            => Context.Set<TEntity>().Where(condition);

        public IEnumerable<TEntity> GetAll()
            => Context.Set<TEntity>().ToList();
    }
}
