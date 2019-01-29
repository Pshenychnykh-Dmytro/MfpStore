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
using MfpStore.Web.Security;

namespace MfpStore.Web.DI
{
    public class AutofacResolver
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            RegisterApplicationServices(builder);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

        private static void RegisterApplicationServices(ContainerBuilder builder)
        {
            builder.RegisterType<EntityContext>()
                .WithParameter("connectionString", GlobalConstants.DbConnection)
                .SingleInstance();
            builder.RegisterType<BaseRepository<Device>>().As<IRepository<Device>>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<LoggerService>().As<ILoggerService>();
            builder.RegisterType<MapperService>().As<IMapperService>();
            builder.RegisterType<DeviceService>().As<IDeviceService>();
            builder.RegisterType<AccountService>().As<IAccountService>();
            builder.RegisterType<Authentication>().As<IAuthentication>();

        }
    }
}