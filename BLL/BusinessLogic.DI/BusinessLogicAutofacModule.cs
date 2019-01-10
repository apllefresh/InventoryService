using System;
using System.Collections.Generic;
using Autofac;
using AutoMapper;
using BusinessLogic.Contract.Interfaces;
using BusinessLogic.Services;
using DataAccess.Contract.Interfaces;

namespace BusinessLogic.DI
{
    public class BusinessLogicAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BodyService>()
                .As<IBodyService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<DataService>()
                .As<IDataService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<IHeadService>()
                .As<IHeadService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ResultService>()
                .As<IResultService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<WarehouseService>()
                .As<IWarehouseService>()
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
