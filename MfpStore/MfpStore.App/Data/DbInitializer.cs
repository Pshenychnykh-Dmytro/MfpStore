using System.Data.Entity;

namespace MfpStore.App.Data
{
    public class DbInitializer: CreateDatabaseIfNotExists<EntityContext>
    {
        protected override void Seed(EntityContext context)
        {
            //add first initialization;
            base.Seed(context);
        }
    }
}
