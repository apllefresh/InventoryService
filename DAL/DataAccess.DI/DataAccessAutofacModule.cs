using Autofac;
using DataAccess.Contract.Interfaces;
using DataAccess.Repositories;
using DataAccess.EF;
using AutoMapper;
using System.Collections.Generic;
using System;

namespace DataAccess.DI
{
    public class DataAccessAutofacModule : Module
    {
        private readonly string _inventoryConnectionString;

        public DataAccessAutofacModule(string inventoryConnectionString)
        {
            _inventoryConnectionString = inventoryConnectionString
                ?? throw new ArgumentNullException(nameof(inventoryConnectionString));
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BodyRepository>()
                .As<IBodyRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DataRepository>()
                .As<IDataRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<HeadRepository>()
                .As<IHeadRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResultRepository>()
                .As<IResultRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WarehouseRepository>()
                 .As<IWarehouseRepository>()
                 .InstancePerLifetimeScope();
            

            builder.Register(context => new DataAccessContext
            (
               connectionString: _inventoryConnectionString
            )).AsSelf()
            .InstancePerLifetimeScope();

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            builder.RegisterAssemblyTypes(assemblies)
                .Where(t => typeof(Profile).IsAssignableFrom(t) && !t.IsAbstract && t.IsPublic)
                .As<Profile>();

            builder.Register(c => new MapperConfiguration(cfg =>
            {
                foreach (var profile in c.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            })).AsSelf().SingleInstance();
            builder.Register(c => c.Resolve<MapperConfiguration>()
                    .CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();
        }
    }
}
