using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ServiceDesk.SchemaBuild
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

       /* public Assembly GetAssembliesByContext(string context)
        {
            _getModuleAssembly.ke
        }*/
    }
}
