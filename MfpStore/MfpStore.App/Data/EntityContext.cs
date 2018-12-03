using System.Data.Entity;
using MfpStore.App.Constants;
using MfpStore.App.Models;
using static MfpStore.App.Constants.GlobalConstants;

namespace MfpStore.App.Data
{
    public class EntityContext: DbContext
    {   
        public EntityContext(string connectionString) : base(connectionString)
            => Database.SetInitializer(new DbInitializer());

        public EntityContext() : base(DbConnection)
            => Database.SetInitializer(new DbInitializer());

        public new IDbSet<TEntity> Set<TEntity>()
            where TEntity : BaseModel
            => base.Set<TEntity>();

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Add settings for db
            base.OnModelCreating(modelBuilder);
        }
    }
}
