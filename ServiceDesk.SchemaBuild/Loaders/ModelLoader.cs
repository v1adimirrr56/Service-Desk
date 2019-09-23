using ServiceDesk.SmartUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ServiceDesk.SchemaBuild.Loaders
{
    public class ModelLoader
    {
        private readonly ModuleAssembly _moduleAssembly;
        public ModelLoader(ModuleAssembly moduleAssembly)
        {
            _moduleAssembly = moduleAssembly;
        }
        public IEnumerable<PropertyInfo> LoadModel<T>(string context, string schema)
            where T : Attribute
        {
            var assembliesByContext = _moduleAssembly.GetAssembliesByContext(context.ToLower());
            return assembliesByContext
                .SelectMany(x => x.DefinedTypes)
                .Where(x => Attribute.GetCustomAttribute(x, typeof(T)) != null)
                .Single(x => x.Name.ToLower().StartsWith(schema.ToLower()))
                .GetProperties();
        }
    }
}
