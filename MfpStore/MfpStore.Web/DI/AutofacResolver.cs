using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MfpStore.App.AppServices;
using MfpStore.App.Constants;
using MfpStore.App.Data;
using MfpStore.App.Models;

namespace MfpStore.Web.DI
{
    public class AutofacResolver
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<EntityContext>()
                .WithParameter("connectionString", GlobalConstants.DbConnection)
                .SingleInstance();

            builder.RegisterType<BaseRepository<Device>>().As<IRepository<Device>>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<MapperService>().As<IMapperService>();
            builder.RegisterType<DeviceService>().As<IDeviceService>();


            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

                //GlobalConfiguration.Configuration.DependencyResolver =
                //new AutofacWebApiDependencyResolver(container);

            
        }
    }
}