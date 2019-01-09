using System;
using System.Data.Entity;
using System.Runtime.InteropServices.ComTypes;
using MfpStore.App.Models;

namespace MfpStore.App.Data
{
    public class DbInitializer: CreateDatabaseIfNotExists<EntityContext>
    {
        protected override void Seed(EntityContext context)
        {
            //add first initialization;
            var devices = new[]
            {
                new Device {Id = Guid.NewGuid(), Title = "Printer1", Price = (float)1.61, Description = "Description1"},
                new Device {Id = Guid.NewGuid(), Title = "Printer2", Price = (float)2.62, Description = "Description2"},
                new Device {Id = Guid.NewGuid(), Title = "Printer3", Price = (float)3.63, Description = "Description3"},
                new Device {Id = Guid.NewGuid(), Title = "Printer4", Price = (float)4.64, Description = "Description4"}
            };

            foreach (var device in devices)
            {
                context.Set<Device>().Add(device);
            }

            context.SaveChanges();
            
            base.Seed(context);
        }
    }
}
