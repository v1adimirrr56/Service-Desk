using Microsoft.Extensions.DependencyInjection;
using ServiceDesk.SmartUI.FormFieldsBuilder.OptionBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDesk.Web.Host.Configure
{
    public static class SelectorConfigure
    {
        public static void InitializeSelector(this IServiceCollection service)
        {
            var difindeTypes = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(ISelector).IsAssignableFrom(x))
                .Where(x => !x.IsAbstract)
                .ToList();
            foreach (var type in difindeTypes)
                service.AddScoped(type);
        }
    }
}
