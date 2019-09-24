using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ServiceDesk.SchemaBuild.Loaders
{
    public class ModuleAssembly
    {
        private readonly Dictionary<string, Assembly> _getModuleAssembly;
        public ModuleAssembly()
        {
            _getModuleAssembly = AppDomain
                .CurrentDomain
                .GetAssemblies()
                .Where(x => x.FullName.StartsWith("ServiceDesk"))
                .ToDictionary(x => x.ManifestModule.Name.ToLower(), x => x);
        }

        public List<Assembly> GetAssembliesByContext(string context)
        {
            var manifestModule = $"servicedesk.{context}";
            var resultAssemblies = new List<Assembly>();

            foreach (var key in _getModuleAssembly.Keys)
            {
                if (key.StartsWith(manifestModule))
                    resultAssemblies.Add(_getModuleAssembly[key]);
            }

            return resultAssemblies;
        }
    }
}
