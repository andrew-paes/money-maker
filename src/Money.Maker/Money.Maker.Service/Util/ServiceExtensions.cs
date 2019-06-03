using Microsoft.Extensions.DependencyInjection;
using Money.Maker.Domain.DataModels;
using Money.Maker.Repository.Repositories;
using Money.Maker.Service.Interfaces;
using Money.Maker.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Money.Maker.Service.Util
{
    public static class ServiceExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            Assembly assembly = Assembly.Load(typeof(IGenericService<GenericService<GenericModel, GenericRepository<GenericModel>>>).Assembly.GetName().Name);
            Assembly[] assemblies = new[] { typeof(GenericService<GenericModel, GenericRepository<GenericModel>>).Assembly };

            List<System.Type> assemblyTypeList = assembly.ExportedTypes
                                                .Where(o => o.Name.EndsWith("Service"))
                                                .ToList();

            foreach (var assemblyType in assemblyTypeList)
            {
                IEnumerable<TypeInfo> typesFromAssemblies = assemblies
                                                            .SelectMany(a => a.DefinedTypes.Where(x => x.GetInterfaces()
                                                            .Contains(assemblyType)));

                foreach (var type in typesFromAssemblies)
                {
                    services.Add(new ServiceDescriptor(assemblyType, type, ServiceLifetime.Transient));
                }
            }
        }
    }
}