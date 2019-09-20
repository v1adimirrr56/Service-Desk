using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ServiceDesk.Incidents;
using System;
using System.Linq;

namespace ServiceDesk.Web.Host.Configure
{
    public static class AutomapperConfigure
    {
        public static void InitializeAutomapper(this IServiceCollection service)
        {
            var assemblies = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Where(x => x.FullName.Contains("ServiceDesk"))
                .ToList();

            service.AddAutoMapper(assemblies);
        }
    }
}
