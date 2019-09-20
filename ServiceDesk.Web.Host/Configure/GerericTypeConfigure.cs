using Microsoft.Extensions.DependencyInjection;
using ServiceDesk.Infrastructure.ActionHandler;
using ServiceDesk.Infrastructure.Runners;
using ServiceDesk.Infrastructure.ServiceHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDesk.Web.Host.Configure
{
    public static class GerericTypeConfigure
    {
        public static void InitializeActionHandlers(this IServiceCollection service)
        {
            service.RegisterGenericType(typeof(IActionHandler<,>));
        }

        public static void InitializeServiceHandlers(this IServiceCollection service)
        {
            service.RegisterGenericType(typeof(IServiceHandler<>));
        }

        public static void InitializeServiceQueryHandlers(this IServiceCollection service)
        {
            service.RegisterGenericType(typeof(IServiceQueryHandler<,>));
        }

        
        private static ICollection<Type> FindImplementedGenericInterfaces(this IServiceCollection service, Type typeInterface)
            => AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => x.GetInterfaces().Any(y => y.IsGenericType
                        && y.GetGenericTypeDefinition() == typeInterface))
                .ToList();

        private static void RegisterGenericType(this IServiceCollection service, Type typeInterface)
        {
            var difindeTypes = service.FindImplementedGenericInterfaces(typeInterface);
            foreach (var type in difindeTypes)
            {
                var arguments = type
                    .GetInterfaces()
                    .Single(x => x.GetGenericTypeDefinition() == typeInterface)
                    .GetGenericArguments();
                service.AddScoped(typeInterface.MakeGenericType(arguments), type);
            }
        }
    }
}
